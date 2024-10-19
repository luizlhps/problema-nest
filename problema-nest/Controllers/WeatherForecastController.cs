using Microsoft.AspNetCore.Mvc;
using Nest;

namespace problema_nest.Controllers;

[ApiController]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("login")]
    public async Task<WeatherForecast> Get()
    {
        var settings = new ConnectionSettings(new Uri("http://localhost:9200")).DefaultIndex("documento").EnableDebugMode().PrettyJson();
        var client = new ElasticClient(settings);


        //criar os chunskparent
        var documento = new Documento
        {
            Id = 1,
            Nome = "Lei 14.133",
            Chunking = new List<Chunking>
    {
        new Chunking
        {
            ChunkParent = new ChunkParent
            {
                Id = 1,
                TipoCorpo = 1,
                Chunk = new List<Chunk>
                {
                    new Chunk
                    {
                        Sequence = 1,
                        Texto = "a lei 14.133 é foda",
                        Float = new List<float> { 123, 123, 123, 123 }
                    },
                    new Chunk
                    {
                        Sequence = 2,
                        Texto = "ela fala sobre",
                        Float = new List<float> { 123, 123, 123, 123 }
                    },
                    new Chunk
                    {
                        Sequence = 3,
                        Texto = "algumas coisas",
                        Float = new List<float> { 123, 123, 123, 123 }
                    }
                }
            }
        },
        new Chunking
        {
            ChunkParent = new ChunkParent
            {
                Id = 2,
                TipoCorpo = 2,
                Chunk = new List<Chunk>
                {
                    new Chunk
                    {
                        Sequence = 1,
                        Texto = "a lei 14.133 é foda",
                        Float = new List<float> { 123, 123, 123, 123 }
                    },
                    new Chunk
                    {
                        Sequence = 2,
                        Texto = "a lei 14.133 é foda",
                        Float = new List<float> { 123, 123, 123, 123 }
                    },
                    new Chunk
                    {
                        Sequence = 3,
                        Texto = "a lei 14.133 é foda",
                        Float = new List<float> { 123, 123, 123, 123 }
                    }
                }
            }
        }
    }
        };



        //adicionar nos chunksparents os chunks

        var newChinking1 = new
        {
            chunks = new { info = "nova informação 1" }
        };

        var newChinking2 = new
        {
            chunks = new { info = "nova informação 2" }
        };

        var newChinking3 = new
        {
            chunks = new { info = "nova informação 3" }
        };

        foreach (var chunking in documento.Chunking)
        {

            var chunkingMock = new Chunking
            {
                ChunkParent = new ChunkParent
                {
                    Id = chunking.ChunkParent.Id,
                    TipoCorpo = chunking.ChunkParent.TipoCorpo,
                    Chunk = new List<Chunk>
                    {

                    }
                }
            };

            //adiciona os chunking
            var result = await client.UpdateAsync<object>(1, e => e
            .Index("documento")
            .Script(s => s
                .Source(@"
            if (ctx._source.chunkininfo == null) {
                ctx._source.chunkininfo = new ArrayList();
            }
            
                ctx._source.chunkininfo.add(params.newChinking1);
      
            ")
                .Lang("painless")
                .Params(p => p.Add("newChinking1", chunkingMock))
            )
        );

            //adciona os chunks do chunking
            foreach (var chunk in chunking.ChunkParent.Chunk)
            {

                var resultChild = await client.UpdateAsync<object>(1, e => e
                            .Index("documento")
                            .Script(s => s
                                .Source(@"
                                if (ctx._source.chunkininfo == null) {
                                    for (int i = 0; i < ctx._source.chunkininfo.size(); i++) {
                                        if(ctx._source.chunkininfo[i].chunkParent.id == params.chunkParentId) {
                                            if(ctx._source.chunkininfo[i].chunkParent.chunk == null) {
                                                ctx._source.chunkininfo[i].chunkParent.chunk = new ArrayList();
                                            }
                                            ctx._source.chunkininfo[i].chunkParent.chunk.add(params.newChunk);
                                            break;
                                        }
                                    
                                    }
                                }
                            ")
                                .Lang("painless")
                                .Params(p => p
                                .Add("chunkParentId", chunking.ChunkParent.Id)
                                .Add("newChinking1", chunk)

                                )
                            )
                        );
            }

        }


        return null;
    }
}
public class Documento
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<Chunking> Chunking { get; set; }
}

public class Chunking
{
    public ChunkParent ChunkParent { get; set; }
}

public class ChunkParent
{
    public int Id { get; set; }
    public int TipoCorpo { get; set; }
    public List<Chunk> Chunk { get; set; }
}

public class Chunk
{
    public int Sequence { get; set; }
    public string Texto { get; set; }
    public List<float> Float { get; set; }
}
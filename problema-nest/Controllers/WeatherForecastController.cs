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

        var result = await client.UpdateAsync<object>(1, e => e
            .Index("documento")
            .Script(s => s
                .Source(@"
            if (ctx._source.chunkininfo == null) {
                ctx._source.chunkininfo = new ArrayList();
            }
            
            if (ctx._source.chunkininfo.size() == 0 || ctx._source.chunkininfo[0].chinking == null) {
                ctx._source.chunkininfo.add(new HashMap());
                ctx._source.chunkininfo[0].chinking = new ArrayList();
            }
            // Adiciona os novos chunks
            ctx._source.chunkininfo[0].chinking.add(params.newChinking1);
            ctx._source.chunkininfo[0].chinking.add(params.newChinking2);
            ctx._source.chunkininfo[0].chinking.add(params.newChinking3);
        ")
                .Lang("painless")
                .Params(p => p.Add("newChinking1", newChinking1)
            .Add("newChinking2", newChinking2)
            .Add("newChinking3", newChinking3))
            )
        );
        return null;
    }
}

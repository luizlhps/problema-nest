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
                        Texto = "Moradia em São Paulo: Desafios e Perspectivas\n\nSão Paulo, a maior cidade do Brasil e um dos principais centros urbanos da América Latina, é conhecida por sua diversidade cultural, econômica e social. Entretanto, essa metrópole enfrenta desafios significativos em relação à moradia. Com uma população de mais de 12 milhões de habitantes, a demanda por habitação é imensa, resultando em um cenário complexo e multifacetado.\n\nA questão da moradia em São Paulo é marcada por uma profunda desigualdade social. De acordo com dados do IBGE, um número considerável de paulistanos vive em favelas e áreas informais. Essas comunidades, que representam uma parte significativa da cidade, enfrentam problemas como falta de infraestrutura, acesso limitado a serviços públicos e uma precariedade habitacional alarmante. A desigualdade se torna ainda mais evidente quando se observa a disparidade entre os diferentes bairros da cidade. Enquanto regiões como Jardins e Itaim Bibi ostentam condomínios luxuosos e áreas arborizadas, outras, como Heliópolis e Paraisópolis, lidam com uma realidade de vulnerabilidade e exclusão.\n\nAlém da desigualdade, o preço dos imóveis em São Paulo é um fator crucial que afeta a vida dos seus habitantes. Nos últimos anos, o valor dos imóveis aumentou substancialmente, tornando-se inacessível para muitas famílias. O sonho da casa própria tornou-se cada vez mais distante para os trabalhadores com renda média ou baixa, que são forçados a optar por moradias em regiões periféricas, onde a infraestrutura e o acesso a serviços são limitados. A locação também não é uma solução viável para muitos, pois os aluguéis nas áreas centrais da cidade são exorbitantes e frequentemente inviáveis para a classe trabalhadora.\n\nA presença de áreas de preservação e parques urbanos, como o Parque Ibirapuera, contribui para a qualidade de vida em alguns bairros, mas a necessidade de mais espaços verdes e acessíveis é evidente em várias regiões da cidade. A urbanização desordenada e a falta de planejamento urbano adequado resultaram em um crescimento desigual, com áreas densamente povoadas carecendo de serviços básicos, como saúde, educação e transporte público.\n\nOs programas habitacionais, como o \"Minha Casa, Minha Vida\", foram implementados na tentativa de amenizar a crise habitacional. No entanto, muitos críticos apontam que esses programas não atendem à demanda real por moradia de qualidade. A burocracia, a corrupção e a falta de fiscalização muitas vezes resultam em projetos mal planejados e em condições inadequadas de moradia. Os novos empreendimentos frequentemente não consideram as necessidades locais, levando à construção de unidades habitacionais em áreas remotas, sem a devida infraestrutura e acesso a serviços essenciais.\n\nA luta por moradia em São Paulo não é apenas uma questão econômica; é uma questão de direitos humanos. Movimentos sociais e organizações não governamentais têm se mobilizado para defender o direito à moradia digna e acessível para todos. Esses grupos buscam pressionar o governo para que políticas habitacionais mais inclusivas sejam adotadas, priorizando a regularização de ocupações informais e a construção de habitações de interesse social.\n\nA perspectiva futura para a moradia em São Paulo exige um olhar atento para a sustentabilidade e a inclusão. Projetos que integrem áreas verdes, transportes públicos eficientes e acessíveis, e uma infraestrutura urbana sólida são essenciais para melhorar a qualidade de vida na cidade. A participação da comunidade na elaboração de políticas habitacionais também é fundamental para garantir que as soluções atendam às reais necessidades dos moradores.\n\nCom o avanço da tecnologia, novas soluções estão sendo exploradas para lidar com a crise habitacional. O uso de dados geoespaciais e sistemas de informação podem ajudar na identificação de áreas prioritárias para investimento e desenvolvimento urbano. Iniciativas de moradia colaborativa e co-housing também estão ganhando força, proporcionando alternativas viáveis e sustentáveis para o acesso à moradia.\n\nEm suma, a moradia em São Paulo é um tema de grande relevância e complexidade. Com a crescente urbanização e a luta por espaços dignos, é fundamental que todas as partes interessadas se unam para criar soluções que promovam a inclusão social e a equidade no acesso à habitação. Somente assim, São Paulo poderá se tornar uma cidade verdadeiramente justa e sustentável para todos os seus habitantes.",
                        Float = new List<float> {
                                -0.045899242f,
                                0.07051648f,
                                -0.016795311f,
                                0.040280953f,
                                -0.022473158f,
                                -0.014810049f,
                                -0.03561559f,
                                0.025867954f,
                                -0.107601166f,
                                0.021420969f,
                                -0.011752747f,
                                0.029739214f,
                                0.045938946f,
                                -0.024200335f,
                                -0.048837427f,
                                -0.08933676f,
                                0.05356235f,
                                0.015475112f,
                                0.044708084f,
                                0.010660853f,
                                -0.055666726f,
                                -0.03934788f,
                                -0.04748745f,
                                0.05272854f,
                                0.0029332235f,
                                -0.0062982417f,
                                0.024061367f,
                                0.025927512f,
                                -0.021242296f,
                                -0.010134759f,
                                -0.10013658f,
                                -0.012963756f,
                                -0.00032601712f,
                                -0.08488977f,
                                -0.03851407f,
                                -0.031406835f,
                                0.015246807f,
                                -0.003980449f,
                                0.056659356f,
                                0.039586112f,
                                -0.010511959f,
                                -0.08838383f,
                                -0.03744203f,
                                -0.010402769f,
                                0.081475124f,
                                -0.003886149f,
                                -0.034305315f,
                                -0.060748994f,
                                -0.05606378f,
                                0.0002656838f,
                                -0.029878182f,
                                0.002209844f,
                                -0.025431197f,
                                -0.00991638f,
                                -0.043199286f,
                                0.045065433f,
                                0.012735452f,
                                -0.06452099f,
                                0.01644789f,
                                0.050941806f,
                                -0.020984212f,
                                0.030076709f,
                                -0.0493933f,
                                0.012278841f,
                                0.011633631f,
                                -0.01682509f,
                                -0.0076134773f,
                                -0.03815672f,
                                0.03821628f,
                                -0.009221539f,
                                -0.0012767712f,
                                0.033094306f,
                                0.044191916f,
                                -0.033987675f,
                                -0.03061273f,
                                -0.04990947f,
                                0.01649752f,
                                -0.01287442f,
                                -0.037481733f,
                                0.015574375f,
                                0.0025783582f,
                                -0.030910518f,
                                0.028984815f,
                                -0.039268468f,
                                0.07726637f,
                                -0.042524297f,
                                -0.020825392f,
                                -0.12181564f,
                                0.05804904f,
                                0.05022711f,
                                -0.03502001f,
                                -0.021917285f,
                                0.034126643f,
                                0.02157979f,
                                0.001852497f,
                                -0.035754558f,
                                -0.07198557f,
                                -0.03865304f,
                                0.024716504f,
                                0.024339303f,
                                -0.05920049f,
                                0.020070992f,
                                0.0029257787f,
                                -0.0448272f,
                                -0.0052609425f,
                                -0.015276586f,
                                0.005504137f,
                                0.025292229f,
                                -0.0056232526f,
                                0.109983474f,
                                0.025649576f,
                                -0.042047836f,
                                0.0031218233f,
                                0.019693792f,
                                -0.057016704f,
                                -0.04141255f,
                                0.040936086f,
                                -0.12729496f,
                                0.027714247f,
                                0.06483863f,
                                0.03533765f,
                                -0.043040466f,
                                0.05197414f,
                                -0.008144534f,
                                -0.09561019f,
                                0.0410155f,
                                -0.020765834f,
                                -0.030831108f,
                                -0.030414203f,
                                0.03370974f,
                                -0.027972331f,
                                0.053165298f,
                                -0.035913378f,
                                -0.0016849905f,
                                0.06726065f,
                                -0.07587669f,
                                0.028349532f,
                                0.02096436f,
                                -0.0003812322f,
                                -0.0019914652f,
                                -0.067181244f,
                                -0.07397084f,
                                -0.05356235f,
                                -0.017241994f,
                                -0.04915507f,
                                0.009966012f,
                                0.008144534f,
                                0.08782796f,
                                -0.03502001f,
                                0.007926156f,
                                -0.006055047f,
                                -0.06511657f,
                                0.07627374f,
                                0.07587669f,
                                0.018234625f,
                                0.049710944f,
                                -0.03351121f,
                                0.037561145f,
                                -0.061106343f,
                                0.013122577f,
                                -0.022810653f,
                                -0.018403372f,
                                0.08393685f,
                                0.023346674f,
                                -0.06777682f,
                                -0.049035955f,
                                -0.03865304f,
                                -0.026126038f,
                                -0.024934882f,
                                0.029362015f,
                                0.007414951f,
                                -0.027892921f,
                                -0.057096116f,
                                -0.05189473f,
                                -0.047844797f,
                                0.053244706f,
                                0.008005566f,
                                0.053443234f,
                                -0.092433766f,
                                0.040697858f,
                                0.06313131f,
                                -0.036211167f,
                                -0.028369384f,
                                0.069484144f,
                                -0.0120703885f,
                                0.017639047f,
                                0.028845847f,
                                -0.10077187f,
                                0.071906164f,
                                0.0058714105f,
                                0.021976843f,
                                0.012149799f,
                                0.050584458f,
                                -0.053443234f,
                                0.0083678765f,
                                -0.110301115f,
                                0.054832917f,
                                -0.013192061f,
                                0.015465185f,
                                -0.071072355f,
                                -0.09076615f,
                                -0.00014602527f,
                                -0.021004064f,
                                0.053919695f,
                                0.05129915f,
                                0.033809f,
                                0.031903148f,
                                0.015187249f,
                                0.01857212f,
                                0.03160536f,
                                0.058604915f,
                                0.0035585808f,
                                -0.037124388f,
                                0.010422622f,
                                -0.07889429f,
                                0.00042217821f,
                                0.03122816f,
                                0.062178385f,
                                0.028389236f,
                                -0.0034394653f,
                                0.005613326f,
                                -0.01674568f,
                                -0.04534337f,
                                -0.017639047f,
                                -0.016765531f,
                                0.004273275f,
                                0.019961802f,
                                0.057334345f,
                                -0.0089584915f,
                                -0.07246204f,
                                0.066863604f,
                                0.03420605f,
                                -0.016835015f,
                                0.060590174f,
                                0.063488655f,
                                0.026602501f,
                                -0.017222142f,
                                0.04049933f,
                                -0.022115812f,
                                0.09743662f,
                                -0.006055047f,
                                0.02948113f,
                                0.03694571f,
                                0.016884647f,
                                -0.021837873f,
                                0.0017147694f,
                                -0.007375246f,
                                0.024299597f,
                                0.026701765f,
                                0.024656946f,
                                0.007608514f,
                                0.012020757f,
                                -0.0017581971f,
                                0.005633179f,
                                0.048360966f,
                                0.06829299f,
                                0.040280953f,
                                0.031744327f,
                                0.011623705f,
                                -0.010432548f,
                                0.017033542f,
                                -0.085366234f,
                                -0.0037595886f,
                                0.05403881f,
                                0.062019564f,
                                0.051775616f,
                                -0.0076234033f,
                                0.04657423f,
                                -0.011464884f,
                                0.01359904f,
                                0.041452255f,
                                -0.07103265f,
                                0.0017792904f,
                                0.06527539f,
                                0.020428339f,
                                0.0063577993f,
                                0.018522488f,
                                -0.024418714f,
                                0.06650625f,
                                0.0161501f,
                                0.040697858f,
                                -0.024180483f,
                                0.026602501f,
                                -0.032081824f,
                                -0.07802077f,
                                -0.025173113f,
                                -0.0053205f,
                                -0.019207403f,
                                -0.0064570624f,
                                0.020130549f,
                                -0.06102693f,
                                -0.050266817f,
                                -0.007861635f,
                                0.02050775f,
                                0.0076184403f,
                                -0.030076709f,
                                0.045899242f,
                                -0.068650335f,
                                -0.043556634f,
                                -0.014839828f,
                                0.011047979f,
                                0.023684166f,
                                0.06237691f,
                                0.013857123f,
                                0.05729464f,
                                -0.03609205f,
                                -0.017718457f,
                                0.03656851f,
                                -0.08322215f,
                                -0.09918366f,
                                -0.016517375f,
                                -0.094101384f,
                                0.040102277f,
                                -0.03986405f,
                                0.01994195f,
                                0.06019312f,
                                0.038236134f,
                                -0.03077155f,
                                0.040638298f,
                                -0.047447745f,
                                -0.04216695f,
                                -0.006933525f,
                                -0.06289308f,
                                0.010978495f,
                                -0.054157928f,
                                -0.060947523f,
                                0.006576178f,
                                0.013479924f,
                                0.069920905f,
                                0.0033228311f,
                                0.0398839f,
                                0.013013388f,
                                0.03503986f,
                                0.039228763f,
                                0.08087955f,
                                -0.014631376f,
                                -0.018165141f,
                                0.015862238f,
                                -0.069166504f,
                                0.016080616f,
                                -0.014144987f,
                                -0.081713356f,
                                -0.019951876f,
                                0.020527601f,
                                0.05904167f,
                                0.007950972f,
                                0.03464281f,
                                0.022949621f,
                                -0.0127056725f,
                                0.0759561f,
                                0.0013326067f,
                                -0.024517978f,
                                -0.016676195f,
                                0.06102693f,
                                0.11633631f,
                                0.025510607f,
                                -0.009782375f,
                                -0.05832698f,
                                -0.02743631f,
                                -0.037898637f,
                                0.049869765f,
                                -0.014819976f,
                                -0.013549408f,
                                0.053244706f,
                                0.040816974f,
                                0.031049486f,
                                0.021897431f,
                                -0.0013338474f,
                                -0.018929467f,
                                0.0028265158f,
                                -0.098866016f,
                                0.04415221f,
                                0.07242233f,
                                -0.041968424f,
                                -0.05705641f,
                                -0.03555603f,
                                -0.010521885f,
                                0.020547455f,
                                0.008551513f,
                                -0.028865699f,
                                0.029898034f,
                                0.04534337f,
                                0.0036032493f,
                                0.025709134f,
                                -0.07678991f,
                                0.06205927f,
                                0.07273997f,
                                0.068253286f,
                                0.0554682f,
                                0.10307477f,
                                0.013579187f,
                                0.010690632f,
                                -0.0018264404f,
                                -0.022552568f,
                                0.03738247f,
                                0.08520742f,
                                0.013579187f,
                                -0.029381867f,
                                -0.027595133f,
                                0.02416063f,
                                0.07377231f,
                                -0.01682509f,
                                -0.0030027076f,
                                0.14992693f,
                                0.06932533f,
                                0.015058207f,
                                0.07178705f,
                                -0.052252077f,
                                -0.0015547078f,
                                0.04036036f,
                                -0.016596785f,
                                0.003111897f,
                                -0.05006829f,
                                0.006109642f,
                                -0.080125146f,
                                0.024041515f,
                                0.039089795f,
                                -0.026781175f,
                                0.026344417f,
                                0.018879835f,
                                -0.027813511f,
                                0.008511808f,
                                0.05590496f,
                                0.03077155f,
                                0.00096843526f,
                                0.01827433f,
                                -0.0027247712f,
                                0.035158977f,
                                -0.031248013f,
                                -0.068967976f,
                                0.012120021f,
                                0.020626865f,
                                0.0108196745f,
                                -0.053125594f,
                                -0.027555427f,
                                0.06352836f,
                                0.07603551f,
                                -0.04907566f,
                                0.03914935f,
                                0.024418714f,
                                -0.06467982f,
                                -0.09719839f,
                                0.04002287f,
                                0.026602501f,
                                -0.076750204f,
                                0.0050251926f,
                                -0.042206656f,
                                0.042643413f,
                                0.03053332f,
                                -0.03746188f,
                                -0.042206656f,
                                0.01440307f,
                                -0.03797805f,
                                -0.045899242f,
                                -0.04681246f,
                                -0.0016266735f,
                                -0.08163395f,
                                0.076551676f,
                                0.06900768f,
                                0.0016105432f,
                                0.028091447f,
                                -0.04192872f,
                                0.015107838f,
                                -0.02058716f,
                                -0.05554761f,
                                0.037104532f,
                                -0.019197477f,
                                -0.0224136f,
                                -0.0022185296f,
                                0.0028091448f,
                                -0.056024075f,
                                0.004573546f,
                                -0.07516199f,
                                0.024240041f,
                                -0.038633186f,
                                0.033908263f,
                                0.016725827f,
                                -0.013708229f,
                                0.07873546f,
                                -0.010363064f,
                                0.001336329f,
                                -0.025629723f,
                                -0.024319451f,
                                -0.031744327f,
                                -0.026403975f,
                                0.01701369f,
                                -0.050743278f,
                                0.066228315f,
                                0.0063577993f,
                                -0.008913823f,
                                -0.030711992f,
                                0.06344895f,
                                0.09100438f,
                                0.03162521f,
                                0.024835618f,
                                0.062972486f,
                                -0.056778472f,
                                -0.03184359f,
                                -0.03166492f,
                                0.09846896f,
                                -0.024259893f,
                                0.023445936f,
                                -0.07889429f,
                                0.028151006f,
                                0.027178228f,
                                0.004526396f,
                                -0.011911568f,
                                -0.02437901f,
                                0.019763276f,
                                -0.024597388f,
                                0.038275838f,
                                -0.0076928874f
                                }
                    }
                }
            }
        },
    }
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
                            .Script(s => s
                                .Source(@"
                                    if (ctx._source.chunkininfo != null) {
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

    [HttpGet("fff")]
    public async Task<WeatherForecast> ABacate()
    {
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
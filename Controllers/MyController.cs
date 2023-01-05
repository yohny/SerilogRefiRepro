using Microsoft.AspNetCore.Mvc;

namespace SerilogRefiRepro.Controllers;

[ApiController]
[Route("[controller]")]
public class MyController : ControllerBase
{
    private readonly ILogger<MyController> _logger;
    private readonly IHttpClientFactory _httpClient;
    private readonly IApi _refit;

    public MyController(ILogger<MyController> logger, IHttpClientFactory httpClient, IApi refit)
    {
        _logger = logger;
        _httpClient = httpClient;
        _refit = refit;
    }

    [HttpGet("httpclient")]
    public async Task<string> GetUsingHttpclient()
    {
        var resp = await this._httpClient.CreateClient(nameof(MyController)).GetFromJsonAsync<UuidDto>("/uuid");
        return resp.Uuid.ToString();
    }

    [HttpGet("refit")]
    public async Task<string> GetUsingRefit()
    {
        var resp = await this._refit.GetUUIDAsync();
        return resp.Uuid.ToString();
    }
}

using ClimaAPI.Data;
using ClimaAPI.Models;
using ClimaAPI.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Security.Claims;

[Route("api/clima")]
[ApiController]
public class ClimaController : ControllerBase
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IClimaAPIRepositorio _climaAPIRepositorio;
    private readonly ClimaAPIDBContext _context;
    private readonly ILogger<ClimaController> _logger;   

    public ClimaController(IHttpClientFactory httpClientFactory, ClimaAPIDBContext context, ILogger<ClimaController> logger, IClimaAPIRepositorio climaAPIRepositorio)
    {
        _httpClientFactory = httpClientFactory;
        _climaAPIRepositorio = climaAPIRepositorio;
        _context = context;
        _logger = logger;
    }

    [HttpGet("{codigoIcao}")]
    public async Task<IActionResult> GetClima(string codigoIcao)
    {
        Clima? clima = null;
        try
        {
            var client = _httpClientFactory.CreateClient("BrasilAPI");
            var response = await client.GetAsync($"api/cptec/v1/clima/aeroporto/{codigoIcao}");

            if(response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro interno");
            }

            if (response.IsSuccessStatusCode)
            {
                var climaData = await response.Content.ReadAsStringAsync();

                clima = JsonConvert.DeserializeObject<Clima>(climaData);

                if (clima == null)
                    return NotFound();

                _climaAPIRepositorio.Adicionar(clima);
              
                Console.WriteLine(clima);
            }

            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                return BadRequest();

            return Ok(clima);


        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno: {ex.Message}");
        }
    }
}

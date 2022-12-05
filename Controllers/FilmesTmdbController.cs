using AutoMapper.Configuration;
using Portifolio.Models;
using Portifolio.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Portifolio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesTmdbController : Controller
    {

       
        private readonly ILogger<FilmesTmdbController> _logger;
        private readonly IOptions<MyAppSettings> _options;
        public FilmesTmdbController(IOptions<MyAppSettings> options, ILogger<FilmesTmdbController> logger)
        {
            
            _options = options;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
           
            string token = _options.Value.TokenTmdb;
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token);

            var retorno = client.GetAsync($"https://api.themoviedb.org/3/movie/upcoming?api_key=sao%20paulo&language=pt-br");

            var resultado = await retorno.Result.Content.ReadAsStringAsync();
            FilmesLancamentosTmdb.Root filmes = JsonConvert.DeserializeObject<FilmesLancamentosTmdb.Root>(resultado);

            if (retorno.Result.StatusCode.Equals(HttpStatusCode.OK))
            {
                return Ok(filmes);
            }
            return NoContent();
        }
    }
}

using FilmesAPI.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        public static List<Filme> filmes = new List<Filme>();
        
        [HttpPost]
        public void AdicionarFilme([FromBody]Filme filme)
        {
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Duracao);
            Console.WriteLine(filme.Genero);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebApplicationPruebaPersona.Model;
using WebApplicationPruebaPersona.Repository;

namespace WebApplicationPruebaPersona.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {

        PersonaRepository repo = new PersonaRepository();

        [HttpPost]
        [Route("api/[controller]/create")]
        public void CreatePersona(Persona persona)
        {
                repo.Add(persona);
        }

        [HttpGet]
        [Route("api/[controller]")]
        public List<Persona> GetPersonas()
        {
           return repo.GetAll();
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public Persona GetPersona(int id)
        {
            return repo.FindId(id);
        }

        [HttpDelete]
        [Route("api/[controller]/delete/{id}")]
        public void DeletePersona(int id)
        {            
            repo.Delete(id);
        }

    }
}
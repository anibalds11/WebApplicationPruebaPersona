using Microsoft.AspNetCore.Mvc;
using WebApplicationPruebaPersona.Model;
using WebApplicationPruebaPersona.Repository;

namespace WebApplicationPruebaPersona.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {

        private PersonaRepository personaRepository;

        public PersonaController(PersonaRepository personaRepository)
        {
            this.personaRepository = personaRepository;
        }

        [HttpPost]
        public void CreatePersona(Persona persona)
        {
            personaRepository.Add(persona);
        }

        [HttpGet]
        public List<Persona> GetPersonas()
        {
           return personaRepository.GetAll();
        }

        [HttpGet]
        [Route("/{id}")]
        public Persona GetPersona(int id)
        {
            return personaRepository.FindId(id);
        }

        [HttpDelete]
        [Route("/{id}")]
        public void DeletePersona(int id)
        {
            personaRepository.Delete(id);
        }

        [HttpPut]
        [Route("/{id}")]
        public void UpdatePersona(Persona persona)
        {
            personaRepository.Update(persona);
        }

    }
}
using WebApplicationPruebaPersona.Model;

namespace WebApplicationPruebaPersona.Repository
{
    public class PersonaRepository
    {

        private List<Persona> personas = new List<Persona>();

        public List<Persona> GetAll()
        {
            return personas;
        }

        public Persona FindId(int id)
        {
            return personas.Find(p => p.Id == id);
        }

        public void Add(Persona persona)
        {
            personas.Add(persona);
        }

        public void Delete(int id)
        {
            Persona p = FindId(id);
            personas.Remove(p);
        }

        public void Update(Persona persona)
        {
            Persona p=FindId(persona.Id);
            Delete(p);
            Add(persona);
        }
    }

}

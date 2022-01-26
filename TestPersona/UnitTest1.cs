using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using WebApplicationPruebaPersona.Controllers;
using WebApplicationPruebaPersona.Repository;

namespace TestPersona
{
    [TestClass]
    public class UnitTest1
    {
        private PersonaRepository personaRepository;

        [TestMethod]
        public void GetPerson()
        {
            var controller = new PersonaController(personaRepository);
            //controller.Request = new HttpRequestMessage();
        }
    }
}
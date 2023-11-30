using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using popper.domain.Entities;


namespace popper.teste
{
    [TestClass]
    public class UnitTestDomain
    {
 
        [TestMethod]
        public void TestLocal()
        {
            var local = new Local();
            local.Localdesc = "zzz";
         

            Console.WriteLine(JsonSerializer.Serialize(local));
            Assert.AreEqual(local.Localdesc, "zzz");


        }
        [TestMethod]
        public void TesteTecnico()
        {
            var tecnico = new Tecnico();
            tecnico.Endereco = "ccc";
            tecnico.Nome = "joao";

            Console.WriteLine(JsonSerializer.Serialize(tecnico));
            Assert.AreEqual(tecnico.Nome, "joao");
            Assert.AreEqual(tecnico.Endereco, "ccc");

        }
        [TestMethod]
        public void TesteUsuario()
        {
            var usuario = new Usuario();

            usuario.Nome = "rick";

            usuario.Endereco = "qqq";

       
            Console.WriteLine(JsonSerializer.Serialize(usuario));
            Assert.AreEqual(usuario.Nome, "rick");
            Assert.AreEqual(usuario.Endereco, "qqq");


        }
        [TestMethod]
        public void TestChamado()
        {
            var chamado = new Chamado();

            chamado.Desc = "aaa";
            chamado.Hora = DateTime.Now;
            chamado.Status = "bbb";


            Console.WriteLine(JsonSerializer.Serialize(chamado));
            Assert.AreEqual(chamado.Desc, "aaa");
            Assert.AreEqual(chamado.Hora, DateTime.Now);
            Assert.AreEqual(chamado.Status, "bbb");

        }

        [TestMethod]
        public void TesteTipoChamado()
        {
            var tipoChamado = new TipoChamado();


        }

    }
}
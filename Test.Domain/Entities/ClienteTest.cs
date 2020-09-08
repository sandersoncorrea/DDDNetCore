using ProjectDDD.Domain.Entities;
using System;
using Xunit;

namespace Test.Domain.Entities
{
    public class ClienteTeste
    {
        [Fact]
        public void Cliente_deve_ser_valido()
        {
            var hoje = DateTime.Now;
            Cliente cliente = new Cliente()
            {
                Nome = "Cliente 1",
                Email = "cliente1@gmail.com",
                Cadastro = hoje,
                Codigo = 0
            };

            Assert.True(cliente != null && cliente.Nome == "Cliente 1" && cliente.Cadastro == hoje);
        }
    }
}

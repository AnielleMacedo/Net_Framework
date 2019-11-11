using ExemploWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebAPI.Controllers
{
    public class ClientesController : ApiController //ja herda da classe ApiController classe padrao do api
    {
        //crio 1 lista com nome clients
        private static List<Cliente> clientes = new List<Cliente>();

        //crio um metodo que me mostre quais clientes tenho cadastrados na lista
        //[HttpGet] se quisesse da um outro nome ao metodo
        public List<Cliente> Get()
        {
            return clientes;
        }

        //crio un metodo pra inserir nomes na lista, geralmente insercao faz com Post
        public void Post(string nome)
        {
            if(!string.IsNullOrEmpty(nome)) //so add se n for null nem vazio
            clientes.Add(new Cliente(nome));
        }

        //metodo que delete um nome por vez
        public void Delete(string nome)
        {
            //remove o primeiro nome da lista desde q tenha o mesmo Nome(prop. classe Cliente) passado no parametro nome
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploWebAPI.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        //crio um construtor pra poder instanciar mais facilmente
        public Cliente(string texto)
        {
            this.Nome = texto;

        }
    }
}
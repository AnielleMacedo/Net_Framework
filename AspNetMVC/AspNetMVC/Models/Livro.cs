using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models
{
    public class Livro
    {
        //em cima de cada prop posso fazer validacao com dataAnotation, required è obrigatoria
        [Required(ErrorMessage ="O codigo è obrigatorio")]
        public int ID { get; set; }
        [Required(ErrorMessage = "O titulo è obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O autor è obrigatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "O ano è obrigatorio")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage = "O ano deve ter ao menos 4 numeros!")]
        public int AnoPublicacao { get; set; }



        //crio 1 metodo get que vai retornar uma lista do tipo Livro
        public List<Livro> GetLivros()
        {
            return new List<Livro>
            {
                new Livro
                {
                    ID= 1,
                    Titulo = "Miracle Morning",
                    Autor = "Eric Evans",
                    AnoPublicacao= 2003
                },

                new Livro
                {
                    ID= 2,
                    Titulo = "Agile Principles",
                    Autor = "Robert Martin",
                    AnoPublicacao= 2006
                },
                new Livro
                {
                    ID= 3,
                    Titulo = "Clean Code",
                    Autor = "Robert Martin",
                    AnoPublicacao= 2008
                }

            };
        }





    }
}
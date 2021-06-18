using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAspNetCore.Models
{
    public class Livro
    {
        public Livro(string codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}

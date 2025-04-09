using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV2
{
    public class Livro : Midia
    {
        public string Genero { get; private set; }

        public Livro(string titulo, string autor, int anoPublicacao, string genero)
            : base(titulo, autor, anoPublicacao)
        {
            Genero = genero;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Gênero: {Genero}");
        }
    }
}

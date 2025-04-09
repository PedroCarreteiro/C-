using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV2
{
    public class Revista : Midia
    {
        public int Edicao { get; private set; }

        public Revista(string titulo, string autor, int anoPublicacao, int edicao)
            : base(titulo, autor, anoPublicacao)
        {
            Edicao = edicao;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Edição: {Edicao}");
        }
    }
}

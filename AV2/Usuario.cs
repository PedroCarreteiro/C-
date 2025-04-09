using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV2
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        // Torna a lista pública para permitir acesso de outras classes
        public List<Midia> MidiasEmprestadas { get; set; }

        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
            MidiasEmprestadas = new List<Midia>(); // Inicializa a lista de mídias emprestadas
        }

        // Método para emprestar uma mídia ao usuário
        public void EmprestarMidia(Midia midia)
        {
            MidiasEmprestadas.Add(midia); // Adiciona a mídia à lista
        }
    }
}

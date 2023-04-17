using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ModuloAmigo
{
    internal class Amigo
    {
        public string Nome;
        public string NomeDoResponsavel;
        public string Telefone;
        public string Endereco;

        public Amigo(int id, string nome, string nomeDoResponsável, string telefone, string endereço)
        {
            Id = id;
            Nome = nome;
            NomeDoResponsavel = nomeDoResponsável;
            Telefone = telefone;
            Endereco = endereço;
        }
    }
}

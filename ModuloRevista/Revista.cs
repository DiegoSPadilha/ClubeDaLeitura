using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ModuloRevista
{
    internal class Revista
    {
        public string Nome { get; set; }
        public decimal Ano { get; set; }
        public string DataEdicao { get; set; }
        public string Localizacao { get; set; }

        public Revista(string nome, decimal ano, string dataEdicao, string localizacao)
        {
            Nome = nome;
            Ano = ano;
            DataEdicao = dataEdicao;
            Localizacao = localizacao;
        }

        public void ImprimirDetalhes()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Data da edição: " + DataEdicao);
            Console.WriteLine("Localização: " + Localizacao);
        }


    }
}

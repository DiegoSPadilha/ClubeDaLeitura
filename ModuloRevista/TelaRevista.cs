using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ModuloRevista
{
    internal class TelaRevista
    {
        RepositorioRevista repositorio = new RepositorioRevista();

        Revista revista1 = new Revista("Revista de Tecnologia", 2022, "Janeiro 2022", "Caixa 1");
        Revista revista2 = new Revista("Revista de Ciências", 2021, "Outubro 2021", "Caixa 2");
        Revista revista3 = new Revista("Revista de Negócios", 2023, "Março 2023", "Caixa 3");

        repositorio.Adicionar(revista1);
        repositorio.Adicionar(revista2);
        repositorio.Adicionar(revista3);

        List<Revista> revistas = repositorio.ObterTodos();

        foreach (var revista in revistas)

        {
            revista.ImprimirDetalhes();
            Console.WriteLine();
        }

        Console.ReadKey();

        switch (opcao)
        {
                case "1": InserirNovaRevista(); break;
                case "2": EditarRevista(); break;
                case "3": DeletarRevista(); break;
                case "4": ListarRevista(); break;

                case "S": Menu.VoltarAoMenu(); break;
        }



}
}

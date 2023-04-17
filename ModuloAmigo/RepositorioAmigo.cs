using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ModuloAmigo
{
    internal class RepositorioAmigo
    {
        public List<Amigo> Amigos = new List<Amigo>();



        public void CadastrarAmigo(Amigo amigo)
        {
            Amigos.Add(amigo);
        }

        public void Criar(Amigo amigo)
        {
            CadastrarAmigo(amigo);
            ContadorId++;
        }
        public void Editar(int idEditar, Amigo amigoAtualizado)
        {
            Amigo amigo = SelecionarAmigoPorId(idEditar);

            amigo.Nome = amigoAtualizado.Nome;
            amigo.NomeDoResponsavel = amigoAtualizado.NomeDoResponsavel;
            amigo.Telefone = amigoAtualizado.Telefone;
            amigo.Endereco = amigoAtualizado.Endereco;
        }
        public void Deletar(int id)
        {
            Amigo amigo = SelecionarAmigoPorId(id);
            Amigos.Remove(amigo);
        }
        public List<Amigo> SelecionarTodos()
        {
            return Amigos;
        }
        public Amigo SelecionarAmigoPorId(int id)
        {
            Amigo amigo = null;

            foreach (Amigo a in Amigos)
            {
                if (a.Id == id)
                {
                    amigo = a;
                    break;
                }
            }

            return amigo;
        }
    }
}

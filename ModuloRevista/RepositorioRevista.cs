using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ModuloRevista
{
    internal class RepositorioRevista
    {
        private List<Revista> _revistas;

        public RepositorioRevista()
        {
            _revistas = new List<Revista>();
        }

        public void Adicionar(Revista revista)
        {
            _revistas.Add(revista);
        }

        public List<Revista> ObterTodos()
        {
            return _revistas;
        }
    }

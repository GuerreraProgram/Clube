using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube
{
    internal class Categoria
    {
        private string cod_categoria;
        private string nom_categoria;
        private List<Socio> socios = new List<Socio>();

        public string Cod_categoria { get => cod_categoria; set => cod_categoria = value; }
        public string Nom_categoria { get => nom_categoria; set => nom_categoria = value; }
        
        public void adicionar_socio(Socio socio)
        {
            this.socios.Add(socio);
        }
    }
}

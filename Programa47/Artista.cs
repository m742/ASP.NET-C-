using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Programa47
{
    class Artista : IComparable
    {

        public int codigo { get; set; }
        public string nome { get; set; }
        public double cache { get; set; }

        public Artista(int codigo, string nome, double cache)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cache = cache;
        }

        public override string ToString()
        {
            return codigo + " ," + nome + "," + cache + " ,";
        }

        public int CompareTo(object obj)
        {
            Artista outro = (Artista)obj;
            return nome.CompareTo(outro.nome);
        }
    }
}

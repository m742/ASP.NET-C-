using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Programa47
{
    class Participacao
    {


        public double desconto { get; set; }
        Filme filme { get; set; }
        Artista artista { get; set; }

        public Participacao(double desconto, Filme filme, Artista artista)
        {
            this.desconto = desconto;
            this.filme = filme;
            this.artista = artista;
        }

        public double custo()
        {
            double saldo = artista.cache - desconto;
            return saldo;
        }

        public override string ToString()
        {
            return artista.nome
                + ", Cachê: "
                + artista.cache
                + ", Desconto: "
                + desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + custo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Programa47
{
    class Filme
    {

        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public List<Participacao> participacoes;

        public Filme(int codigo, string titulo, int ano)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            participacoes = new List<Participacao>();
        }

        public double custoTotal()
        {
            double saldo = 0;
            for (int i=0; i<participacoes.Count; i++) { 
            saldo = saldo + participacoes[i].custo();
            }
            return saldo;
        }

        public override string ToString()
        {
            String s = "Filme " + codigo
                + ", Título: " + titulo
                + ", Ano: " + ano + "\n"
                + "Participações:\n";
            for (int i = 0; i < participacoes.Count; i++)
            {
                s = s + participacoes[i] + "\n";
            }
            s = s + "Custo total do filme: " + custoTotal().ToString("F2", CultureInfo.InvariantCulture);
            return s;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Programa47
{
    class Program
    {

        public static List<Artista> artistas = new List<Artista>();
        public static List<Filme> filme = new List<Filme>();

        static void Main(string[] args)
        {


            artistas.Add(new Artista(1000, "Scarlet Johnson", 4000.00));
            artistas.Add(new Artista(1001, "Chris Evans", 6000.00));
            artistas.Add(new Artista(1002, "Robert Downey Junior", 8000.00));
            artistas.Add(new Artista(1003, "Mogan Freeman", 10000.00));
            artistas.Add(new Artista(1004, "Jim Carrey", 20000.00));
            artistas.Sort();



            int op = 1;

            while (op != 0)
            {

                Tela.telaMenu();
                int num = int.Parse(Console.ReadLine());

                switch (num)
                {

                    case 1:
                        Tela.mostrarArtistas();
                        break;

                    case 2:
                        Tela.cadastrarArtistas();
                        break;

                    case 3:
                        Tela.cadastrarParticipacoes();
                        break;

                    case 4:
                        Tela.mostrarFilme();
                        break;

                    case 5:
                        op = 0;
                        break;

                }





            }




        }



    }
}


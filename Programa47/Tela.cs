using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa47
{
    class Tela
    {

        public static void mostrarArtistas()
        {
            for (int i = 0; i < Program.artistas.Count; i++)
            {
                Console.WriteLine(Program.artistas[i]);
            }
        }


        public static void telaMenu()
        {
            Console.WriteLine("Seleciona a opção desejada");
            Console.WriteLine("1 - Listagem de Artistas Ordenadamente");
            Console.WriteLine("2 - Cadastrar Artista");
            Console.WriteLine("3 - Cadastrar Participações ");
            Console.WriteLine("4 - Mostrar Dados de um filme");
            Console.WriteLine("5 - Sair");
        }


        public static void cadastrarArtistas()
        {
            Console.WriteLine("Digite os dados do artista");
            Console.WriteLine("Codigo");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome do Artista");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o cache do artista");
            double cache = double.Parse(Console.ReadLine());
            Artista a = new Artista(cod, nome, cache);
            Program.artistas.Add(a);


        }

        public static void cadastrarParticipacoes()
        {
            Console.WriteLine("Digite os dados do filme");
            Console.WriteLine("Codigo");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Titulo");
            string filme = Console.ReadLine();
            Console.WriteLine("Ano");
            int ano = int.Parse(Console.ReadLine());
            Filme f = new Filme(cod, filme, ano);
            Console.WriteLine("Digite quantas participações o filme teve");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite os dados da " + i + "participação");
                Console.WriteLine("Digite o codigo do artista");
                int cod1 = int.Parse(Console.ReadLine());

                int pos = Program.artistas.FindIndex(x => x.codigo == cod1);
                if (pos == -1)
                {
                    throw new Exception("Codigo de produto não encontrado" + cod1);
                }

                Console.WriteLine("Digite o desconto");
                double desc = double.Parse(Console.ReadLine());
                Participacao ip = new Participacao(desc, f, Program.artistas[pos]);
                f.participacoes.Add(ip);
            }
            Program.filme.Add(f);
         
        }


        public static void mostrarFilme()
        {
            Console.WriteLine("Digite o codigo do filme que você deseja saber as informações");
            int cod = int.Parse(Console.ReadLine());

            int pos = Program.filme.FindIndex(x => x.codigo == cod);
            if (pos == -1)
            {
                throw new Exception("Codigo de produto não encontrado" + cod);
            }

            Console.WriteLine(Program.filme[pos]);
            Console.WriteLine();


        }
       
    }
}

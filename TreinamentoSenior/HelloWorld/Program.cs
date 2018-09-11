using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string data = DateTime.Now.ToString();

            string nome = "Vinicius";
            string sobrenome = "Carvalho";
            string endereço = "Rua F, N 1";
            StringBuilder imprimir = new StringBuilder();
            imprimir.Append($"O {nome}");
            imprimir.AppendFormat(" de sobrenome {0}", sobrenome);
            imprimir.Append($" de sobrenome {sobrenome}");
            imprimir.Append($" que vive em {endereço}");
            imprimir.Append($" está trabalhando na");
            imprimir.Append($" UNA.");

            Console.WriteLine(imprimir);

            string dataAgain = DateTime.Now.ToString();
            */

            /*
            int[] simples = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < simples.Length; i++)
            {
                Console.WriteLine($"{simples[i]} ");
            }

            Console.WriteLine("\n");

            foreach (var item in simples)
            {
                Console.WriteLine($"{item} ");
            }
            */

            /*
            int[] testee = { 1, 2, 3, 4 };
            int numeroo = testee[2];



            const int indice = 4;

            string[] simples = new string[indice] { "B", "D", "F", "H" };

            for (int i = 0; i < simples.Length; i++)
            {
                int valor = 0;

                if (int.TryParse(string simples, out Int32 result))
            }


            */


            /* NewMethod(); */


            /*
            try
            {
                int numero = 35;
                if (true)
                    throw new DivideByZeroException();
                else
                    throw new Exception();

             
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Ex");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */


            /*
            try
            {
                int numero = 35;
                if (true)
                    throw new DivideByZeroException();
                else
                    throw new Exception();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Opa: " + ex.Message);
            }
            */


            /*
            Dias dias = Dias.Segunda;

            switch (dias)
            {
                case Dias.Domingo: Console.WriteLine("Domingo."); break;
                case Dias.Segunda: Console.WriteLine(Dias.Segunda); break;
                case Dias.Terça: Console.WriteLine("Terça."); break;
            }
            */





            Moeda moeda;
            moeda.codigo = "R";
            moeda.simbolo = "$";
            moeda.valor = 10.000;
            moeda.Formatar();


            Console.ReadKey();


        }

        private static void NewMethod()
        {
            int[] simples = { 1, 2, 3 };

            imprimir("", simples);


            Console.WriteLine("Teste");
            Console.ReadKey();
        }

        static void imprimir(int[] numeros)
        {

        }

        static void imprimir(string nome, int[] numeros)
        {

        }
        static void ler()
        {
            string arquivo = @"C:\Users\318130076\Desktop\Treinamento\Arquivo.txt";

            byte[] dados = File.ReadAllBytes(arquivo);
            string[] linhas = File.ReadAllLines(arquivo);
            string completo = File.ReadAllText(arquivo);

            Console.WriteLine(completo);
        }
        static void lendo()
        {
            string diretorio = @"C:\Users\318130076\Desktop\Treinamento\06-09\bootstrap";

            FileStream stream = new FileStream(diretorio, FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);
            int posicao = 0;
            int tamanho = (int)reader.BaseStream.Length;
            byte[] dados = new byte[tamanho];
            int leitura;

            while ((leitura = reader.Read()) != 1)
            {
                dados[posicao] = (byte)leitura;
                posicao += sizeof(byte);
            }

            reader.Close();
            stream.Close();
        }

        static void escrevendo()
        {

        }
        enum Dias
        {
            Domingo = 1, Segunda = 2567, Terça = 3
        }

        struct Moeda
        {
            public string codigo;
            public string simbolo;
            public double valor;

            public void Formatar()
            {
                Console.WriteLine("{0}{1} {2}", codigo, simbolo, valor.ToString("#00.00"));
            }
        }
    }
}
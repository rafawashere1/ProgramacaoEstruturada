namespace ProgramacaoEstruturada
{
    internal class Program
    {
        static int[] valores = new int[10];
        static int[] valores2 = new int[10];
        static int[] maioresValores = new int[3];
        static int[] valoresNegativos = new int[100];
        static int maior = -1000;
        static int menor = 1000;
        static double medio = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Programação Estruturada ---------\n");

            ObterNumeroEProcessamentos();

            MostrarSequencia();

            MostrarValorMaiorMenorMedio();

            MostrarValoresNegativos();

            MostrarTresMaioresValores();

            int indexNumero = RemoverNumeroDaSequencia();

            SequenciaComNumeroRemovido(indexNumero);

            Console.ReadKey();
        }
        static void ObterNumeroEProcessamentos()
        {
            Console.WriteLine(">> Digite 10 números inteiros:\n");

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($">> Número {i + 1}: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());

                ObterMenorValor(i);

                ObterMaiorValor(i);

                medio += valores[i];
            }

            Array.Copy(valores, valores2, 10);

            medio = medio / valores.Length;

            Console.WriteLine("\n");
        }
        static void MostrarSequencia()
        {
            for (int i = 0; i < valores.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(">> A sequência é: ");
                }

                Console.Write($"{valores[i]} ");
            }
        }
        static void MostrarValorMaiorMenorMedio()
        {
            Console.WriteLine($"\n\n>> O maior valor da sequência é: {maior}\n");
            Console.WriteLine($">> O menor valor da sequência é: {menor}\n");
            Console.WriteLine($">> O valor médio da sequência é: {medio}\n");
        }
        static void MostrarValoresNegativos()
        {
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] < 0)
                {
                    valoresNegativos[i] = valores[i];
                }

                if (i == 0)
                {
                    Console.Write(">> Os valores negativos da sequência são: ");
                }

                if (valoresNegativos[i] != 0 && valoresNegativos != null)
                {
                    Console.Write($"{valoresNegativos[i]} ");
                }
            }

            Console.WriteLine("\n");
        }
        static void MostrarTresMaioresValores()
        {
            for (int i = 0; i < 3; i++)
            {
                Array.Sort(valores);
                Array.Reverse(valores);

                maioresValores[i] = valores[i];

                if (i == 0)
                {
                    Console.Write(">> Os três maiores valores da sequência são: ");
                }

                Console.Write($"{maioresValores[i]} ");
            }
        }
        static int RemoverNumeroDaSequencia()
        {
            Console.Write("\n\n>> Digite um número para remover: ");
            int numeroParaRemover = Convert.ToInt32(Console.ReadLine());

            int indexNumero = Array.IndexOf(valores2, numeroParaRemover);

            while (indexNumero == -1)
            {
                Mensagem("\n>> Número não encontrado, digite outro: ", "ERRO");
                numeroParaRemover = Convert.ToInt32(Console.ReadLine());
                indexNumero = Array.IndexOf(valores2, numeroParaRemover);
            }

            return indexNumero;
        }
        static void SequenciaComNumeroRemovido(int indexNumero)
        {
            Console.Write("\n>> A nova sequência é: ");

            for (int i = 0; i < valores2.Length; i++)
            {
                if (i != indexNumero)
                {
                    Console.Write($"{valores2[i]} ");
                }
            }
        }
        static void ObterMaiorValor(int i)
        {
            if (valores[i] > maior)
                maior = valores[i];
        }
        static void ObterMenorValor(int i)
        {
            if (valores[i] < menor)
                menor = valores[i];
        }
        static void Mensagem(string mensagem, string tipoDeMensagem)
        {
            if (tipoDeMensagem == "ERRO")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(mensagem);
                Console.ResetColor();
            }
        }
    }
}
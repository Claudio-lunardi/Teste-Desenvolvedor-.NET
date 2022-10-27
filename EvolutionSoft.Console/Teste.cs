using System.Text.RegularExpressions;

namespace EvolutionSoft.Console
{
    public class Teste
    {
        public void TesteEvolutionSoft()
        {
            string XouC = "";
            do
            {
                System.Console.WriteLine("\nDigite [X] para teste 2.1 ou [C] para teste 2.2");
                XouC = System.Console.ReadLine().ToUpper().Trim();

                if (XouC == "X")
                {
                    int valor, a = 0;
                    do
                    {
                        System.Console.WriteLine("Digite um número maior que 0");
                        valor = int.Parse(System.Console.ReadLine());

                    } while (valor < 1);

                    for (int i = 1; i <= valor; i++)
                    {
                        a = a + i;
                    }
                    System.Console.WriteLine("A Soma de 1 até " + valor + " é " + a);
                }
                else if (XouC == "C")
                {
                    string[] valor = { "abracadabra", " allottee", " assessee", " kelless", " keenness", " Alfalggo" };


                    System.Console.Write("Resultado: ");
                    for (int i = 0; i < 6; i++)
                    {
                        RemoverCaracteresDuplicados(valor[i]);
                    }

                    void RemoverCaracteresDuplicados(string texto)
                    {
                        string pattern = @"(.)(?=\1)";
                        string substitution = @"";
                        RegexOptions options = RegexOptions.Multiline;

                        Regex regex = new Regex(pattern, options);
                        string result = regex.Replace(texto, substitution);

                        System.Console.Write(result);
                    }
                }
                else
                {
                    System.Console.WriteLine("Tecla inválida, digite novamente uma tecla válida");
                }

            } while (XouC != "X" || XouC != "C");
        }
    }
}

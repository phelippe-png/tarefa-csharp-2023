using System.Globalization;

namespace Tarefa.ImprimirConsoantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma palavra: ");
            var strPalavra = Console.ReadLine();

            Console.WriteLine("Consoantes da palavra " + strPalavra + ": " + ExibirConsoantes(strPalavra));
        }

        static private string ExibirConsoantes(string strPalavra)
        {
            List<char> listVogais = new List<char> {'a', 'e', 'i', 'o', 'u'};
            var strResultado = string.Empty;

            for (int i = 0; i < strPalavra.Length; i++)
                if (!listVogais.Contains(char.ToLower(strPalavra[i])) && !char.IsNumber(strPalavra[i]))
                    strResultado += strPalavra[i];

            return strResultado;
        }
    }
}
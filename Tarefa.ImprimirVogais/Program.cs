namespace Tarefa.ImprimirVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strPalavra = string.Empty;

            Console.WriteLine("Informe uma palavra: ");
            strPalavra = Console.ReadLine();

            Console.WriteLine("Vogais da palavra " + strPalavra + ": " + ExibirVogais(strPalavra));
        }

        static private string ExibirVogais(string strPalavra)
        {
            List<char> listVogais = new List<char> {'a', 'e', 'i', 'o', 'u'};
            string strResultado = string.Empty;

            for (int i = 0; i < strPalavra.Length; i++)
                if (listVogais.Contains(char.ToLower(strPalavra[i])) && !char.IsNumber(strPalavra[i]))
                    strResultado += strPalavra[i];

            return strResultado;
        }
    }
}
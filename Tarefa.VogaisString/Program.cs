namespace Tarefa.VogaisString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma palavra: ");
            var strPalavra = Console.ReadLine();

            Console.WriteLine("Quantidade de vogais: " + ContarVogais(strPalavra).ToString());
        }

        static private int ContarVogais(string strPalavra)
        {
            const string strVogais = "aeiou";
            return strPalavra.Count(chr => strVogais.Contains(char.ToLower(chr)));
        }
    }
}
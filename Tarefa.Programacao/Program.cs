namespace Tarefa.Programacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultado = 0;

            try
            {
                Console.WriteLine("Informe o primeiro número: ");
                decimal n1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe o segundo número: ");
                decimal n2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("(1) - Adição.");
                Console.WriteLine("(2) - Subtração.");
                Console.WriteLine("(3) - Multiplicação.");
                Console.WriteLine("(4) - Divisão.");
                Console.WriteLine("Selecione uma opção: ");
                var opcao = Console.ReadLine();

                if (int.TryParse(opcao, out int numero))
                {
                    switch (numero)
                    {
                        case 1:
                            resultado = n1 + n2;
                            break;
                        case 2:
                            resultado = n1 - n2;
                            break;
                        case 3:
                            resultado = n1 * n2;
                            break;
                        case 4:
                            resultado = n1 / n2;
                            var restoDivisao = n1 % n2;
                            Console.WriteLine("O resto da divisão é: " + restoDivisao.ToString());
                            break;
                    }

                    Console.WriteLine("O cálculo entre os dois números é: " + resultado.ToString());
                }
                else
                {
                    Console.WriteLine("Informe um número!");
                }
            } catch(Exception ex)
            {
                Console.WriteLine("Erro! Informe um número!");
            }
        }
    }
}
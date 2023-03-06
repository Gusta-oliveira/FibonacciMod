internal class Program
{
    private static void Main(string[] args)
    {
        int digit_u;
        double ant = 1, prox = 0;

        Console.WriteLine("Informe o número para o cálculo ");
        digit_u = int.Parse(Console.ReadLine());
        Console.Write($"A sequencia fibonacci de {digit_u} é: ");
        for (int i = 0; i < digit_u; i++)
        {
            Console.Write(ant + " | ");
            ant = prox + ant;
            prox = ant - prox;

        }
    }
}
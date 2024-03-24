using System;

namespace convertendo_segundos_horas_minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos, resto, h, m, s;
            Console.WriteLine("Informe a quantidade de segundos:");
            segundos = Convert.ToInt32(Console.ReadLine());
            h = segundos / 3600;
            resto = segundos % 3600;
            m = resto / 60;
            s = resto % 60;
            Console.WriteLine("São {0} Horas, {1} minutos e {2} segundos.", h, m, s);
    }
}
}
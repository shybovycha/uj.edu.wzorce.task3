using System;
using System.Collections.Generic;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            String l1 = "", l2 = "";
            int liczbaWagonow = 0;

            InputParser parser = new InputParser();
            PociagBuilder builder = new PociagBuilder();
            IPociag pociag;

            Console.WriteLine("Teraz będziemy budować pociąg!");

            Console.WriteLine("Wprowadż jaką pociąg będzie miał lokomotywę (Osiową) [Elektryczną|Spalinową]:");
            l1 = Console.ReadLine();

            Console.WriteLine("Wprowadż długość lokomotywy:");
            l2 = Console.ReadLine();

            builder.addLokomotywe(parser.createLokomotywa(l1, l2));

            Console.WriteLine("Wprowadż ile pociąg będzie miał wagonów:");
            l1 = Console.ReadLine();
            liczbaWagonow = Int32.Parse(l1);

            for (int i = 1; i <= liczbaWagonow; i++) {
                Console.WriteLine(String.Format("#{0} / {1}. Wprowadż jaki to będzie wagon (Osiowy) [Towarowy|osoBowy]:", i, liczbaWagonow));
                l1 = Console.ReadLine();

                Console.WriteLine("Wprowadż długość lokomotywy:");
                l2 = Console.ReadLine();

                builder.addWagon(parser.createWagon(l1, l2));
            }

            pociag = builder.build();

            pociag.prezentujSie();
        }
    }
}

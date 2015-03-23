using System;
using System.Collections.Generic;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            String l1 = "";
            int liczbaWagonow = 0;

            InputParser parser = new InputParser();
            PociagBuilder builder = new PociagBuilder();
            IPociag pociag;

            Console.WriteLine("Teraz będziemy budować pociąg!");

            Console.Write("Wprowadż jaką pociąg będzie miał lokomotywę (Osiową) [Elektryczną|Spalinową]:");
            l1 = Console.ReadLine();

            ILokomotywa lokomotywa = parser.createLokomotywa(l1);
            builder.addLokomotywe(lokomotywa);

            Console.Write("Wprowadż ile pociąg będzie miał wagonów:");
            l1 = Console.ReadLine();
            liczbaWagonow = Int32.Parse(l1);

            for (int i = 1; i <= liczbaWagonow; i++) {
                Console.Write(String.Format("#{0} / {1}. Wprowadż jaki to będzie wagon [Towarowy|osoBowy]:", i, liczbaWagonow));
                l1 = Console.ReadLine();

                IWagon wagon = parser.createWagon(l1);
                builder.addWagon(wagon);
            }

            pociag = builder.build();

            Console.WriteLine(pociag.prezentujSie());
        }
    }
}

namespace Module2_HW6_09062023
{
    using System;
    using Module2_HW6_09062023.Interfaces;

    public static class UI
    {
        private const string Board = "=========================";

        public static void PrintAppliance(
            IPrintable[] appliance,
            string text,
            ConsoleColor consoleColor)
        {
            Console.WriteLine(Board);
            ChangeColor(text, consoleColor);
            Console.WriteLine();

            for (int i = 0; i < appliance.Length; i++)
            {
                Console.Write($"{appliance[i].ToString().Split(':')[0]}");
                Console.Write($"{appliance[i].ToString().Split(':')[1]}");
                Console.Write($"{appliance[i].ToString().Split(':')[2]}");

                if (((IIsturnedOn)appliance[i]).GetIsTurnedOn())
                {
                    ChangeColor(
                        $"{appliance[i].ToString().Split(':')[3]}",
                        ConsoleColor.Green);
                }
                else
                {
                    ChangeColor(
                        $"{appliance[i].ToString().Split(':')[3]}",
                        ConsoleColor.Red);
                }

                Console.WriteLine();
            }

            Console.WriteLine(Board);
        }

        public static void PrintTurnedOnAppliance(IPrintable[] appliance)
        {
            Console.WriteLine(Board);
            ChangeColor("Turned On", ConsoleColor.Yellow);
            Console.WriteLine();

            ushort tmpCounter = 0;

            for (int i = 0; i < appliance.Length; i++)
            {
                if (((IIsturnedOn)appliance[i]).GetIsTurnedOn())
                {
                    Console.Write($"{appliance[i].ToString().Split(':')[0]}");
                    Console.Write($"{appliance[i].ToString().Split(':')[1]}");
                    Console.Write($"{appliance[i].ToString().Split(':')[2]}");
                    ChangeColor(
                        $"{appliance[i].ToString().Split(':')[3]}",
                        ConsoleColor.Green);
                    Console.WriteLine();
                    ++tmpCounter;
                }
            }

            if (tmpCounter == 0)
            {
                ChangeColor("No turned on appliance\n", ConsoleColor.Red);
            }

            Console.WriteLine(Board);
        }

        public static void PrintTotalElectConsumption(int total)
        {
            Console.WriteLine(Board);
            Console.Write("\nTotal electricity consumption:\t");
            ChangeColor(total.ToString(), ConsoleColor.Cyan);
            Console.WriteLine();
            Console.WriteLine(Board);
        }

        private static void ChangeColor(string str, ConsoleColor color)
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ForegroundColor = def;
        }
    }
}

namespace Module2_HW6_09062023
{
    using System;
    using System.Threading;
    using Module2_HW6_09062023.Enums;
    using Module2_HW6_09062023.Extentions;
    using Module2_HW6_09062023.Interfaces;

    public static class Starter
    {
        public static void Run()
        {
            Home home = new Home();
            home.CreateHomeAppliance();

            IPrintable[] printables =
                (IPrintable[])home.Appliances.Clone();

            // печать всей техники (не сортированной)
            UI.PrintAppliance(
                printables,
                "All appliance",
                ConsoleColor.Yellow);

            Array.Sort(printables);

            // печать СОРТИРОВАННОЙ техники
            UI.PrintAppliance(
                printables,
                "Sorted appliance by name",
                ConsoleColor.Cyan);

            UI.PrintTurnedOnAppliance(printables);

            IEnergyConsuming[] appliance =
                (IEnergyConsuming[])home.Appliances.Clone();

            // подсчет расхода єлектроєнергии
            int energyConsuming = home.CalculateEnergyConsuming(appliance);

            UI.PrintTotalElectConsumption(energyConsuming);

            // поиск техники по производителю
            IPrintable[] findedApplience = Extend.FindApplience(
                home.Appliances,
                Manufacturers.Bosch);

            UI.PrintAppliance(
                findedApplience,
                "Finded appliance",
                ConsoleColor.Magenta);
        }
    }
}

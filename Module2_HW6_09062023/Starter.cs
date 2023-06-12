namespace Module2_HW6_09062023
{
    using System;
    using System.Threading;
    using Module2_HW6_09062023.Enums;
    using Module2_HW6_09062023.Interfaces;

    public static class Starter
    {
        public static void Run()
        {
            const int ApplianceCount = 10;

            Appliance[] appliances = new Appliance[ApplianceCount];

            CreateHomeAppliance(appliances);

            IPrintable[] printables =
                (IPrintable[])appliances.Clone();

            UI.PrintAllAppliance(printables);

            UI.PrintTurnedOnAppliance(printables);

            IEnergyConsuming[] appliance =
                (IEnergyConsuming[])appliances.Clone();

            // подсчет расхода єлектроєнергии
            int energyConsuming = CalculateEnergyConsuming(appliance);

        }

        private static int CalculateEnergyConsuming(
            IEnergyConsuming[] appliance)
        {
            int energyConsuming = 0;

            for (int i = 0; i < appliance.Length; i++)
            {
                energyConsuming += appliance[i].GetEnergyConsuming();
            }

            return energyConsuming;
        }

        /// <summary>
        /// Заполнение масиива с техникой.
        /// </summary>
        /// <param name="appliances">
        /// Массив для заполнения.
        /// </param>
        /// <returns>
        /// Массив с заполненой техникой.
        /// </returns>
        private static Appliance[] CreateHomeAppliance(Appliance[] appliances)
        {
            Random random = new Random();

            int countApplTypes = Enum.GetValues(typeof(ApplianceList)).Length;
            for (int i = 0; i < appliances.Length; i++)
            {
                int rndAppl = random.Next(1, countApplTypes);

                Thread.Sleep(300);
                switch ((ApplianceList)rndAppl)
                {
                    case ApplianceList.Refrig:

                        appliances[i] = new Refrig(
                            PropRand.GetCoolingSystem(),
                            PropRand.GetTypeMountAppliance(),
                            PropRand.GetColor(),
                            PropRand.GetManufacturers(),
                            PropRand.GetIsTurnedOn());

                        break;

                    case ApplianceList.Oven:

                        appliances[i] = new Oven(
                           PropRand.GetControlType(),
                           PropRand.GetTypeMountAppliance(),
                           PropRand.GetColor(),
                           PropRand.GetManufacturers(),
                           PropRand.GetIsTurnedOn());

                        break;

                    case ApplianceList.Mixer:

                        appliances[i] = new Mixer(
                          PropRand.GetMixerType(),
                          PropRand.GetHousingMaterial(),
                          PropRand.GetColor(),
                          PropRand.GetManufacturers(),
                          PropRand.GetIsTurnedOn());

                        break;

                    case ApplianceList.Blendr:

                        appliances[i] = new Blender(
                          PropRand.GetIsBowlExist(),
                          PropRand.GetHousingMaterial(),
                          PropRand.GetColor(),
                          PropRand.GetManufacturers(),
                          PropRand.GetIsTurnedOn());

                        break;
                    case ApplianceList.TV:

                        appliances[i] = new TV(
                          PropRand.GetManufacturers(),
                          PropRand.GetTypeMountAppliance(),
                          PropRand.GetMatrixType(),
                          PropRand.GetIsTurnedOn());

                        break;
                    case ApplianceList.Project:

                        appliances[i] = new Projector(
                         PropRand.GetManufacturers(),
                         PropRand.GetTypeMountAppliance(),
                         PropRand.GetProjectorInterfaceType(),
                         PropRand.GetIsTurnedOn());
                        break;
                }
            } // switch ((ApplianceList)rndAppl)

            return appliances;
        }
    }
}

namespace Module2_HW6_09062023
{
    using System;
    using Module2_HW6_09062023.Enums;

    public static class Starter
    {
        public static void Run()
        {
            const int ApplianceCount = 15;

            Appliance[] appliances = new Appliance[ApplianceCount];

            CreateHomeAppliance(appliances);
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

                switch ((ApplianceList)rndAppl)
                {
                    case ApplianceList.Refrigerator:

                        appliances[i] = new Refrigerator(
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

                    case ApplianceList.Blender:

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
                    case ApplianceList.Projector:

                        appliances[i] = new Projector(
                         PropRand.GetManufacturers(),
                         PropRand.GetTypeMountAppliance(),
                         PropRand.GetProjectorInterfaceType(),
                         PropRand.GetIsTurnedOn());
                        break;
                }
            }

            return appliances;
        }
    }
}

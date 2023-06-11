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
                        break;
                    case ApplianceList.Oven:
                        break;
                    case ApplianceList.Mixer:
                        break;
                    case ApplianceList.Blender:
                        break;
                    case ApplianceList.TV:
                        break;
                    case ApplianceList.Projector:
                        break;
                }
            }

            return appliances;
        }
    }
}

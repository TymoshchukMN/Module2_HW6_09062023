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
            int countApplTypes = Enum.GetValues(typeof(ApplianceList)).Length;



            return appliances;
        }
    }
}

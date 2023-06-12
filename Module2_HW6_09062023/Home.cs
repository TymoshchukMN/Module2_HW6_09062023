namespace Module2_HW6_09062023
{
    using System;
    using System.Threading;
    using Module2_HW6_09062023.Enums;
    using Module2_HW6_09062023.Interfaces;

    public class Home
    {
        private const int ApplianceCount = 10;
        private Appliance[] _appliances = new Appliance[ApplianceCount];

        /// <summary>
        /// Gets Appliances.
        /// </summary>
        public Appliance[] Appliances
        {
            get
            {
                return _appliances;
            }
        }

        public int CalculateEnergyConsuming(
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
        /// <param name="_appliances">
        /// Массив для заполнения.
        /// </param>
        /// <returns>
        /// Массив с заполненой техникой.
        /// </returns>
        public Appliance[] CreateHomeAppliance()
        {
            Random random = new Random();

            int countApplTypes = Enum.GetValues(typeof(ApplianceList)).Length;
            for (int i = 0; i < _appliances.Length; i++)
            {
                int rndAppl = random.Next(1, countApplTypes);

                Thread.Sleep(300);
                switch ((ApplianceList)rndAppl)
                {
                    case ApplianceList.Refrig:

                        _appliances[i] = new Refrig(
                            PropRand.GetCoolingSystem(),
                            PropRand.GetTypeMountAppliance(),
                            PropRand.GetColor(),
                            PropRand.GetManufacturers(),
                            PropRand.GetIsTurnedOn());

                        break;

                    case ApplianceList.Oven:

                        _appliances[i] = new Oven(
                           PropRand.GetControlType(),
                           PropRand.GetTypeMountAppliance(),
                           PropRand.GetColor(),
                           PropRand.GetManufacturers(),
                           PropRand.GetIsTurnedOn());

                        break;

                    case ApplianceList.Mixer:

                        _appliances[i] = new Mixer(
                          PropRand.GetMixerType(),
                          PropRand.GetHousingMaterial(),
                          PropRand.GetColor(),
                          PropRand.GetManufacturers(),
                          PropRand.GetIsTurnedOn());

                        break;

                    case ApplianceList.Blendr:

                        _appliances[i] = new Blender(
                          PropRand.GetIsBowlExist(),
                          PropRand.GetHousingMaterial(),
                          PropRand.GetColor(),
                          PropRand.GetManufacturers(),
                          PropRand.GetIsTurnedOn());

                        break;
                    case ApplianceList.TV:

                        _appliances[i] = new TV(
                          PropRand.GetManufacturers(),
                          PropRand.GetTypeMountAppliance(),
                          PropRand.GetMatrixType(),
                          PropRand.GetIsTurnedOn());

                        break;
                    case ApplianceList.Project:

                        _appliances[i] = new Projector(
                         PropRand.GetManufacturers(),
                         PropRand.GetTypeMountAppliance(),
                         PropRand.GetProjectorInterfaceType(),
                         PropRand.GetIsTurnedOn());
                        break;
                }
            } // switch ((ApplianceList)rndAppl)

            return _appliances;
        }
    }
}

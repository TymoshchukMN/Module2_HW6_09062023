namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Mixer : SmallAppliance
    {
        private MixerType _mixerType;

        public Mixer(
            MixerType mixerType,
            HousingMaterial housingMaterial,
            Color color,
            int energyConsumption,
            Manufacturers manufacturer,
            int voltage)
        {
            _mixerType = mixerType;
            HousingMaterial = housingMaterial;
            ColorAppliance = color;
            EnergyConsumption = energyConsumption;
            Manufacturer = manufacturer;
            Voltage = voltage;
        }

        public MixerType MixerType
        {
            get { return _mixerType; }
            set { _mixerType = value; }
        }
    }
}
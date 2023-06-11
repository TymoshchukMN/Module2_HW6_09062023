namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Mixer : SmallAppliance
    {
        private const int _energyConsumption = 200;
        private MixerType _mixerType;

        public Mixer(
            MixerType mixerType,
            HousingMaterial housingMaterial,
            ColorAppliance color,
            Manufacturers manufacturer)
        {
            _mixerType = mixerType;
            HousingMaterial = housingMaterial;
            ColorAppliance = color;
            EnergyConsumption = _energyConsumption;
            Manufacturer = manufacturer;
        }

        public MixerType MixerType
        {
            get { return _mixerType; }
            set { _mixerType = value; }
        }
    }
}
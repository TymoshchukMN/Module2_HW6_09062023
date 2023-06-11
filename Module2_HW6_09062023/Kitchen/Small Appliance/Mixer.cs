namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Mixer : SmallAppliance
    {
        private MixerType _mixerType;

        public MixerType MixerType
        {
            get { return _mixerType; }
            set { _mixerType = value; }
        }
    }
}
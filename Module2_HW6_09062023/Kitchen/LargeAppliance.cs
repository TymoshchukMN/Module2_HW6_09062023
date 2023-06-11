namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public abstract class LargeAppliance : Kitchen
    {
        private TypeMountAppliance _typeAppliance;

        public TypeMountAppliance TypeAppliance
        {
            get { return _typeAppliance; }
            set { _typeAppliance = value; }
        }
    }
}
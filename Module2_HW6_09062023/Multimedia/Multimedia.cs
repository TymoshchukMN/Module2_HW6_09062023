namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public abstract class Multimedia : Appliance
    {
        private TypeMountAppliance _typeMountAppliance;

        public TypeMountAppliance TypeMountAppliance
        {
            get { return _typeMountAppliance; }
            set { _typeMountAppliance = value; }
        }
    }
}
namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class Projector : Multimedia
    {
        private InterfaceType _interfaceType;

        public InterfaceType InterfaceType
        {
            get { return _interfaceType; }
            set { _interfaceType = value; }
        }
    }
}
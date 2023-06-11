namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class SmallAppliance : Kitchen
    {
        private FasteningType _fasteningType;

        public FasteningType TypeMountAppliance
        {
            get { return _fasteningType; }
            set { _fasteningType = value; }
        }
    }
}
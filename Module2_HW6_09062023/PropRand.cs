namespace Module2_HW6_09062023
{
    using System;
    using Module2_HW6_09062023.Enums;

    /// <summary>
    /// Generate random prop.
    /// </summary>
    public static class PropRand
    {
        public static ColorAppliance GetColor()
        {
            Random random = new Random();

            return (ColorAppliance)random.Next(
                1,
                Enum.GetValues(typeof(ColorAppliance)).Length);
        }

        public static ControlType GetControlType()
        {
            Random random = new Random();

            return (ControlType)random.Next(
                1,
                Enum.GetValues(typeof(ControlType)).Length);
        }

        public static CoolingSystem GetCoolingSystem()
        {
            Random random = new Random();

            return (CoolingSystem)random.Next(
                1,
                Enum.GetValues(typeof(CoolingSystem)).Length);
        }

        public static FasteningType GetFasteningType()
        {
            Random random = new Random();

            return (FasteningType)random.Next(
                1,
                Enum.GetValues(typeof(FasteningType)).Length);
        }

        public static Manufacturers GetManufacturers()
        {
            Random random = new Random();

            return (Manufacturers)random.Next(
                1,
                Enum.GetValues(typeof(Manufacturers)).Length);
        }

        public static MatrixType GetMatrixType()
        {
            Random random = new Random();

            return (MatrixType)random.Next(
                1,
                Enum.GetValues(typeof(MatrixType)).Length);
        }

        public static MixerType GetMixerType()
        {
            Random random = new Random();

            return (MixerType)random.Next(
                1,
                Enum.GetValues(typeof(MixerType)).Length);
        }

        public static HousingMaterial GetHousingMaterial()
        {
            Random random = new Random();

            return (HousingMaterial)random.Next(
                1,
                Enum.GetValues(typeof(HousingMaterial)).Length);
        }

        public static ProjectorInterfaceType GetProjectorInterfaceType()
        {
            Random random = new Random();

            return (ProjectorInterfaceType)random.Next(
                1,
                Enum.GetValues(typeof(ProjectorInterfaceType)).Length);
        }

        public static TypeMountAppliance GetTypeMountAppliance()
        {
            Random random = new Random();

            return (TypeMountAppliance)random.Next(
                1,
                Enum.GetValues(typeof(TypeMountAppliance)).Length);
        }

        public static bool GetIsBowlExist()
        {
            Random random = new Random();

            switch (random.Next(1,2))
            {
                case 1:
                    return false;
                case 2:
                    return true;
            }
            return true;
        }
    }
}

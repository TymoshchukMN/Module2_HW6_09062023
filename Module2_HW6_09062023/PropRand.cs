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
                Enum.GetValues(typeof(ColorAppliance)).Length + 1);
        }

        public static ControlType GetControlType()
        {
            Random random = new Random();

            return (ControlType)random.Next(
                1,
                Enum.GetValues(typeof(ControlType)).Length + 1);
        }

        public static CoolingSystem GetCoolingSystem()
        {
            Random random = new Random();

            return (CoolingSystem)random.Next(
                1,
                Enum.GetValues(typeof(CoolingSystem)).Length + 1);
        }

        public static FasteningType GetFasteningType()
        {
            Random random = new Random();

            return (FasteningType)random.Next(
                1,
                Enum.GetValues(typeof(FasteningType)).Length + 1);
        }

        public static Manufacturers GetManufacturers()
        {
            Random random = new Random();

            return (Manufacturers)random.Next(
                1,
                Enum.GetValues(typeof(Manufacturers)).Length + 1);
        }

        public static MatrixType GetMatrixType()
        {
            Random random = new Random();

            return (MatrixType)random.Next(
                1,
                Enum.GetValues(typeof(MatrixType)).Length + 1);
        }

        public static MixerType GetMixerType()
        {
            Random random = new Random();

            return (MixerType)random.Next(
                1,
                Enum.GetValues(typeof(MixerType)).Length + 1);
        }

        public static HousingMaterial GetHousingMaterial()
        {
            Random random = new Random();

            return (HousingMaterial)random.Next(
                1,
                Enum.GetValues(typeof(HousingMaterial)).Length + 1);
        }

        public static ProjectorInterfaceType GetProjectorInterfaceType()
        {
            Random random = new Random();

            return (ProjectorInterfaceType)random.Next(
                1,
                Enum.GetValues(typeof(ProjectorInterfaceType)).Length + 1);
        }

        public static TypeMountAppliance GetTypeMountAppliance()
        {
            Random random = new Random();

            return (TypeMountAppliance)random.Next(
                1,
                Enum.GetValues(typeof(TypeMountAppliance)).Length + 1);
        }

        public static bool GetIsBowlExist()
        {
            Random random = new Random();

            switch (random.Next(1, 3))
            {
                case 1:
                    return false;
                case 2:
                    return true;
            }

            return true;
        }

        public static bool GetIsTurnedOn()
        {
            Random gen = new Random();
            int prob = gen.Next(100);

            return prob < 20;
        }
    }
}

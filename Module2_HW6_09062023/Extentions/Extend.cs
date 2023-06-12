namespace Module2_HW6_09062023.Extentions
{
    using System;
    using Module2_HW6_09062023.Enums;

    public static class Extend
    {
        public static Appliance[] FindApplience(
            this Appliance[] appliances,
            Manufacturers manufacturer)
        {
            Appliance[] findedAppl = new Appliance[0];

            for (int i = 0; i < appliances.Length; i++)
            {
                if (appliances[i].Manufacturer == manufacturer)
                {
                    Array.Resize(ref findedAppl, appliances.Length + 1);
                    findedAppl[appliances.Length - 1] = appliances[i];
                }
            }

            return findedAppl;
        }

        public static Appliance[] FindApplience(
            this Appliance[] appliances,
            Manufacturers manufacturer,
            bool isTurnedOn)
        {
            Appliance[] findedAppl = new Appliance[0];

            for (int i = 0; i < appliances.Length; i++)
            {
                if (appliances[i].Manufacturer == manufacturer
                    && appliances[i].IsTurnedOn == isTurnedOn)
                {
                    Array.Resize(ref findedAppl, findedAppl.Length + 1);
                    findedAppl[findedAppl.Length - 1] = appliances[i];
                }
            }

            return findedAppl;
        }
    }
}

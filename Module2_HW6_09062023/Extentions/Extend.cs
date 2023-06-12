namespace Module2_HW6_09062023.Extentions
{
    using System;
    using Module2_HW6_09062023.Enums;

    public static class Extend
    {
        public static Appliance[] FindApplience(Manufacturers manufacturer)
        {
            Appliance[] findedAppliances = new Appliance[0];

            for (int i = 0; i < findedAppliances.Length; i++)
            {
                if (findedAppliances[i].Manufacturer == manufacturer)
                {
                    Array.Resize(ref findedAppliances, findedAppliances.Length + 1);
                    findedAppliances[findedAppliances.Length - 1] = findedAppliances[i];
                }
            }

            return findedAppliances;
        }

        public static Appliance[] FindApplience(Manufacturers manufacturer, bool isTurnedOn)
        {
            Appliance[] findedAppliances = new Appliance[0];

            for (int i = 0; i < findedAppliances.Length; i++)
            {
                if (findedAppliances[i].Manufacturer == manufacturer
                    && findedAppliances[i].IsTurnedOn == isTurnedOn)
                {
                    Array.Resize(ref findedAppliances, findedAppliances.Length + 1);
                    findedAppliances[findedAppliances.Length - 1] = findedAppliances[i];
                }
            }

            return findedAppliances;
        }
    }
}

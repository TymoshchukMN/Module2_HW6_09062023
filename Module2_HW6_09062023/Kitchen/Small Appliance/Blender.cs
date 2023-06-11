using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2_HW6_09062023
{
    public class Blender : SmallAppliance
    {
        private bool _bowlExist;

        public bool BowlExist
        {
            get { return _bowlExist; }
            set { _bowlExist = value; }
        }

    }
}
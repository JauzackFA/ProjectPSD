using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class MeatFactory
    {
        public static Meat createMeat(string name)
        {
            Meat meat = new Meat();
            meat.MeatName = name;

            return meat;
        }
    }
}
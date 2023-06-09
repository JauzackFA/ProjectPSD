using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class RamenFactory
    {
        public static Raman createRamen(string name, string broth, string price, int meatid)
        {
            Raman ramen = new Raman();
            ramen.RamenName = name;
            ramen.RamenBroth = broth;
            ramen.RamenPrice = price;
            ramen.MeatID = meatid;

            return ramen;
        }
    }
}
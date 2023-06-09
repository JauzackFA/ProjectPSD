using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class Detailfactory
    {
        public static Detail createDetail(int headerid, int ramenid, int quantity)
        {
            Detail detail = new Detail();
            detail.HeaderID = headerid;
            detail.RamenID = ramenid;
            detail.Quanity = quantity;

            return detail;
        }
    }
}
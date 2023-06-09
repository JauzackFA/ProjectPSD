using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class HeaderFactory
    {
        public static Header createHeader(int staffid, DateTime date, int userid)
        {
            Header header = new Header();
            header.StaffID = staffid;
            header.HeaderDate = date;
            header.UserID = userid;

            return header;
        }
    }
}
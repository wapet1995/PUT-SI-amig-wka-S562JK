using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewAllocationForms
{
    class FlightData
    {
        public string NumerLotu { get; set; }
        public string LiczbaZalogi { get; set; }
        public string LiczbaStewardow { get; set; }
        public string LiczbaStewardes { get; set; }
        public string OsóbZFrancuskim { get; set; }
        public string OsóbZNiemieckim { get; set; }
        public string OsóbZHiszpanskim { get; set; }


        public FlightData(int no, string lZalog, string lSteward, string lStewardess, string lFrench, string lDeutsch, string lSpain)
        {
            NumerLotu = no.ToString();
            LiczbaZalogi = lZalog;
            LiczbaStewardow = lSteward;
            LiczbaStewardes = lStewardess;
            OsóbZFrancuskim = lFrench;
            OsóbZNiemieckim = lDeutsch;
            OsóbZHiszpanskim = lSpain;
        }

        public FlightData(int num, string prologRequiresList)
        {
            NumerLotu = num.ToString();

            String[] atts =
                prologRequiresList
                .Substring(1, prologRequiresList.Length - 2)
                .Split(new char[] { ',' });

            LiczbaZalogi = atts[0];
            LiczbaStewardow = atts[1];
            LiczbaStewardes = atts[2];
            OsóbZFrancuskim = atts[3];
            OsóbZNiemieckim = atts[4];
            OsóbZHiszpanskim = atts[5];
        }


        public String preparePrologRepresentation()
        {
            return "[" + LiczbaZalogi + ", " + LiczbaStewardow + ", " + LiczbaStewardes + ", "
                    + OsóbZFrancuskim + ", " + OsóbZNiemieckim + ", " + OsóbZHiszpanskim + "]";
        }
    }
}

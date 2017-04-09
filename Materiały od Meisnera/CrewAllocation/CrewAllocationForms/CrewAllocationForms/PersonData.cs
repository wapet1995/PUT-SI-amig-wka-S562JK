using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewAllocationForms
{
    class PersonData
    {
        public String Numer { get; set; }
        public String Imię { get; set; }
        public String Zawód { get; set; }
        public String ZnaFrancuski { get; set; }
        public String ZnaNiemiecki { get; set; }
        public String ZnaHiszpański { get; set; }

        public PersonData() { }

        public PersonData(int num, string name, string attributesPrologList)
        {
            Numer = num.ToString();
            Imię = name;

            String[] atts =
                attributesPrologList
                .Substring(1, attributesPrologList.Length - 2)
                .Split(new char[]{','});

            Zawód = (atts[0].Equals("1") ? "Steward" : "Stewardesa");
            // atts[1] = czy jest stewardessą, pomiń
            ZnaFrancuski = (atts[2].Equals("1") ? "T" : "N");
            ZnaNiemiecki = (atts[3].Equals("1") ? "T" : "N");
            ZnaHiszpański = (atts[4].Equals("1") ? "T" : "N");
        }

        public String preparePrologRepresentation()
        {
            return String.Format("[{0}, {1}, {2}, {3}, {4}]",
                    (Zawód.Equals("Steward") ? "1" : "0"),
                    (Zawód.Equals("Stewardesa") ? "1" : "0"),
                    (ZnaFrancuski.Equals("T") ? "1" : "0"),
                    (ZnaNiemiecki.Equals("T") ? "1" : "0"),
                    (ZnaHiszpański.Equals("T") ? "1" : "0")
                );
        }
    }
}

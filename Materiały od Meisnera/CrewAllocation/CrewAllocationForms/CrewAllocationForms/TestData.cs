using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewAllocationForms
{
    class TestData
    {
        private static readonly String[] Names = {
            "tom", "david", "jeremy", "ron", "joe",
            "bill", "fred", "bob", "mario", "ed",
            "carol", "janet", "tracy", "marylin", "carolyn",
            "cathy", "inez", "jean", "heather", "juliet" };

        private static readonly String[] Attributes = {
            "[1,0,0,0,1]", "[1,0,0,0,0]", "[1,0,0,0,1]", "[1,0,0,0,0]", "[1,0,0,1,0]",
            "[1,0,1,1,0]", "[1,0,0,1,0]", "[1,0,0,0,0]", "[1,0,0,1,1]", "[1,0,0,0,0]",
            "[0,1,0,0,0]", "[0,1,0,0,0]", "[0,1,0,0,0]", "[0,1,0,1,1]", "[0,1,0,0,0]",
            "[0,1,0,0,0]", "[0,1,1,1,1]", "[0,1,1,0,0]", "[0,1,0,1,1]", "[0,1,1,0,0]" };

        private static readonly String[] Flights = {
            "[4,1,1,1,1,1]",
            "[5,1,1,1,1,1]",
            "[5,1,1,1,1,1]",
            "[6,2,2,1,1,1]",
            "[7,3,3,1,1,1]",
            "[4,1,1,1,1,1]",
            "[5,1,1,1,1,1]",
            "[6,1,1,1,1,1]",
            "[6,2,2,1,1,1]",
            "[7,3,3,1,1,1]" };


        public static void addNames(List<String> namesList)
        {
            foreach (String name in Names)
                namesList.Add(name);
        }

        public static List<PersonData> generateTestCrew()
        {
            List<PersonData> crew = new List<PersonData>(Names.Length);
            for (int i=0; i<Names.Length; i++) {
                crew.Add(new PersonData(i + 1, Names[i], Attributes[i]));
            }
            return crew;
        }

        public static List<FlightData> generateTestFlightsRequirements()
        {
            List<FlightData> flights = new List<FlightData>(Flights.Length);
            for (int i = 0; i < Flights.Length; i++)
            {
                flights.Add(new FlightData(i + 1, Flights[i]));
            }
            return flights;
        }


        public static string prepareDefaultCrew()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append(Attributes[0]);
            for (int i = 1; i < Attributes.Length; i++)
            {
                sb.Append(",");
                sb.Append(Attributes[i]);
            }
            sb.Append("]");
            return sb.ToString();
        }

        public static string prepareDefaultRequirements()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append(Attributes[0]);
            for (int i = 1; i < Flights.Length; i++)
            {
                sb.Append(",");
                sb.Append(Attributes[i]);
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}

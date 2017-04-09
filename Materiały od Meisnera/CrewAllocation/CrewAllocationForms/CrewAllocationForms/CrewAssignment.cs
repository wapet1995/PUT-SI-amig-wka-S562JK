using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewAllocationForms
{
    class CrewAssignment
    {
        private ArrayList teams;
        public int FlightsCount { get; private set; }
        public int CrewSize { get; private set; }


        /// <summary>
        /// Wyciągnięcie z wyniku wywołania programu prologowego solvera
        /// łamigłowki danych o przypisaniach pracowników do lotów.
        /// W ciągu wejściowym nie powinno być białych znaków.
        /// </summary>
        public void parsePrologResult(String teamsFromProlog)
        {
            teams = new ArrayList();
            CharEnumerator chr = teamsFromProlog.GetEnumerator();
            int teamSize, lastTeamSize = 0;

            FlightsCount = 0;
            CrewSize = 0;

            try
            {
                if (chr.MoveNext() && chr.Current != '[')
                    throw new ArgumentException("Niepoprawny format danych.");

                while (chr.MoveNext())
                {
                    if (chr.Current == ']')
                        break;
                    else if (chr.Current != '[')
                        throw new ArgumentException("Niepoprawny format danych.");

                    ArrayList team = new ArrayList();
                    teamSize = 0;

                    while (chr.MoveNext() && chr.Current != ']')
                    {
                        if (chr.Current == ',')
                            chr.MoveNext();
                        if (chr.Current == '0')
                            team.Add(0);
                        else if (chr.Current == '1')
                            team.Add(1);
                        else
                            throw new ArgumentException("Niepoprawny format danych.");
                        teamSize++;
                    }

                    if (lastTeamSize == 0)
                        lastTeamSize = teamSize;
                    else if (teamSize != lastTeamSize)
                        throw new ArgumentException("Niepoprawne dane: różna liczność wierszy macierzy zespołów.");

                    teams.Add(team);

                    if (chr.MoveNext() && chr.Current == ']')
                        break;
                    else if (chr.Current != ',')
                        throw new ArgumentException("Niepoprawny format danych.");
                }
            }
            catch (ArgumentException ex)
            {
                teams = null;
                throw ex;
            }

            FlightsCount = teams.Count;
            CrewSize = lastTeamSize;
        }


        /// <summary>
        /// Zwraca listę numerów lotów, w których bierze udział pracownik
        /// o podanym numerze.
        /// </summary>
        public LinkedList<int> getEmployeeFlights(int employeeNum)
        {
            if (teams == null)
                throw new Exception("Macierz przypisań załogi do lotów jest pusta!");

            LinkedList<int> assingments = new LinkedList<int>();
            int teamNum = 0;
            foreach (ArrayList team in teams) {
                if ((int)team[employeeNum] == 1)
                    assingments.AddLast(teamNum);
                teamNum++;
            }

            return assingments;
        }

        /// <summary>
        /// Zwraca listę przypisań pracowników do lotów w postaci zerojedynkowej.
        /// 1 oznacza że pracownik bierze udział w locie, 0 - że nie leci.
        /// </summary>
        public ArrayList getFlightAssingments(int flightNum)
        {
            if (teams == null)
                throw new Exception("Macierz przypisań załogi do lotów jest pusta!");

            return (ArrayList) teams[flightNum];
        }
    }
}

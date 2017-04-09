using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SbsSW.SwiPlCs;
using ZedGraph;
using System.IO;
using System.Collections;


namespace CrewAllocationForms
{
	public partial class Form1 : Form
	{

		private List<FlightData> flightsRequirements;
        private List<PersonData> personel;
		public String crewTerm;
		public PlQuery prologQuery;
		public PlTermV prologParams;
        private CrewAssignment crewAssingment;

		public Form1()
		{
			InitializeComponent();
			flightsRequirements = new List<FlightData>();
            personel = new List<PersonData>();
            crewAssingment = new CrewAssignment();

            GraphPane pane = this.zgc1.GraphPane;
            pane.Title.Text = "Przydział pracowników do lotów";
            pane.XAxis.Title.Text = "U dołu: loty, u góry: pracownicy";
            pane.YAxis.Title.Text = "";
            pane.Legend.IsVisible = false;
            pane.Chart.Border.IsVisible = false;
            pane.XAxis.Scale.IsVisible = false;
            pane.XAxis.MinorTic.IsAllTics = false;
            pane.XAxis.MajorTic.IsAllTics = false;
            pane.XAxis.IsVisible = false;
            pane.YAxis.Scale.IsVisible = false;
            pane.YAxis.MinorTic.IsAllTics = false;
            pane.YAxis.MajorTic.IsAllTics = false;
            pane.YAxis.IsVisible = false;
            pane.XAxis.Scale.Max = 0;

            flightsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            crewListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		}

		/// <summary>
		/// Wygenerowanie pierwszego rozwiązania.
		/// </summary>
		private void start_button_Click(object sender, EventArgs e)
		{
			try
			{
				String sciezka = @"..\..\..\alloc.pl";
				if (!File.Exists(sciezka)) throw new FileNotFoundException("Brak pliku: " + sciezka);

                String crew = prepareCrewPrologList();
                String flightsReqs = prepareFlightsRequirements(); //DefaultData.prepareDefaultRequirements();

				if (!PlEngine.IsInitialized)
				{
					String[] param = {"-f", sciezka };
					PlEngine.Initialize(param);
                }

				prologParams = new PlTermV(3);
				prologQuery = new PlQuery("matchTeams", prologParams);
				prologParams[1] = new PlTerm(flightsReqs);
				prologParams[2] = new PlTerm(crew);

                generateResultAndShow();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Wyjatek:\n\n" + ex.Message);
			}

		}

        private bool generateResultAndShow()
        {
            prologQuery.NextSolution();
            String result = prologParams[0].ToString();

            if (result.StartsWith("[") != true)
            {
                MessageBox.Show("Nie udało się znaleźć rozwiązania.");
                return false;
            }

            try
            {
                crewAssingment.parsePrologResult(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Złapano wyjątek:\n\n" + ex.Message);
                return false;
            }

            zgc1.GraphPane.GraphObjList.Clear();
            fillFlightsAssingmentsList();
            prepareFilterLists();
            refreshGraph();
            return true;
        }

        /// <summary>
        /// Wypełnienie grafu powiązań pracowników z lotami.
        /// Zostaną wzięci pod uwagę tylko ci pracownicy i tylko te loty,
        /// które sa zaznaczone na liście filtrów.
        /// </summary>
        private void refreshGraph()
        {
            GraphPane pane = this.zgc1.GraphPane;
            pane.CurveList.Clear();

            for (int flightNum = 0; flightNum < crewAssingment.FlightsCount; flightNum++)
            {
                if (flightsListView.Items[flightNum].Checked == false)
                    continue;

                ArrayList team = crewAssingment.getFlightAssingments(flightNum);
                for (int persNum = 0; persNum < crewListView.Items.Count; persNum++)
                {
                    if (crewListView.Items[persNum].Checked == false || (Int32)team[persNum] == 0)
                        continue;

                    showOnGraph(flightNum, persNum);
                }

                // podpis punktu
                ZedGraph.TextObj text = new ZedGraph.TextObj("Lot " + (flightNum + 1), 2*flightNum+1 - 0.7, 3,
                    ZedGraph.CoordType.AxisXYScale, ZedGraph.AlignH.Left, ZedGraph.AlignV.Center);
                text.ZOrder = ZedGraph.ZOrder.A_InFront;
                text.FontSpec.Border.IsVisible = false;
                text.FontSpec.Fill.IsVisible = false;
                text.FontSpec.IsBold = true;
                text.FontSpec.Angle = 60;
                pane.GraphObjList.Add(text);
            }

            for (int i = 0; i < personel.Count; i++)
            {
                ZedGraph.TextObj text = new ZedGraph.TextObj(personel[i].Imię, 1+i, 10 + 0.3,
                    ZedGraph.CoordType.AxisXYScale, ZedGraph.AlignH.Left, ZedGraph.AlignV.Center);
                text.ZOrder = ZedGraph.ZOrder.A_InFront;
                text.FontSpec.Border.IsVisible = false;
                text.FontSpec.Fill.IsVisible = false;
                text.FontSpec.IsBold = true;
                text.FontSpec.Angle = 60;
                pane.GraphObjList.Add(text);
            }

            pane.XAxis.Scale.Max = crewAssingment.FlightsCount * 2 + 4;
            pane.YAxis.Scale.MaxGrace = 0.2;
            zgc1.Refresh();
        }

        /// <summary>
        /// Zaznaczenie połączenia pracownika z lotem na grafie.
        /// </summary>
        private void showOnGraph(int flightNum, int personNum)
        {
            GraphPane myPane = this.zgc1.GraphPane;
            PointPairList list1 = new PointPairList();

            Color[] COLORS = new Color[] {
                Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Orange,
                Color.Pink, Color.Cyan, Color.Purple, Color.DarkGreen, Color.Brown,
                Color.Chocolate, Color.Lime, Color.SteelBlue, Color.Olive, Color.SeaGreen,
                Color.DarkBlue, Color.Gold, Color.Fuchsia, Color.MediumOrchid, Color.Teal
            };

            list1.Add(1+personNum, 10);
            list1.Add(2*flightNum+1, 4);
            LineItem myCurve = myPane.AddCurve(
                String.Format("Lot{0}", flightNum + 1),
                list1, COLORS[personNum % COLORS.Length], SymbolType.Diamond);
           

            zgc1.AxisChange();
        }

        /// <summary>
        /// Wpisanie listy zespołów do pola tekstowego.
        /// </summary>
        private void fillFlightsAssingmentsList()
        {
            flightsAssingmentsTB.Clear();
            StringBuilder teamsStr = new StringBuilder();

            for (int i = 0; i < crewAssingment.FlightsCount; i++)
            {
                ArrayList team = crewAssingment.getFlightAssingments(i);
                teamsStr.Append(String.Format("Lot {0}:", i + 1));

                for (int employeeNum = 0; employeeNum < team.Count; employeeNum++) {
                    if ((Int32)team[employeeNum] == 1)
                        teamsStr.Append(String.Format(" " + personel[employeeNum].Imię));
                }

                teamsStr.AppendLine();
            }

            flightsAssingmentsTB.Text = teamsStr.ToString();
        }

        private void prepareFilterLists()
        {
            flightsListView.Items.Clear();
            for (int i = 1; i <= crewAssingment.FlightsCount; i++)
                flightsListView.Items.Add(String.Format("Lot {0}", i)).Checked = true;

            crewListView.Items.Clear();
            foreach (PersonData person in personel)
                crewListView.Items.Add(person.Imię).Checked = true;
        }

        /// <summary>
        /// Generuj kolejne rozwiązanie.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            generateResultAndShow();
        }

		/// <summary>
		/// Utworzenie listy wymagań lotów w stylu Prologa.
		/// </summary>
		private string prepareFlightsRequirements()
		{
			StringBuilder result = new StringBuilder();
			result.Append("[");

			if (flightsRequirements.Count > 0)
			{
				List<FlightData>.Enumerator flight = flightsRequirements.GetEnumerator();
                flight.MoveNext();
				result.Append(flight.Current.preparePrologRepresentation());

				while (flight.MoveNext())
				{
					result.Append(", ");
					result.Append(flight.Current.preparePrologRepresentation());
				}
			}
			result.Append("]");

			return result.ToString();
		}

        private string prepareCrewPrologList()
        {
            StringBuilder result = new StringBuilder();
            result.Append("[");

            if (personel.Count > 0)
            {
                List<PersonData>.Enumerator person = personel.GetEnumerator();
                person.MoveNext();
                result.Append(person.Current.preparePrologRepresentation());

                while (person.MoveNext())
                {
                    result.Append(", ");
                    result.Append(person.Current.preparePrologRepresentation());
                }
            }
            result.Append("]");

            return result.ToString();
        }


        /// <summary>
        /// Dodanie definicji lotu.
        /// </summary>
		private void button1_Click(object sender, EventArgs e)
		{
			flightsRequirements.Add(
                new FlightData(flightsRequirements.Count+1,
                    personelNumberTB.Text, minStewardsTB.Text,
                    minStewardesessTB.Text, minFrenchTB.Text,
                    minGermanTB.Text, minSpanishTB.Text));
            updateFlightsDataGridView();
        }

        private void updateFlightsDataGridView()
        {
            dataGridViewFlights.DataSource = null;
			dataGridViewFlights.DataSource = flightsRequirements;
            dataGridViewFlights.Columns[0].Width = 80;
            dataGridViewFlights.Columns[1].Width = 80;

            personelNumberTB.Clear();
            minStewardsTB.Clear();
            minStewardesessTB.Clear();
            minFrenchTB.Clear();
            minGermanTB.Clear();
            minSpanishTB.Clear();
		}

        private void updateCrewDataGridView()
        {
            dataGridViewCrew.DataSource = null;
            dataGridViewCrew.DataSource = personel;
            dataGridViewCrew.Columns[0].Width = 60;

            personNameTB.Clear();
            personJobCB.SelectedItem = null;
            personFrenchCbx.Checked = false;
            personGermanCbx.Checked = false;
            personSpanishCbx.Checked = false;
        }


        private void filterBtn_Click(object sender, EventArgs e)
        {
            refreshGraph();
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            for (int i = 0; i < flightsRequirements.Count; i++)
                flightsRequirements[i].NumerLotu = (i + 1).ToString();
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            personel.Add(
                new PersonData()
                {
                    Numer = (personel.Count + 1).ToString(),
                    Imię = personNameTB.Text,
                    Zawód = (personJobCB.SelectedIndex == 0? "Steward" : "Stewardesa"),
                    ZnaFrancuski = (personFrenchCbx.Checked ? "T" : "N"),
                    ZnaNiemiecki = (personGermanCbx.Checked ? "T" : "N"),
                    ZnaHiszpański = (personSpanishCbx.Checked ? "T" : "N")
                });

            updateCrewDataGridView();
        }

        private void generateTestCrewBtn_Click(object sender, EventArgs e)
        {
            personel = TestData.generateTestCrew();
            updateCrewDataGridView();
        }

        private void generateTestFlightsBtn_Click(object sender, EventArgs e)
        {
            flightsRequirements = TestData.generateTestFlightsRequirements();
            updateFlightsDataGridView();
        }

        private void revertFlightsBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flightsListView.Items.Count; i++)
                flightsListView.Items[i].Checked = !flightsListView.Items[i].Checked;
        }

        private void revertCrewBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < crewListView.Items.Count; i++)
                crewListView.Items[i].Checked = !crewListView.Items[i].Checked;
        }

	}
}

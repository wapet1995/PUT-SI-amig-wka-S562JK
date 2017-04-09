using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChangingMoneyGui
{
    public partial class Form1 : Form
    {
        private IQueryExecuter _executer;

        delegate void doActionHandler();

        public Form1()
        {
            InitializeComponent();

            inicjalizacja();

            dodajZdarzenia();
        }

        #region Kontenery

        private List<NumericUpDown> listaPortfela()
        {
            return new List<NumericUpDown>
        		   {
        		        portfel500,
        		        portfel200,
        		        portfel100,
        		        portfel50,
        		        portfel20,
        		        portfel10,
        		        portfel5,
        		        portfel2,
        		        portfel1
        		   };
        }

        private Label[] listaWynikow()
        {
            return new[]
        		   {
        		        wynik1,
        		        wynik2,
        		        wynik5,
        		        wynik10,
        		        wynik20,
        		        wynik50,
        		        wynik100,
        		        wynik200,
        		        wynik500,
        		   };
        }

        private int lastCount;

        #endregion

        #region Zdarzenia

        private void oblicz_Click(object sender, EventArgs e)
        {
            int kwota = (int)this.kwota.Value;
            const string variables = "ZL5, ZL2, ZL1, G50, G20, G10, G05, G02, G01";
            string portfelList = listaMoneyWPortfelu();

            Dictionary<string, string> result = _executer.Run(kwota, variables, portfelList);

            aktualizujFormularz(result, obliczWykonano);
        }

        private void next_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> result = _executer.Next();

            aktualizujFormularz(result, nextWykonano);
        }

        private void portfelZeruj_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return;

            portfelEnable(false);

            zerujPortfel();
        }

        private void portfelLosowo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return;

            portfelEnable(false);

            losowyPortfel();
        }

        private void portfelKwota_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return;

            portfelEnable(true);
        }

        private void zlokalizuj_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == pobierzSciezke())
                zmienSciezke(folderBrowserDialog.SelectedPath);
        }

        private void portfel_Click(object sender, EventArgs e)
        {
            int amount = (int)portfelKwotaValue.Value;
            znanyPortfel(amount);
        }

        private void kwota_ValueChanged(object sender, EventArgs e)
        {
            czyscFormularze();
        }

        #endregion

        #region Funkcje

        #region Połączenie z SWI-Prologiem

        private void inicjalizacja()
        {
            _executer = new ChangingMoneyExecuter();

            string consult = String.Format("consult('{0}\\ChangingMoney.pl')", Environment.CurrentDirectory);
            consult = consult.Replace("\\", "\\\\");

            PrologConnector.Code.Add(consult);

            zmienSciezke(Properties.Settings.Default.swiprolog);
        }

        private DialogResult pobierzSciezke()
        {
            return folderBrowserDialog.ShowDialog(this);
        }

        private void zmienSciezke(string path)
        {
            PrologConnector.Path = path;

            aktualizujStanPolaczenia(PrologConnector.IsConnected);
        }

        private void aktualizujStanPolaczenia(bool connected)
        {
            if (connected)
            {
                stan.Text = "połączony";

                Properties.Settings.Default.swiprolog = PrologConnector.Path;
            }
            else
                stan.Text = "niepołączony";

            oblicz.Enabled = connected;
        }

        #endregion

        #region Portfel

        private void zerujPortfel()
        {
            portfelUstaw(new int[9], false);
        }

        private void losowyPortfel()
        {
            int[] values = WalletSetter.RandomWallet(9, new int[] { 10, 8, 5 });
            portfelUstaw(values, true);
        }

        private void znanyPortfel(int amount)
        {
            int[] values = WalletSetter.SetAmount(amount);
            portfelUstaw(values, true);
        }

        private void portfelUstaw(int[] values, bool reverse)
        {
            var lista = listaPortfela();
            if (reverse)
                lista.Reverse();

            int i = 0;
            foreach (NumericUpDown nud in lista)
                nud.Value = values[i++];
        }

        private void portfelEnable(bool val)
        {
            portfelKwotaValue.Enabled = val;
            portfel.Enabled = val;
        }

        private string listaMoneyWPortfelu()
        {
            StringBuilder builder = new StringBuilder();
            foreach (NumericUpDown nud in listaPortfela())
                builder.AppendFormat("{0}, ", nud.Value);

            return builder.ToString().Substring(0, builder.Length - 2);
        }

        private void wstawWyniki(Dictionary<string, string> result)
        {
            if (result.Count == 0)
            {
                if (wynikIteracja.Text == "")
                    throw new NoResultException();

                throw new EndOfResultsException();
            }

            if (wynik1.Text != "")
            {
                int count = licz();
                if (count > 0)
                {
                    int c = int.Parse(result["G01"]) + int.Parse(result["G02"]) + int.Parse(result["G05"])
                        + int.Parse(result["G10"]) + int.Parse(result["G20"]) + int.Parse(result["G50"])
                        + int.Parse(result["ZL1"]) + int.Parse(result["ZL2"]) + int.Parse(result["ZL5"]);

                    if (c > count)
                        throw new EndOfGoodResultsException();
                }
            }

            wynik1.Text = result["G01"];
            wynik2.Text = result["G02"];
            wynik5.Text = result["G05"];
            wynik10.Text = result["G10"];
            wynik20.Text = result["G20"];
            wynik50.Text = result["G50"];
            wynik100.Text = result["ZL1"];
            wynik200.Text = result["ZL2"];
            wynik500.Text = result["ZL5"];
        }

        #endregion

        #region Wyniki

        private void obliczWykonano()
        {
            next.Enabled = true;
            wynikIteracja.Text = "Iteracja: 1";
            liczMonety();
        }

        private void nextWykonano()
        {
            string[] split = wynikIteracja.Text.Split(' ');
            int no = int.Parse(split[1]);
            no++;
            wynikIteracja.Text = String.Format("{0} {1}", split[0], no);
            liczMonety();
        }

        private void liczMonety()
        {
            int suma = licz();
            lastCount = suma;

            wynikInformacje.ForeColor = Color.Black;
            wynikInformacje.Text = String.Format("Liczba monet: {0}", suma);
        }

        private int licz()
        {
            int suma = 0;
            foreach (Label label in listaWynikow())
                suma += int.Parse(label.Text);
            return suma;
        }

        private void aktualizujFormularz(Dictionary<string, string> result, doActionHandler func)
        {
            try
            {
                wstawWyniki(result);

                func();
            }
            catch (NoResultException)
            {
                wynikInformacje.ForeColor = Color.Red;
                wynikInformacje.Text = "Monety znajdujące się w portfelu nie pozwalają na zapłacenie dokładnej kwoty.";
            }
            catch (EndOfResultsException)
            {
                czyscFormularze();
                wynikInformacje.ForeColor = Color.Navy;
                wynikInformacje.Text = "Nie ma więcej możliwości.";
            }
            catch (EndOfGoodResultsException)
            {
                czyscFormularze();
                wynikInformacje.ForeColor = Color.Navy;
                wynikInformacje.Text = string.Format("Nie ma więcej możliwości wykorzystujących {0} monet{1}.", 
                    lastCount, (lastCount == 1 ? "ę" : (lastCount > 1 && lastCount < 5 ? "y" : "")));
            }
        }

        #endregion

        #region Ustawienia i Wygląd

        private void dodajZdarzenia()
        {
            this.FormClosing += delegate { zwolnijIZapisz(); };

            foreach (NumericUpDown nud in listaPortfela())
                nud.ValueChanged += delegate { czyscFormularze(); };
        }

        private void czyscFormularze()
        {
            next.Enabled = false;
            wynikInformacje.Text = "";
            wynikIteracja.Text = "";

            czyscWyniki();
        }

        private void czyscWyniki()
        {
            Label[] labels = new[]
                                 {
                                     wynik1,
                                     wynik2,
                                     wynik5,
                                     wynik10,
                                     wynik20,
                                     wynik50,
                                     wynik100,
                                     wynik200,
                                     wynik500,
                                 };

            foreach (Label label in labels)
                label.Text = "";
        }

        private void zwolnijIZapisz()
        {
            PrologConnector.Dispose();
            Properties.Settings.Default.Save();
        }

        #endregion

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjektNr3_Kuźnicki61961.BryłyGeometryczne2;

namespace ProjektNr3_Kuźnicki61961
{
    public partial class ProjektIndywidualnyNr3 : Form
    {
        const int PromienPunktuLokalizacji = 2;
        Point PunktLokalizacjiBryly = new Point(-1, -1);
        Graphics Rysownica;
        List<BrylaAbstrakcyjna> LBG = new List<BrylaAbstrakcyjna>();
        float KatObrotu;
        public static ProjektIndywidualnyNr3 UchwytFormularza;
        public int JKn = 0;
        public ProjektIndywidualnyNr3()
        {
            InitializeComponent();
            UchwytFormularza = this;
            JKpbRysownica.Image = new Bitmap(JKpbRysownica.Width,JKpbRysownica.Height);
            Rysownica = Graphics.FromImage(JKpbRysownica.Image);
            JKlblWysokośćBryły.Text = JKtrbWysokoscBryly.Value.ToString();
            JKlblPromieńBG.Text=JKtrbPromienBryly.Value.ToString();
            JKlblGrubośćLinii.Text=JKtrbGruboscLinii.Value.ToString();
            JKlblKątPochylenia.Text = JKtrbKątPochylenia.Value.ToString();
        }

        private void ProjektIndywidualnyNr3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Oknomessage = MessageBox.Show("Czy na pewno chcesz zamknąć ten formularz wrócić do kokpitu? Samoocena z zaprojektowanego rozwiązania zadania projektowego Nr 2: 5, ponieważ zostały zaimplementowane prawie wszystkie kluczowe wymagane funkcje", this.Text, MessageBoxButtons.YesNo);
            //sprawdzenie podjetej decyzji przez uzytkownika programu
            if (Oknomessage == DialogResult.Yes)
            {//odszukanie formularza glownego Kokpit w OpenForms
                foreach (Form Formularz in Application.OpenForms)
                {//ukrycie biezacego formularza
                    this.Hide();
                    //odslniecie znalezionego formularza glownego
                    Formularz.Show();
                    //bezwarunkowe wyjscie z metody obslugi zdarzenia
                    return;
                }
                //gdy jestesmy tutaj, to jest to sytuacja awaryjna
                //wyswietlenie komunikatu o awarii
                MessageBox.Show("UWAGA: wystąpiła awaria w działaniu programu i program musi zostać zamknięty", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.ExitThread();
            }
            else
            {//skasowanie zdarzenia FormClosing
                e.Cancel = true;
            }
        }

        private void JKtimer_Tick(object sender, EventArgs e)
        {
            KatObrotu = 5F;
            for (int i = 0; i < LBG.Count; i++)
                LBG[i].Obroc_i_Wykresl(JKpbRysownica, Rysownica, KatObrotu);
            Refresh();
        }

        private void JKbtnDodajNowąBG_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();
            //sprawdza czy użytkownik ustalił punkt dla rysowania bryły
            if (PunktLokalizacjiBryly.X == -1)
            { //nie została wybrana lokalizacja wykreślenia bryły
                errorProvider1.SetError(JKbtnDodajNowąBG, "Musisz ustalić lokalizację (położenie) bryły (środka jej podstawy), klikając myszą dowolny punkt powierzchni graficznej: Rysownicy!");
                return;
            }
            else
            {
                using (SolidBrush Pędzel = new SolidBrush(JKpbRysownica.BackColor))
                    Rysownica.FillEllipse(Pędzel, PunktLokalizacjiBryly.X - PromienPunktuLokalizacji, PunktLokalizacjiBryly.Y - PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji);
                int PromieńBryły = JKtrbPromienBryly.Value;
                int WysokośćBryły = JKtrbWysokoscBryly.Value;
                int StopieńWielokątaBryły = (int)JKnumStopieńWielokąta.Value;
                float KątPochyleniaBryły = JKtrbKątPochylenia.Value;
                int WspółrzędnaXpodłogiBryły = PunktLokalizacjiBryly.X;
                int WspółrzędnaYpodłogiBryły = PunktLokalizacjiBryly.Y;
                int WspolrzednaXsufituBryły = PunktLokalizacjiBryly.X;
                int WspolrzednaYsufituBryły = PunktLokalizacjiBryly.Y;
                Color KolorLinii = JKbtnKolorLinii.BackColor;
                DashStyle StylLinii;
                switch (JKcmbStylLinii.SelectedIndex)
                {
                    case 0:
                        StylLinii = DashStyle.Solid; break;
                    case 1:
                        StylLinii = DashStyle.Dash; break;
                    case 2:
                        StylLinii = DashStyle.Dot; break;
                    case 3:
                        StylLinii = DashStyle.DashDot; break;
                    case 4:
                        StylLinii = DashStyle.DashDotDot; break;
                    default:
                        MessageBox.Show("UWAGA: odczytano nieznany styl linii!");

                        StylLinii = DashStyle.Solid;
                        break;
                }
                float GrubośćLinii = JKtrbGruboscLinii.Value;
                switch (JKcmbBryłyGeometryczne.SelectedItem)
                {
                    case "Graniastosłup":
                        Graniastoslup graniastoslup = new Graniastoslup(PromieńBryły, WysokośćBryły, StopieńWielokątaBryły, WspółrzędnaXpodłogiBryły, WspółrzędnaYpodłogiBryły, WspolrzednaXsufituBryły, WspolrzednaYsufituBryły, KolorLinii, StylLinii, GrubośćLinii);
                        LBG.Add(graniastoslup); LBG[LBG.Count - 1].Wykresl(Rysownica);
                        break;
                    case "Ostrosłup":
                        Ostroslup ostroslup = new Ostroslup(PromieńBryły, WysokośćBryły, StopieńWielokątaBryły, WspółrzędnaXpodłogiBryły, WspółrzędnaYpodłogiBryły, KolorLinii, StylLinii, GrubośćLinii);
                        LBG.Add(ostroslup); LBG[LBG.Count - 1].Wykresl(Rysownica);
                        break;
                    case "Graniastosłup pochyły":
                        GraniastoslupPochyly graniastosluppochyly = new GraniastoslupPochyly(PromieńBryły, WysokośćBryły, StopieńWielokątaBryły, WspółrzędnaXpodłogiBryły, WspółrzędnaYpodłogiBryły, WspolrzednaXsufituBryły, WspolrzednaYsufituBryły, KątPochyleniaBryły, KolorLinii, StylLinii, GrubośćLinii);
                        LBG.Add(graniastosluppochyly); LBG[LBG.Count - 1].Wykresl(Rysownica);
                        break;
                    default:
                        MessageBox.Show("Nie została wybrana żadna bryła! Wybierz ją w kontrolce ComboBox(jest ona w lewym górnym narożniku Twojego formularza)");
                        break;
                }
            }
            JKpbRysownica.Refresh();
        }

        private void JKpbRysownica_MouseClick(object sender, MouseEventArgs e)
        {
            Point PunktLokalizacjiBryły = new Point(-1, -1);
            if (PunktLokalizacjiBryly.X != -1)
                using (SolidBrush Pędzel = new SolidBrush(JKpbRysownica.BackColor))
                    Rysownica.FillEllipse(Pędzel, PunktLokalizacjiBryly.X - PromienPunktuLokalizacji, PunktLokalizacjiBryly.Y - PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji);
            PunktLokalizacjiBryly = new Point(e.Location.X, e.Location.Y);
            Rysownica.FillEllipse(Brushes.Red, PunktLokalizacjiBryly.X - PromienPunktuLokalizacji, PunktLokalizacjiBryly.Y - PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji);
            JKpbRysownica.Refresh();
        }

        private void JKtrbWysokoscBryly_Scroll(object sender, EventArgs e)
        {
            JKlblWysokośćBryły.Text=JKtrbWysokoscBryly.Value.ToString();
        }

        private void JKtrbPromienBryly_Scroll(object sender, EventArgs e)
        {
            JKlblPromieńBG.Text=JKtrbPromienBryly.Value.ToString();
        }

        private void JKtrbGruboscLinii_Scroll(object sender, EventArgs e)
        {
            JKlblGrubośćLinii.Text=JKtrbGruboscLinii.Value.ToString();
        }

        private void JKtrbKątPochylenia_Scroll(object sender, EventArgs e)
        {
            JKlblKątPochylenia.Text = JKtrbKątPochylenia.Value.ToString();
        }

        private void JKbtnKolorLinii_Click(object sender, EventArgs e)
        {
            using (ColorDialog PaletaKolorów = new ColorDialog())
            {
                PaletaKolorów.Color = JKbtnKolorLinii.BackColor;
                if (PaletaKolorów.ShowDialog() == DialogResult.OK)
                {
                    JKbtnKolorLinii.BackColor = PaletaKolorów.Color;
                }
            }
        }

        private void JKbtnUsunPierwsza_Click(object sender, EventArgs e)
        {
            if (LBG.Count > 0)
            {
                LBG[0].Wymaz(JKpbRysownica, Rysownica);
                LBG.RemoveAt(0);
            }
            JKpbRysownica.Refresh();
        }

        private void JKbtnUsunOstatnia_Click(object sender, EventArgs e)
        {
            if (LBG.Count > 0)
            {
                LBG[LBG.Count-1].Wymaz(JKpbRysownica, Rysownica);
                LBG.RemoveAt(LBG.Count-1);
            }
            JKpbRysownica.Refresh();
        }

        private void JKbtnUsunWybrana_Click(object sender, EventArgs e)
        {
            int X = int.Parse(JKnumNumerBryly.Value.ToString());
            if (LBG.Count > 0 && X < LBG.Count())
            {
                LBG[X].Wymaz(JKpbRysownica, Rysownica);
                LBG.RemoveAt(X);
            }
            JKpbRysownica.Refresh();
        }

        private void JKbtnWylosujNowePolozenie_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int JKXn, JKYn;
            int JKXmax, JKYmax;
            JKXmax = JKpbRysownica.Width;
            JKYmax = JKpbRysownica.Height;
            for (int i = 0; i < LBG.Count; i++) 
            {
                JKXn = rnd.Next(50, JKXmax - 50);
                JKYn = rnd.Next(50, JKYmax - 50);
                LBG[i].PrzesunDoNowegoXY(JKpbRysownica, Rysownica, JKXn, JKYn);
            }
            JKpbRysownica.Refresh();
        }

        private void JKbtnSlajderPokazu_Click(object sender, EventArgs e)
        {
            JKbtnSlajderPokazu.Enabled= false;
                if (LBG.Count > 0)
                {
                    Rysownica.Clear(JKpbRysownica.BackColor);
                    if (JKrdbObjetosc.Checked)
                        LBG.Sort((bryla1, bryla2) => bryla1.ObjetoscBryly.CompareTo(bryla2.ObjetoscBryly));
                    else if (JKrdbPolePowierzchni.Checked)
                        LBG.Sort((bryla1, bryla2) => bryla1.PowierzchniaBryly.CompareTo(bryla2.PowierzchniaBryly));
                    else
                        LBG.Sort((bryla1, bryla2) => bryla1.WysokoscBG.CompareTo(bryla2.WysokoscBG));
                    JKslajder.Tag = 0;
                    JKslajder.Enabled = true;
                }
            if (JKrdbPrzyciskowy.Checked)
            {
                JKslajder.Enabled= false;
                if (LBG.Count > 0)
                {
                    JKbtnPoprzedni.Enabled = true;
                    JKbtnNastepny.Enabled = true;
                    JKtxtN.Enabled = true;
                    JKlblN.Enabled = true;
                    JKtxtN.Text = JKn.ToString();
                    Rysownica.Clear(JKpbRysownica.BackColor);
                    if (JKrdbObjetosc.Checked)
                        LBG.Sort((bryla1, bryla2) => bryla1.ObjetoscBryly.CompareTo(bryla2.ObjetoscBryly));
                    else if (JKrdbPolePowierzchni.Checked)
                        LBG.Sort((bryla1, bryla2) => bryla1.PowierzchniaBryly.CompareTo(bryla2.PowierzchniaBryly));
                    else
                        LBG.Sort((bryla1, bryla2) => bryla1.WysokoscBG.CompareTo(bryla2.WysokoscBG));
                    LBG[0].PrzesunDoNowegoXY(JKpbRysownica, Rysownica, JKpbRysownica.Width / 2, JKpbRysownica.Height / 2);
                }
            }
            if (JKrdbZegarowy.Checked)
            {
                JKbtnNastepny.Enabled= false;
                JKbtnPoprzedni.Enabled= false;
            }

            JKpbRysownica.Refresh();
        }

        private void JKbtnNastepny_Click(object sender, EventArgs e)
        {
            JKslajder.Enabled= false;
            Rysownica.Clear(JKpbRysownica.BackColor);
            if (JKn < (LBG.Count - 1))
                JKn++;
            else
                JKn = 0;

            JKtxtN.Text = JKn.ToString();
            LBG[JKn].PrzesunDoNowegoXY(JKpbRysownica, Rysownica, JKpbRysownica.Width / 2, JKpbRysownica.Height / 2);
            JKpbRysownica.Refresh();

        }

        private void JKbtnPoprzedni_Click(object sender, EventArgs e)
        {
            JKslajder.Enabled = false;
            JKtxtN.Text = JKn.ToString();
            Rysownica.Clear(JKpbRysownica.BackColor);
            if (JKn == 0)
                JKn = LBG.Count - 1;
            else
                JKn--;

            JKtxtN.Text = JKn.ToString();
            LBG[JKn].PrzesunDoNowegoXY(JKpbRysownica, Rysownica, JKpbRysownica.Width / 2, JKpbRysownica.Height / 2);
            JKpbRysownica.Refresh();
        }

        private void JKbtnWylaczSlajderPokazu_Click(object sender, EventArgs e)
        {
            JKbtnSlajderPokazu.Enabled = true;
            JKslajder.Enabled = false;
            JKn = 0;
            JKtxtN.Text = JKn.ToString();
            Rysownica.Clear(JKpbRysownica.BackColor);
            Random rnd = new Random();
            int Xn, Yn;
            int Xmax, Ymax; //rozmiar powierzchni
            // wyczyszczenie całej powierzchni graficznej
            // odczytanie rozmiaru powierzchni
            Xmax = JKpbRysownica.Width; Ymax = JKpbRysownica.Height;
            for (int i = 0; i < LBG.Count; i++)
            {// wylosowanie nowych współrzędnych nowego położenia i-tej figury geometrycznej
                Xn = rnd.Next(50, Xmax - 50);
                Yn = rnd.Next(50, Ymax - 50);
                LBG[i].PrzesunDoNowegoXY(JKpbRysownica, Rysownica, Xn, Yn);
            }
            JKpbRysownica.Refresh();
        }

        private void JKslajder_Tick(object sender, EventArgs e)
        {
            Rysownica.Clear(JKpbRysownica.BackColor);
            int JKXmax = JKpbRysownica.Width;
            int JKYmax = JKpbRysownica.Height;
            LBG[(int)JKslajder.Tag].PrzesunDoNowegoXY(JKpbRysownica, Rysownica, JKXmax / 2, JKYmax / 2);
            JKslajder.Tag = ((int)JKslajder.Tag + 1) % (LBG.Count);
            JKpbRysownica.Refresh();
        }

        private void JKbtnObrotWprawo_Click(object sender, EventArgs e)
        {
            JKbtnObrotWlewo.Enabled = true;
            JKbtnObrotWprawo.Enabled = false;
            JKtimer.Enabled = true;
        }

        private void JKbtnObrotWlewo_Click(object sender, EventArgs e)
        {
            JKbtnObrotWprawo.Enabled = true;
            JKtimer.Enabled = false;
        }
    }
}

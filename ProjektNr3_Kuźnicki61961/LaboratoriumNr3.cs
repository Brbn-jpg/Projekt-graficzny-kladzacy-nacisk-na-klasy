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
using static ProjektNr3_Kuźnicki61961.BrylyGeometryczne;

namespace ProjektNr3_Kuźnicki61961
{
    public partial class LaboratoriumNr3 : Form
    {
        //deklaracje pomocnicze
        float KatProsty = 90.0f;
        const int PromienPunktuLokalizacji = 2;
        Point PunktLokalizacjiBryly = new Point(-1, -1);
        Graphics Rysownica;
        List<BrylaAbstrakcyjna> LBG = new List<BrylaAbstrakcyjna>();
        public int n = 0;
        public static LaboratoriumNr3 UchwytFormularza1;

        public LaboratoriumNr3()
        {
            InitializeComponent();
            //lokalizacja i zwymiarowanie formualarza i kontrolki PictureBox
            //utworzenie Bitmapy
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            //utowrzenie egzemplarza powierzchni graficznej na Bitmapie
            Rysownica = Graphics.FromImage(pbRysownica.Image);
        }

        private void pbRysownica_MouseClick(object sender, MouseEventArgs e)
        {
            //sprawdzenie, czy to jest nowa lokalizacja dla dodawanej BG
            if (PunktLokalizacjiBryly.X != -1)
            {
                //usunięcie poprzedniej lokalizacji
                using (SolidBrush Pedzel = new SolidBrush(pbRysownica.BackColor))
                {
                    //wymazanie poprzedniego położenia punktu lokalizacji
                    Rysownica.FillEllipse(Pedzel, PunktLokalizacjiBryly.X - PromienPunktuLokalizacji, PunktLokalizacjiBryly.Y - PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji);
                }
            }
            //przechowanie nowego punktu lokalizacji BG
            PunktLokalizacjiBryly.X = e.X;
            PunktLokalizacjiBryly.Y = e.Y;
            //wykreślenie nowego punktu BG
            using (SolidBrush PedzelN = new SolidBrush(Color.Red))
                //wykreślenie punktu nowej lokalizacji BG
                Rysownica.FillEllipse(PedzelN, PunktLokalizacjiBryly.X - PromienPunktuLokalizacji, PunktLokalizacjiBryly.Y - PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji, 2 * PromienPunktuLokalizacji);
        }

        private void btnDodajNowąBG_Click(object sender, EventArgs e)
        {
            int PromieńBryły = trbPromienBryly.Value;
            int WysokośćBryły = trbWysokoscBryly.Value;
            int StopieńWielokątaBryły = (int)numStopieńWielokąta.Value;
            float KątPochyleniaBryły = KatProsty;
            int WspółrzędnaXpodłogiBryły = PunktLokalizacjiBryly.X;
            int WspółrzędnaYpodłogiBryły = PunktLokalizacjiBryly.Y;
            // zgaszenie kontrolki ErrorProvider
            errorProvider1.Dispose();
            // sprawdzenie czy została wybrana lokalizacja dla Kuli
            if (PunktLokalizacjiBryly.X == -1)
            {
                errorProvider1.SetError(btnDodajNowąBG, "ERROR: Musisz wybrać (kliknięciem) punkt lokalizacji Kuli na Rysownicy");
                return;
            }
            // usunięcie pomocniczego punktu lokalizacji Kuli
            using (SolidBrush Pedzel = new SolidBrush(pbRysownica.BackColor))
                Rysownica.FillEllipse(Pedzel, PunktLokalizacjiBryly.X - PromienPunktuLokalizacji, PunktLokalizacjiBryly.Y - PromienPunktuLokalizacji, 2.0f * PromienPunktuLokalizacji, 2.0f * PromienPunktuLokalizacji);
            // deklaracje pomocnicze dla atrybutów wybranej bryły
            int WysokoscBryly = trbWysokoscBryly.Value;
            int PromienBryly = trbPromienBryly.Value;
            int StopienWielokataBryly = (int)numStopieńWielokąta.Value;
            int XsP = PunktLokalizacjiBryly.X;
            int YsP = PunktLokalizacjiBryly.Y;
            Color KolorLinii = btnKolorLinii.BackColor;
            DashStyle StylLinii;
            // odczytanie wybranego stylu linii w kontrolce ComboBox
            switch (cmbStylLinii.SelectedIndex)
            {
                case 0:
                    StylLinii = DashStyle.Solid;
                    break;
                case 1:
                    StylLinii = DashStyle.Dash;
                    break;
                case 2:
                    StylLinii = DashStyle.Dot;
                    break;
                case 3:
                    StylLinii = DashStyle.DashDot;
                    break;
                case 4:
                    StylLinii = DashStyle.DashDotDot;
                    break;
                default:
                    StylLinii = DashStyle.Solid;
                    MessageBox.Show("UWAGA: został rozpoznany nieznany typ linii");
                    break;
            }
            float GruboscLinii = trbGruboscLinii.Value;
            // anulowanie wybranej lokalizacji dla bryły
            PunktLokalizacjiBryly.X = -1;
            PunktLokalizacjiBryly.Y = -1;
            // rozpoznanie wybranej bryły
            switch (cmbBryłyGeometryczne.SelectedItem)
            {
                case "Walec":
                    Walec walec = new Walec(PromienBryly, WysokoscBryly, StopienWielokataBryly, WspółrzędnaXpodłogiBryły, WspółrzędnaYpodłogiBryły, KolorLinii, StylLinii, GruboscLinii);
                    LBG.Add(walec); LBG[LBG.Count - 1].Wykresl(Rysownica);
                    break;
                case "Stożek":
                    break;
                case "Kula":
                    Kula kula = new Kula(PromienBryly, StopienWielokataBryly, XsP, YsP, KolorLinii, StylLinii, GruboscLinii);
                    // dodanie egemplarza Kuli dla listy LBG
                    LBG.Add(kula);
                    LBG[LBG.Count - 1].Wykresl(Rysownica);
                    break;
                default:
                    MessageBox.Show("UWAGA: wybrana bryła nie jest jeszcze zaimplementowana");
                    break;
            }
            // odświeżenie powierzchni grafcznej
            pbRysownica.Refresh();
            // uaktywnienie zegara
            ZegarObrotów.Enabled = false;
            // uaktywnienie (lub nie!) INNYCH KONTROLEK
        }

        private void LaboratoriumNr3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult OknoMessage = MessageBox.Show("Czy chcesz zamknąć bieżący formularz i przejść do formularza głównego? (Utracisz niezapisane dane w bieżącym formularzu). Samoocena Laboratorium Nr3: 5, ponieważ zostały zaimplementowane wszystkie funkcje z laboratoriów.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OknoMessage == DialogResult.Yes)
            {
                foreach (Form Formularz in Application.OpenForms)
                    if (Formularz.Name == "KokpitProjektuNr3")
                    {
                        this.Hide();
                        Formularz.Show();
                        return;
                    }
                MessageBox.Show("AWARIA: 'ktoś' usunął egzemplarz formularza głównego i program nie może działać dalej!!!", this.Text);
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }

        private void btnKolorLinii_Click(object sender, EventArgs e)
        {
            using (ColorDialog PaletaKolorów = new ColorDialog())
            {
                PaletaKolorów.Color = btnKolorLinii.BackColor;
                if (PaletaKolorów.ShowDialog() == DialogResult.OK)
                {
                    btnKolorLinii.BackColor = PaletaKolorów.Color;
                }
            }
        }

        private void ZegarObrotów_Tick(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            LBG[(int)ZegarObrotów.Tag].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xmax / 2, Ymax / 2);
            ZegarObrotów.Tag = ((int)ZegarObrotów.Tag + 1) % (LBG.Count);
            pbRysownica.Refresh();
        }

        private void btnWylaczSlajderPokazu_Click(object sender, EventArgs e)
        {
            btnSlajderPokazu.Enabled = true;
            ZegarObrotów.Enabled = false;
            n = 0;
            txtN.Text = n.ToString();
            Rysownica.Clear(pbRysownica.BackColor);
            Random rnd = new Random();
            int Xn, Yn;
            int Xmax, Ymax; //rozmiar powierzchni
            // wyczyszczenie całej powierzchni graficznej
            // odczytanie rozmiaru powierzchni
            Xmax = pbRysownica.Width; Ymax = pbRysownica.Height;
            for (int i = 0; i < LBG.Count; i++)
            {// wylosowanie nowych współrzędnych nowego położenia i-tej figury geometrycznej
                Xn = rnd.Next(50, Xmax - 50);
                Yn = rnd.Next(50, Ymax - 50);
                LBG[i].PrzesunDoNowegoXY(pbRysownica, Rysownica, Xn, Yn);
            }
            pbRysownica.Refresh();
        }

        private void btnSlajderPokazu_Click(object sender, EventArgs e)
        {
            btnSlajderPokazu.Enabled = false;
            if (LBG.Count > 0)
            {
                Rysownica.Clear(pbRysownica.BackColor);
                if (rdbObjetosc.Checked)
                    LBG.Sort((bryla1, bryla2) => bryla1.ObjetoscBryly.CompareTo(bryla2.ObjetoscBryly));
                else if (rdbPolePowierzchni.Checked)
                    LBG.Sort((bryla1, bryla2) => bryla1.PowierzchniaBryly.CompareTo(bryla2.PowierzchniaBryly));
                else
                    LBG.Sort((bryla1, bryla2) => bryla1.WysokoscBG.CompareTo(bryla2.WysokoscBG));
                ZegarObrotów.Tag = 0;
                ZegarObrotów.Enabled = true;
            }
            if (rdbPrzyciskowy.Checked)
            {
                ZegarObrotów.Enabled = false;
                if (LBG.Count > 0)
                {
                    btnPoprzedni.Enabled = true;
                    btnNastepny.Enabled = true;
                    txtN.Enabled = true;
                    txtN.Text = n.ToString();
                    Rysownica.Clear(pbRysownica.BackColor);
                    if (rdbObjetosc.Checked)
                        LBG.Sort((bryla1, bryla2) => bryla1.ObjetoscBryly.CompareTo(bryla2.ObjetoscBryly));
                    else if (rdbPolePowierzchni.Checked)
                        LBG.Sort((bryla1, bryla2) => bryla1.PowierzchniaBryly.CompareTo(bryla2.PowierzchniaBryly));
                    else
                        LBG.Sort((bryla1, bryla2) => bryla1.WysokoscBG.CompareTo(bryla2.WysokoscBG));
                    LBG[0].PrzesunDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
                }
            }
            if (rdbZegarowy.Checked)
            {
                btnNastepny.Enabled = false;
                btnPoprzedni.Enabled = false;
            }

            pbRysownica.Refresh();
        }

        private void btnPoprzedni_Click(object sender, EventArgs e)
        {
            ZegarObrotów.Enabled = false;
            txtN.Text = n.ToString();
            Rysownica.Clear(pbRysownica.BackColor);
            if (n == 0)
                n = LBG.Count - 1;
            else
                n--;

            txtN.Text = n.ToString();
            LBG[n].PrzesunDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
            pbRysownica.Refresh();
        }

        private void btnNastepny_Click(object sender, EventArgs e)
        {
            ZegarObrotów.Enabled = false;
            Rysownica.Clear(pbRysownica.BackColor);
            if (n < (LBG.Count - 1))
                n++;
            else
                n = 0;

            txtN.Text = n.ToString();
            LBG[n].PrzesunDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
            pbRysownica.Refresh();

        }
    }
}

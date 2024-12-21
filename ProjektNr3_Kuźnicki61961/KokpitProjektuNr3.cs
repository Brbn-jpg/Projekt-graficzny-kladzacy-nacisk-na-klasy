using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNr3_Kuźnicki61961
{
    public partial class KokpitProjektuNr3 : Form
    {
        public KokpitProjektuNr3()
        {
            InitializeComponent();
        }

        private void btnLaboratoriumNr3_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
                if (Formularz.Name == "LaboratoriumNr3")
                {
                    this.Hide();
                    Formularz.Show();
                    return;
                }
            LaboratoriumNr3 FormLaboratoriumNr3 = new LaboratoriumNr3();
            this.Hide();
            FormLaboratoriumNr3.Show();
        }

        private void btnProjektIndywidualnyNr3_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
                if (Formularz.Name == "ProjektIndywidualnyNr3")
                {
                    this.Hide();
                    Formularz.Show();
                    return;
                }
            ProjektIndywidualnyNr3 FormProjektIndywidualnyNr3 = new ProjektIndywidualnyNr3();
            this.Hide();
            FormProjektIndywidualnyNr3.Show();
        }

        private void KokpitProjektuNr3_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*utworzenie okna dialogowego i jego wyswietlenie dla spytania uzytkownika, czy na pewno
            chce zamknac formularz i zakonczyc dzialanie programu*/
            DialogResult Oknomessage = MessageBox.Show("Czy na pewno chcesz zamknąć formularz główny i zakończyć działanie programu?", this.Text, MessageBoxButtons.YesNo);
            //sprawdzenie podjetej decyzji przez uzytkownika programu
            if (Oknomessage == DialogResult.Yes)
            {//zamkniecie wszystkich formularzy i zakonczenie dzialania programu
                Application.ExitThread();
            }
            else
            {//skasowanie zdarzenia FormClosing
                e.Cancel = true;
            }
        }
    }
}

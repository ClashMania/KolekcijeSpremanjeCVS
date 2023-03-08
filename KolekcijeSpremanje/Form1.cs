using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolekcijeSpremanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            List<Osoba> listaOsoba = new List<Osoba>();

            try
            {
                Osoba osoba = new Osoba(txtUnosIme.Text, txtUnosPrezime.Text, txtUnosEmail.Text, Convert.ToInt16(txtUnosGodRod.Text));
                txtUnosIme.Clear();
                txtUnosPrezime.Clear();
                txtUnosGodRod.Clear();
                txtUnosEmail.Clear();

                DialogResult upit = MessageBox.Show("Želite li unesti još podataka?", "Upit",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (upit)
                {
                    case DialogResult.Yes:
                        {
                            listaOsoba.Add(osoba);
                            break;
                        }

                    case DialogResult.No:
                        {
                            listaOsoba.Add(osoba);
                            break;
                        }

                }
            }

            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogrešan unos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
    }
}

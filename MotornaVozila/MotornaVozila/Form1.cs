using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotornaVozila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MotornaVozila.Entiteti.Zaposleni zaposleni = s.Load<Entiteti.Zaposleni>(24);
                MessageBox.Show(zaposleni.ime);

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
                return;
            }
        }
    }
}

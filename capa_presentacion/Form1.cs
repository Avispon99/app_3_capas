using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion
{
    public partial class Form1 : Form
    {
        Conexion con = new Conexion();
        proceso pr = new proceso();
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pr.recept(Aut.Text, documento.Text, nombres.Text, telefono.Text, carg.Text, correo.Text, perf.Text, usu.Text, clav.Text, est.Text));
            con.CargarBase(dataGrid);
            MessageBox.Show(pr.resp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.CargarBase(dataGrid);
        }
    }
}

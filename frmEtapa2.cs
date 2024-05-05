using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace pryPerezEtapa2
{
    
    public partial class frmEtapa2 : Form
    {

        clsVehiculo objVehiculo;
        public frmEtapa2()
        {
            InitializeComponent();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {

            objVehiculo = new clsVehiculo();

            objVehiculo.crearVehiculo(pictureBox1, Properties.Resources.auto);

        
        }


    }
}
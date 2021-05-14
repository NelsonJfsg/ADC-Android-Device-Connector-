using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADC__Android_Device_Connector_.Layouts
{
    public partial class NewDevice : Form
    {

        //Variables
        String nombre, ip;
        String tabla = "devices";
        private String txtNombre = "Ingrese el nombre del dispositivo.";
        private String txtIp = "Ingrese la ip del dispositivo.";
        DataGridView tDGV;

        //setDGV
        public DataGridView setDGV(DataGridView dGV) {
            tDGV = dGV;
            return dGV;
        }

        //Objetos 
        Home home = new Home();

        //Constructor
        public NewDevice() {
            InitializeComponent();
        }
    }
}

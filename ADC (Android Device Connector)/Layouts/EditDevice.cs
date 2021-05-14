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
    public partial class EditDevice : Form
    {

        //Variables
        public String nombre, ip;
        public String id;
        String tabla = "devices";
        private String txtNombre = "Ingrese el nombre del dispositivo.";
        private String txtIp = "Ingrese la ip del dispositivo.";
        DataGridView tDGV;

        //setDGV
        public DataGridView setDGV(DataGridView dGV) {
            tDGV = dGV;
            return dGV;
        }

        //Constructor
        public EditDevice() {
            InitializeComponent();
        }
    }
}

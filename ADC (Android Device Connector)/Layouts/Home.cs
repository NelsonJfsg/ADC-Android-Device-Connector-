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
    public partial class Home : Form
    {
        public Home() {
            InitializeComponent();
        }

        //Proceso al iniciar el Form.
        private void Home_Load(object sender, EventArgs e) {

        }


        //Evento click para cambiar al layout de edicion.
        private void pbEditDevice_Click(object sender, EventArgs e) {
            
            EditDevice editDevice = new EditDevice();
            editDevice.setDGV(dataGVDevices);

            if(dataGVDevices.CurrentRow != null) {
                String id = dataGVDevices.CurrentRow.Cells["iddevices"].Value.ToString();
                editDevice.id = id;
                editDevice.Show();
            } else {
                MessageBox.Show("Seleccione un dispositivo");
            }

        }

        //Evento click para cambiar al layout de registro.
        private void pbNuevoDispositivo_Click(object sender, EventArgs e) {
            NewDevice newDevice = new NewDevice();
            newDevice.setDGV(dataGVDevices);
            newDevice.Show();
        }
    }
}

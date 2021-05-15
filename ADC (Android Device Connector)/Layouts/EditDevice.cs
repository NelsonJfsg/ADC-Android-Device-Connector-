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
        //Objetos
        DataBase.Device device = new DataBase.Device();


        //setDGV
        public DataGridView setDGV(DataGridView dGV) {
            tDGV = dGV;
            return dGV;
        }

        private void butEditDevice_Click(object sender, EventArgs e) {
            //Variables
            nombre = tbNombre.Text;
            ip = tbIp.Text;

            device.editarDispositivo(id, nombre, ip, tbNombre, tbIp);
            MessageBox.Show("Ya pase aqui");
            device.cargarDispositivos(tDGV, tabla);
            this.Dispose(); 
        }

        private void EditDevice_Load(object sender, EventArgs e) {
            device.fillData(id, tbNombre, tbIp);
            this.ActiveControl = pbIcon;
            tbNombre.ForeColor = Color.White;
            tbIp.ForeColor = Color.White;
        }

        private void tbNombre_Leave(object sender, EventArgs e) {
            if(tbNombre.Text == "") {
                reinicarTexto(tbNombre, txtNombre);
            }
        }

        //Constructor
        public EditDevice() {
            InitializeComponent();
        }

        private void tbIp_Leave(object sender, EventArgs e) {
            if(tbIp.Text == "") {
                reinicarTexto(tbIp, txtIp);
            }
        }


        //Metodo para reinicar los textos por defecto.
        public void reinicarTexto(TextBox tb, String text) {

            //Verificamos que el TB esté vacio.
            if(tb.Text == "") {

                tb.ForeColor = (Color.DarkGray); //Cambiamos el color del TB
                tb.Text = (text); //Reiniciamos el texto por defecto.

            }

        }

        private void tbNombre_Click(object sender, EventArgs e) {
            cambiarColorTexto(tbNombre, txtNombre);
        }

        private void tbIp_Click(object sender, EventArgs e) {
            cambiarColorTexto(tbIp, txtIp);
        }

        private void tbIp_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {

        }

        private void pbIcon_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {

            //Verificamos si se preciono la tecla TAB.
            if(e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbNombre, txtNombre);
            }
            
        }

        private void butEditDevice_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {

            //Verificamos si se preciono la tecla TAB.
            if(e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbNombre, txtNombre);
            }

        }

        private void tbNombre_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            //Verificamos si se preciono la tecla TAB.
            if(e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbIp, txtIp);
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e) {
            reinicarTexto(tbNombre, txtNombre);
        }

        private void tbIp_TextChanged(object sender, EventArgs e) {
            reinicarTexto(tbIp, txtIp);
        }

        //Metodo para cambiar el color y limpiar el TB.
        public void cambiarColorTexto(TextBox tb, String text) {

            //Verificamos que los textos sean iguales.
            if(tb.Text == text) {

                tb.Text = (""); //Limpiamos el TB.
                tb.ForeColor = Color.White; //Cambiamos el color de la leta.

            }

        }

    }
}

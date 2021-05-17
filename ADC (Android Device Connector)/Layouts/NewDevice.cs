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
        DataBase.Device device = new DataBase.Device();
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

        //Evento click para añadir un dispositivo.
        private void butDevices_Click(object sender, EventArgs e) {
            
            //Variables
            nombre = tbNombre.Text;
            ip = tbIp.Text;

            device.añadirDispositivio(nombre, ip); //Añadimos el dispositivo.
            device.cargarDispositivos(tDGV, tabla);
            this.Dispose(); //Cerramos la ventana
        }

        //Evento para saber que tecla se presiono.
        private void pbImage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            //Verificamos si se preciono la tecla TAB.
            if(e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbNombre, txtNombre);
            }
        }

        //Constructor
        public NewDevice() {
            InitializeComponent();
        }

        //Evento click para el TB nombre.
        private void tbNombre_Click(object sender, EventArgs e) {
            cambiarColorTexto(tbNombre, txtNombre);
        }

        //Metodo para cambiar el color y limpiar el TB.
        public void cambiarColorTexto(TextBox tb, String text) {

            //Verificamos que los textos sean iguales.
            if(tb.Text == text) {

                tb.Text = (""); //Limpiamos el TB.
                tb.ForeColor = Color.White; //Cambiamos el color de la leta.

            }

        }

        //Evento click para el TB ip.
        private void tbIp_Click(object sender, EventArgs e) {
            cambiarColorTexto(tbIp, txtIp);
        }

        //Evento para saber que tecla se presiono.
        private void tbNombre_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            
            //Verificamos si se preciono la tecla TAB.
            if(e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbIp, txtIp);
            }
        }

        //Evento para saber que tecla se presiono.
        private void butDevices_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            //Verificamos si se preciono la tecla TAB.
            if(e.KeyData == Keys.Tab) {
                cambiarColorTexto(tbNombre, txtNombre);
            }
        }

        //Evento leave para reinciar los textos.
        private void tbNombre_Leave(object sender, EventArgs e) {
            reinicarTexto(tbNombre, txtNombre);
        }

        //Evento leave para reiniciar los textos.
        private void tbIp_Leave(object sender, EventArgs e) {
            reinicarTexto(tbIp, txtIp);
        }

        //Metodo para reinicar los textos por defecto.
        public void reinicarTexto(TextBox tb, String text) {

            //Verificamos que el TB esté vacio.
            if(tb.Text == "") {

                tb.ForeColor = (Color.DarkGray); //Cambiamos el color del TB
                tb.Text = (text); //Reiniciamos el texto por defecto.

            }

        }

    }
}

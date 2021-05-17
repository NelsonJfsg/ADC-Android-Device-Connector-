using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADC__Android_Device_Connector_;

namespace ADC__Android_Device_Connector_.Layouts
{
    public partial class Home : Form
    {

        //Variables
        String salida = null;
        Scrcpy.Scrcpy scrcpy = new Scrcpy.Scrcpy();
        DataBase.Device device = new DataBase.Device();
        Cmd.Cmd cmd = new Cmd.Cmd();

        //Variables base de datos
        String tabla = "devices";
        String s = null;
        String ip;
        String path;
        String argumentos;
        String resolucion;

        //Comandos para el Scrcpy.
        String alwaysOnTop = "--always-on-top ";
        String noControl = "--no-control ";
        String renderExpiredFrames = "--render-expired-frames ";
        String turnScreenOff = "--turn-screen-off ";
        String showTouches = "--show-touches ";
        String stayAwake = "--stay-awake ";

        //Constructor.
        public Home() {
            InitializeComponent();
        }

        //Proceso al iniciar el Form.
        private void Home_Load(object sender, EventArgs e) {

            //Variables.
            String query = "CREATE TABLE IF NOT EXISTS Scrcpy(idrutaScrcpy INTEGER PRIMARY KEY, rutaScrcpy TEXT NOT NULL)";

            //Conexion con la base de datos.
            SQLiteConnection con = new SQLiteConnection("Data Source=adc.db;Version=3;");
            con.Open();

            //Aplicar comando para subir los datos.
            SQLiteCommand comando = new SQLiteCommand(query, con);
            comando.ExecuteNonQuery();
            con.Close();
            
            //Variables.
            String que = "CREATE TABLE IF NOT EXISTS devices(iddevice INTEGER PRIMARY KEY AUTOINCREMENT, nombre TEXT NOT NULL, direccionIp TEXT NOT NULL)";

            con.Open();

            //Aplicar comando para subir los datos.
            SQLiteCommand com = new SQLiteCommand(que, con);
            com.ExecuteNonQuery();
            con.Close();
            //con.Dispose();
            
            //Estilo de grafico para la tabla.
            dataGVDevices.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31, 31, 31);
            dataGVDevices.GridColor = Color.FromArgb(41, 41, 41);
            dataGVDevices.ForeColor = Color.White;
            dataGVDevices.BackgroundColor = Color.FromArgb(21, 21, 21);
            dataGVDevices.DefaultCellStyle.BackColor = Color.FromArgb(21, 21, 21);
            dataGVDevices.AllowUserToResizeColumns = false;
            dataGVDevices.AllowUserToResizeRows = false;

            device.cargarDispositivos(dataGVDevices, tabla);

            DataGridViewColumn ColumnNombre = dataGVDevices.Columns[1]; //guarda la primer columna.  
            ColumnNombre.HeaderText = "Nombre del dispositivo.";

            DataGridViewColumn ColumnIp = dataGVDevices.Columns[2]; //guarda la primer columna.  
            ColumnIp.HeaderText = "Direccion ip.";


        }

        //Evento click para cambiar al layout de edicion.
        private void pbEditDevice_Click(object sender, EventArgs e) {
            
            EditDevice editDevice = new EditDevice();
            editDevice.setDGV(dataGVDevices);

            //Verificamos que este seleccionado algun dispositivo.
            if(dataGVDevices.CurrentRow != null) {
                String id = dataGVDevices.CurrentRow.Cells["iddevice"].Value.ToString();
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

        //Evento click para el boton de la ruta.
        private void butPath_Click(object sender, EventArgs e) {

            //Abrirmos el layout para elegir la ruta.
            using(var fd = new FolderBrowserDialog()) {

                //Verificamos que se guarde correctamente la ruta.
                if(fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath)) {

                    //Verificamos si ya existe una ruta o es nueva.
                    if(scrcpy.consultarRuta() != null) {
                        scrcpy.editarRuta(fd.SelectedPath.ToString());
                    } else {
                        scrcpy.registrarRuta(fd.SelectedPath.ToString());    
                    }

                }
            }

        }

        //Evento click para el boton conectar.
        private void butConnect_Click(object sender, EventArgs e) {

            //Seleccionamos la ip.
            ip = dataGVDevices.CurrentRow.Cells["direccionIp"].Value.ToString();

            //Objeto para declarar la tarea.
            Process task = new Process();

            cmd.cambiarRuta(task); //Posicionamos la terminal en la ruta del scrcpy.

            //Comandos a ejecutar.
            task.StandardInput.WriteLine("adb tcpip 5555");
            task.StandardInput.WriteLine("adb connect " + ip);

            cmd.doneTask(task, rtbCMD); //Finalizamos la tarea.
        }

        //Evento click para ver los dispositivos conectados.
        private void butDevices_Click(object sender, EventArgs e) {

            //Objeto para declarar la tarea.
            Process task = new Process();
            
            cmd.cambiarRuta(task); //Posicionamos la terminal en la ruta del scrcpy.

            //Comandos a ejecutar.
            task.StandardInput.WriteLine("adb devices");
            
            cmd.doneTask(task, rtbCMD); //Finalizamos la tarea.
            
        }

        //Evento click para reiniciar las conexiones.
        private void butKillServer_Click(object sender, EventArgs e) {

            //Objeto para declarar la tarea.
            Process task = new Process();

            cmd.cambiarRuta(task); //Posicionamos la terminal en la ruta del scrcpy.

            //Comandos a ejecutar.
            task.StandardInput.WriteLine("adb kill-server");

            cmd.doneTask(task, rtbCMD); //Finalizamos la tarea.

        }

        //Evento click para limpiar el rtb.
        private void butClear_Click(object sender, EventArgs e) {

            rtbCMD.Text = "";
            
        }

        //Evento click para eliminar un dispositivo.
        private void pbEliminarDispositivo_Click(object sender, EventArgs e) {

            //Verificamos que haya un dispositivo seleccionado.
            if(dataGVDevices.CurrentRow != null) {
                String id = dataGVDevices.CurrentRow.Cells["iddevice"].Value.ToString();
                device.eliminarDispositivo(id);
                device.cargarDispositivos(dataGVDevices, tabla);
            } else {
                MessageBox.Show("Seleccione un dispositivo");
            }

        }

        //Evento click para iniciar la transmision de pantalla.
        private void butScreenMirror_Click(object sender, EventArgs e) {

            //Variables
            String verificado = null;

            //Buscamos la resolucion.
            foreach(RadioButton rb in gbResolucion.Controls) {
                if(rb.Checked) {

                    if(rb.Text == "Nativa") {
                        verificado = null;
                    } else {
                        verificado = "-m " + rb.Text + " ";
                    }
                }
            }

            if(verificado == null) {
                MessageBox.Show("Seleccione una resolucion.");
            } else {

                verificarResolucion(gbResolucion, argumentos);
                verificarOpciones(gbOpciones, argumentos);


                //Recuperamos la ruta donde está guardado el programa.
                path = scrcpy.consultarRuta();

                //Seleccionamos el dispositivo.
                ip = dataGVDevices.CurrentRow.Cells["direccionIp"].Value.ToString();

                //Comenzamos con el proceso.
                Process test = new Process();
                test.StartInfo.FileName = @path + "\\scrcpy.exe";
                test.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                test.StartInfo.UseShellExecute = false;

                if(cbDisableControl.Checked && cbScreenOff.Checked) {
                    MessageBox.Show("Modos no compatibles.");
                } else {

                    test.StartInfo.RedirectStandardOutput = false;
                    test.StartInfo.Arguments = resolucion + argumentos;
                    try {
                        test.Start();
                    } catch(Exception err) {
                        MessageBox.Show("Selecciona correctamente la ruta del programa Scrcpy.");
                    }
                }

                argumentos = null;
            }
            
        }

        //Metodo para verificar las opciones.
        public void verificarOpciones(GroupBox gb, String arg) {

            if(cbDisableControl.Checked && cbScreenOff.Checked) {

                MessageBox.Show("Modos no compatibles.");

            } else {

                foreach(CheckBox cn in gb.Controls) {

                    if(cn.Checked) {


                        if(cn.Text == "Fijar dispositivo.") {
                            arg = arg + alwaysOnTop;
                        }

                        if(cn.Text == "Desactivar control remoto.") {
                            arg = arg + noControl;
                        }

                        if(cn.Text == "No saltar frames.") {
                            arg = arg + renderExpiredFrames;
                        }

                        if(cn.Text == "Apagar pantalla.") {
                            arg = arg + turnScreenOff;
                        }

                        if(cn.Text == "Mostrar toques.") {
                            arg = arg + showTouches;
                        }

                        if(cn.Text == "Mantener pantalla encendida.") {
                            arg = arg + stayAwake;
                        }

                    }

                }

            }

            argumentos = argumentos + arg;

        }

        //Metodo para verificar la resolcuion.
        public void verificarResolucion(GroupBox gb, String args) {

            //Buscamos el la resolucion seleccionada.
            foreach(RadioButton rb in gb.Controls) {
                if(rb.Checked) {

                    if(rb.Text == "Nativa") {
                        args = null;
                    } else {
                        args = "-m " + rb.Text + " ";
                    }
                }

            }

            resolucion = args;

        }

    }
}

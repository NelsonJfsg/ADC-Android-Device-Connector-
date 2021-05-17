using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADC__Android_Device_Connector_.DataBase {
    class Device {

        //Variables
        public String id;
        public String nombre;
        public String ip;

        //Metodo para cargar los dispositivos en el DGV.
        public void cargarDispositivos(DataGridView dataGridView, String tabla) {

            //Variables.
            String query = "SELECT * FROM " + tabla + ";";

            //Conexion con la base de datos.
            SQLiteConnection con = new SQLiteConnection("Data Source=adc.db;Version=3;");
            con.Open();

            //Enlazamos la conexion.
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd); //Adapta los datos.
            DataTable dt = new DataTable(); //Convierte los datos en tabla
            da.Fill(dt); //Llena la tabla.

            dataGridView.DataSource = dt; //Asigna al DGV la fuente de datos.
            dataGridView.AllowUserToAddRows = false; //Desactva añadir una fila.
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.RowHeadersVisible = false;

            DataGridViewColumn Column = dataGridView.Columns[0]; //guarda la primer columna.  
            Column.Visible = false; //Evita que se muestre la primer columna.

            DataGridViewColumn columnNombre = dataGridView.Columns[1]; //Guardamos la tercer columna.
            columnNombre.Width = 200; //Tamaño del link.

            DataGridViewColumn cLink = dataGridView.Columns[2]; //Guardamos la tercer columna.
            cLink.Width = 405; //Tamaño del link.

            con.Close(); //Cerramos la conexion.

        }

        //Metodo para añadir dispositivos nuevos.
        public void añadirDispositivio(String nombre, String ip) {

            //Variables.
            String query = "INSERT INTO devices (nombre, direccionIp) VALUES ('" + nombre + "', '" + ip + "')";

            //Conexion con la base de datos.
            SQLiteConnection con = new SQLiteConnection("Data Source=adc.db;Version=3;");
            con.Open();

            try {

                //Aplicar comando para subir los datos.
                SQLiteCommand comando = new SQLiteCommand(query, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dispositivo registrado.");

            } catch(Exception er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                con.Close(); //Cerrar conexion con la base de datos.

            }
        }


        //Metodo para editar dispositivos.
        public void editarDispositivo(String thisId, String nombre, String ip, TextBox tbNombre, TextBox tbIp) {

            //Variables.
            int id = Int32.Parse(thisId);
            const string comillas = "\"";

            //Query
            String que = "UPDATE devices SET nombre = " + comillas + nombre  + comillas + ", direccionIp = " + comillas + ip  + comillas + " WHERE iddevice= " + id;

            //Conexion con la base de datos.
            SQLiteConnection con = new SQLiteConnection("Data Source=adc.db;Version=3;");
            con.Open();

            try {

                //Aplicar comando para subir los datos.
                SQLiteCommand comando = new SQLiteCommand(que, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dispositivo actualizado.");

            } catch(Exception er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                con.Close(); //Cerrar conexion con la base de datos.

            }
        }

        //Rellenar los campos en el layout de edicion.
        public void fillData(String id, TextBox tbNombre, TextBox tbIp) {

            //Variables.
            String query = ("SELECT * FROM devices WHERE iddevice= '" + id + "'");

            //Conexion con la base de datos.
            SQLiteConnection con = new SQLiteConnection("Data Source=adc.db;Version=3;");
            con.Open();

            //Aplicar comando para subir los datos.
            SQLiteCommand comando = new SQLiteCommand(query, con);
            comando.Connection = con;

            comando.CommandText = ("SELECT * FROM devices WHERE iddevice= '" + id + "'");

            SQLiteDataReader lec = comando.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if(lec.Read() == true) {

                tbNombre.Text = lec["nombre"].ToString();
                tbIp.Text = lec["direccionIp"].ToString();
                comando.Dispose();
                lec.Close();
                con.Close();
                
            } else {

                MessageBox.Show("No existe el dispositivo.");

            }
        }


        //Metodo para eliminar el dispositivo seleccionado.
        public void eliminarDispositivo(String id) {

            //Variables.
            String query = "DELETE FROM devices WHERE iddevice='" + id + "'";

            //Conexion con la base de datos.
            SQLiteConnection con = new SQLiteConnection("Data Source=adc.db;Version=3;");
            con.Open();

            try {

                //Aplicar comando para subir los datos.
                SQLiteCommand comando = new SQLiteCommand(query, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dispositivo eliminado.");

            } catch(Exception er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                con.Close(); //Cerrar conexion con la base de datos.

            }

            /*
            
            try {

                //Aplicar comando para subir los datos.
                MySqlCommand comando = new MySqlCommand(sql,conexionBd);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dispositivo eliminadao.");

            } catch (MySqlException er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                conexionBd.Close(); //Cerrar conexion con la base de datos.

            }
            */
        }

    }
}

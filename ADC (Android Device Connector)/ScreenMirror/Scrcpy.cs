using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADC__Android_Device_Connector_.Scrcpy {

    class Scrcpy {

        //Metodo para registrar la ruta
        public void registrarRuta(String ruta) {

            //Adaptamos el string para que funcione en la bd.
            //ruta = ruta.Replace(@"\", @"\\");

            //Variables.
            String query = "INSERT INTO Scrcpy (rutaScrcpy) VALUES ('" + ruta + "')";

            //Conexion con la base de datos.
            SQLiteConnection con = new SQLiteConnection("Data Source=adc.db;Version=3;");
            con.Open();

            try {

                //Aplicar comando para subir los datos.
                SQLiteCommand comando = new SQLiteCommand(query, con);
                comando.ExecuteNonQuery();
                MessageBox.Show(ruta);
                MessageBox.Show("Ruta registrada.");

            } catch(Exception err) {
                MessageBox.Show(err.ToString());
            } finally {
                con.Close();
            }
        }

        //Metodo para editar la ruta
        public void editarRuta(String ruta) {

            //Adaptamos el string para que funcione en la bd.
            //ruta = ruta.Replace(@"\", @"\\");

            //Variables.
            String query = "UPDATE Scrcpy SET rutaScrcpy= '" + ruta + "' WHERE idrutaScrcpy= " + 1;

            //Conexion con la base de datos.
            SQLiteConnection con = new SQLiteConnection("Data Source=adc.db;Version=3;");
            try {
                con.Open();
                //Aplicar comando para subir los datos.
                SQLiteCommand comando = new SQLiteCommand(query, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Ruta actualizada.");
                
            } catch(Exception er) {

                MessageBox.Show(er.Message); //Mensaje de error.

            } finally {

                con.Close(); //Cerrar conexion con la base de datos.

            }

        }

        //Metodo para consultar la ruta.
        public String consultarRuta() {

            //Variables
            String path;
            String query = "SELECT * FROM Scrcpy WHERE idrutaScrcpy= 1";

            //Conexion con la base de datos.
            SQLiteConnection con = new SQLiteConnection("Data Source=adc.db;Version=3;");
            con.Open();

            //Comando.
            SQLiteCommand comando = new SQLiteCommand(query, con);
            
            SQLiteDataReader lec = comando.ExecuteReader(); //Reader de la base de datos.

            //Condicion para ver si hay algun dato leido.
            if(lec.Read() == true) {
                path = lec["rutaScrcpy"].ToString();
                con.Close();
                
                return path;

            } else {

                MessageBox.Show("Seleccione la ruta del programa Scrcpy");
                con.Close();
                return null;
                

            }
            lec.Close();
        }












        /* SQLiteCommand com = new SQLiteCommand("SELECT * FROM Scrcpy WHERE idrutaScrcpy= '" + 1 + "'", con);
                            com.ExecuteNonQuery();

                            SQLiteDataReader lec = com.ExecuteReader(); //Reader de la base de datos.

                            //Condicion para ver si hay algun dato leido.
                            if(lec.Read() == true) {

                                String path = lec["rutaScrcpy"].ToString();

                                MessageBox.Show(path);
                            } else {

                                MessageBox.Show("Seleccione la ruta del programa Scrcpy");
                                //return null;

                            }
         */
    }
}

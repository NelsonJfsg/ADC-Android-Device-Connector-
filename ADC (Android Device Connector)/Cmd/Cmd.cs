using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADC__Android_Device_Connector_.Cmd {
    class Cmd {

        //Variables
        String ip = null;

        //Objetos
        Scrcpy.Scrcpy scrcpy = new Scrcpy.Scrcpy();

        //Metodo para cambiar la ruta del Scrcpy.
        public Process cambiarRuta(Process task) {

            task.StartInfo.FileName = "cmd.exe";
            task.StartInfo.CreateNoWindow = true;
            task.StartInfo.RedirectStandardInput = true;
            task.StartInfo.RedirectStandardOutput = true;
            task.StartInfo.UseShellExecute = false;
            task.Start();
            task.StandardInput.WriteLine("c:");
            task.StandardInput.WriteLine("cd " + scrcpy.consultarRuta());
            return task;

        }

        //Metodo para terminar la tarea.
        public void doneTask(Process task, RichTextBox rtbCMD) {

            task.StandardInput.Flush();
            task.StandardInput.Close();
            task.WaitForExit();

            rtbCMD.Text = task.StandardOutput.ReadToEnd();

        }

        //Metodo para conectar el dispositivo.
        public void connectDevice(DataGridView dataGV, RichTextBox rich, Process task) {

            //Seleccionamos el dispositivo.
            ip = dataGV.CurrentRow.Cells["direccionIp"].Value.ToString();
            
            cambiarRuta(task); //Cambiamos la ruta del Scrcpy

            ProcessStartInfo abrirPuerto = new ProcessStartInfo("adb", "tcpip 5555"); //Abrimos el puerto
            ProcessStartInfo conectarDispositivo = new ProcessStartInfo("adb", "connect " + ip); //Conectamos el dispositivo.

        }

    }
}

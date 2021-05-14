
namespace ADC__Android_Device_Connector_.Layouts
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lDispositivos = new System.Windows.Forms.Label();
            this.dataGVDevices = new System.Windows.Forms.DataGridView();
            this.butDevices = new System.Windows.Forms.Button();
            this.butConnect = new System.Windows.Forms.Button();
            this.butKillServer = new System.Windows.Forms.Button();
            this.butScreenMirror = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butPath = new System.Windows.Forms.Button();
            this.rtbCMD = new System.Windows.Forms.RichTextBox();
            this.lOpciones = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.cbScreenOn = new System.Windows.Forms.CheckBox();
            this.cbShowTouches = new System.Windows.Forms.CheckBox();
            this.cbScreenOff = new System.Windows.Forms.CheckBox();
            this.cbAllFps = new System.Windows.Forms.CheckBox();
            this.cbDisableControl = new System.Windows.Forms.CheckBox();
            this.cbAlwayOnTop = new System.Windows.Forms.CheckBox();
            this.gbResolucion = new System.Windows.Forms.GroupBox();
            this.rb240p = new System.Windows.Forms.RadioButton();
            this.rb480p = new System.Windows.Forms.RadioButton();
            this.rb720p = new System.Windows.Forms.RadioButton();
            this.rb1080p = new System.Windows.Forms.RadioButton();
            this.rbNativa = new System.Windows.Forms.RadioButton();
            this.pbEliminarDispositivo = new System.Windows.Forms.PictureBox();
            this.pbNuevoDispositivo = new System.Windows.Forms.PictureBox();
            this.pbEditDevice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDevices)).BeginInit();
            this.gbOpciones.SuspendLayout();
            this.gbResolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarDispositivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoDispositivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // lDispositivos
            // 
            this.lDispositivos.AutoSize = true;
            this.lDispositivos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lDispositivos.ForeColor = System.Drawing.Color.White;
            this.lDispositivos.Location = new System.Drawing.Point(15, 26);
            this.lDispositivos.Name = "lDispositivos";
            this.lDispositivos.Size = new System.Drawing.Size(185, 21);
            this.lDispositivos.TabIndex = 0;
            this.lDispositivos.Text = "Dispositivos registrados";
            // 
            // dataGVDevices
            // 
            this.dataGVDevices.AllowUserToAddRows = false;
            this.dataGVDevices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.dataGVDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDevices.Location = new System.Drawing.Point(19, 51);
            this.dataGVDevices.Name = "dataGVDevices";
            this.dataGVDevices.Size = new System.Drawing.Size(609, 110);
            this.dataGVDevices.TabIndex = 1;
            // 
            // butDevices
            // 
            this.butDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDevices.ForeColor = System.Drawing.Color.White;
            this.butDevices.Location = new System.Drawing.Point(19, 175);
            this.butDevices.Name = "butDevices";
            this.butDevices.Size = new System.Drawing.Size(134, 23);
            this.butDevices.TabIndex = 2;
            this.butDevices.Text = "Dispositivos conectados";
            this.butDevices.UseVisualStyleBackColor = false;
            // 
            // butConnect
            // 
            this.butConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConnect.ForeColor = System.Drawing.Color.White;
            this.butConnect.Location = new System.Drawing.Point(159, 175);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(111, 23);
            this.butConnect.TabIndex = 3;
            this.butConnect.Text = "Conectar";
            this.butConnect.UseVisualStyleBackColor = false;
            // 
            // butKillServer
            // 
            this.butKillServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butKillServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butKillServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butKillServer.ForeColor = System.Drawing.Color.White;
            this.butKillServer.Location = new System.Drawing.Point(276, 175);
            this.butKillServer.Name = "butKillServer";
            this.butKillServer.Size = new System.Drawing.Size(116, 23);
            this.butKillServer.TabIndex = 4;
            this.butKillServer.Text = "Reiniciar conexiones";
            this.butKillServer.UseVisualStyleBackColor = false;
            // 
            // butScreenMirror
            // 
            this.butScreenMirror.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butScreenMirror.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butScreenMirror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butScreenMirror.ForeColor = System.Drawing.Color.White;
            this.butScreenMirror.Location = new System.Drawing.Point(398, 175);
            this.butScreenMirror.Name = "butScreenMirror";
            this.butScreenMirror.Size = new System.Drawing.Size(116, 23);
            this.butScreenMirror.TabIndex = 5;
            this.butScreenMirror.Text = "Transmitir pantalla";
            this.butScreenMirror.UseVisualStyleBackColor = false;
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClear.ForeColor = System.Drawing.Color.White;
            this.butClear.Location = new System.Drawing.Point(520, 175);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(108, 23);
            this.butClear.TabIndex = 6;
            this.butClear.Text = "Limpiar terminal";
            this.butClear.UseVisualStyleBackColor = false;
            // 
            // butPath
            // 
            this.butPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPath.ForeColor = System.Drawing.Color.White;
            this.butPath.Location = new System.Drawing.Point(398, 22);
            this.butPath.Name = "butPath";
            this.butPath.Size = new System.Drawing.Size(77, 23);
            this.butPath.TabIndex = 7;
            this.butPath.Text = "Ruta Scrcpy";
            this.butPath.UseVisualStyleBackColor = false;
            // 
            // rtbCMD
            // 
            this.rtbCMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.rtbCMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCMD.ForeColor = System.Drawing.Color.White;
            this.rtbCMD.Location = new System.Drawing.Point(19, 213);
            this.rtbCMD.Name = "rtbCMD";
            this.rtbCMD.Size = new System.Drawing.Size(609, 166);
            this.rtbCMD.TabIndex = 11;
            this.rtbCMD.Text = "";
            // 
            // lOpciones
            // 
            this.lOpciones.AutoSize = true;
            this.lOpciones.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lOpciones.ForeColor = System.Drawing.Color.White;
            this.lOpciones.Location = new System.Drawing.Point(651, 9);
            this.lOpciones.Name = "lOpciones";
            this.lOpciones.Size = new System.Drawing.Size(180, 21);
            this.lOpciones.TabIndex = 12;
            this.lOpciones.Text = "Opciones para trasmitir";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.cbScreenOn);
            this.gbOpciones.Controls.Add(this.cbShowTouches);
            this.gbOpciones.Controls.Add(this.cbScreenOff);
            this.gbOpciones.Controls.Add(this.cbAllFps);
            this.gbOpciones.Controls.Add(this.cbDisableControl);
            this.gbOpciones.Controls.Add(this.cbAlwayOnTop);
            this.gbOpciones.ForeColor = System.Drawing.Color.White;
            this.gbOpciones.Location = new System.Drawing.Point(655, 34);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(200, 160);
            this.gbOpciones.TabIndex = 13;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // cbScreenOn
            // 
            this.cbScreenOn.AutoSize = true;
            this.cbScreenOn.Location = new System.Drawing.Point(7, 135);
            this.cbScreenOn.Name = "cbScreenOn";
            this.cbScreenOn.Size = new System.Drawing.Size(167, 17);
            this.cbScreenOn.TabIndex = 5;
            this.cbScreenOn.Text = "Mantener pantalla encendida.";
            this.cbScreenOn.UseVisualStyleBackColor = true;
            // 
            // cbShowTouches
            // 
            this.cbShowTouches.AutoSize = true;
            this.cbShowTouches.Location = new System.Drawing.Point(7, 112);
            this.cbShowTouches.Name = "cbShowTouches";
            this.cbShowTouches.Size = new System.Drawing.Size(99, 17);
            this.cbShowTouches.TabIndex = 4;
            this.cbShowTouches.Text = "Mostrar toques.";
            this.cbShowTouches.UseVisualStyleBackColor = true;
            // 
            // cbScreenOff
            // 
            this.cbScreenOff.AutoSize = true;
            this.cbScreenOff.Location = new System.Drawing.Point(7, 89);
            this.cbScreenOff.Name = "cbScreenOff";
            this.cbScreenOff.Size = new System.Drawing.Size(103, 17);
            this.cbScreenOff.TabIndex = 3;
            this.cbScreenOff.Text = "Apagar pantalla.";
            this.cbScreenOff.UseVisualStyleBackColor = true;
            // 
            // cbAllFps
            // 
            this.cbAllFps.AutoSize = true;
            this.cbAllFps.Location = new System.Drawing.Point(7, 66);
            this.cbAllFps.Name = "cbAllFps";
            this.cbAllFps.Size = new System.Drawing.Size(105, 17);
            this.cbAllFps.TabIndex = 2;
            this.cbAllFps.Text = "No saltar frames.";
            this.cbAllFps.UseVisualStyleBackColor = true;
            // 
            // cbDisableControl
            // 
            this.cbDisableControl.AutoSize = true;
            this.cbDisableControl.Location = new System.Drawing.Point(7, 43);
            this.cbDisableControl.Name = "cbDisableControl";
            this.cbDisableControl.Size = new System.Drawing.Size(150, 17);
            this.cbDisableControl.TabIndex = 1;
            this.cbDisableControl.Text = "Desactivar control remoto.";
            this.cbDisableControl.UseVisualStyleBackColor = true;
            // 
            // cbAlwayOnTop
            // 
            this.cbAlwayOnTop.AutoSize = true;
            this.cbAlwayOnTop.Location = new System.Drawing.Point(7, 20);
            this.cbAlwayOnTop.Name = "cbAlwayOnTop";
            this.cbAlwayOnTop.Size = new System.Drawing.Size(100, 17);
            this.cbAlwayOnTop.TabIndex = 0;
            this.cbAlwayOnTop.Text = "Fijar dispositivo.";
            this.cbAlwayOnTop.UseVisualStyleBackColor = true;
            // 
            // gbResolucion
            // 
            this.gbResolucion.Controls.Add(this.rb240p);
            this.gbResolucion.Controls.Add(this.rb480p);
            this.gbResolucion.Controls.Add(this.rb720p);
            this.gbResolucion.Controls.Add(this.rb1080p);
            this.gbResolucion.Controls.Add(this.rbNativa);
            this.gbResolucion.ForeColor = System.Drawing.Color.White;
            this.gbResolucion.Location = new System.Drawing.Point(655, 213);
            this.gbResolucion.Name = "gbResolucion";
            this.gbResolucion.Size = new System.Drawing.Size(200, 166);
            this.gbResolucion.TabIndex = 14;
            this.gbResolucion.TabStop = false;
            this.gbResolucion.Text = "Resoluciones";
            // 
            // rb240p
            // 
            this.rb240p.AutoSize = true;
            this.rb240p.Location = new System.Drawing.Point(7, 112);
            this.rb240p.Name = "rb240p";
            this.rb240p.Size = new System.Drawing.Size(43, 17);
            this.rb240p.TabIndex = 4;
            this.rb240p.TabStop = true;
            this.rb240p.Text = "240";
            this.rb240p.UseVisualStyleBackColor = true;
            // 
            // rb480p
            // 
            this.rb480p.AutoSize = true;
            this.rb480p.Location = new System.Drawing.Point(7, 89);
            this.rb480p.Name = "rb480p";
            this.rb480p.Size = new System.Drawing.Size(43, 17);
            this.rb480p.TabIndex = 3;
            this.rb480p.TabStop = true;
            this.rb480p.Text = "480";
            this.rb480p.UseVisualStyleBackColor = true;
            // 
            // rb720p
            // 
            this.rb720p.AutoSize = true;
            this.rb720p.Location = new System.Drawing.Point(7, 66);
            this.rb720p.Name = "rb720p";
            this.rb720p.Size = new System.Drawing.Size(43, 17);
            this.rb720p.TabIndex = 2;
            this.rb720p.TabStop = true;
            this.rb720p.Text = "720";
            this.rb720p.UseVisualStyleBackColor = true;
            // 
            // rb1080p
            // 
            this.rb1080p.AutoSize = true;
            this.rb1080p.Location = new System.Drawing.Point(7, 43);
            this.rb1080p.Name = "rb1080p";
            this.rb1080p.Size = new System.Drawing.Size(49, 17);
            this.rb1080p.TabIndex = 1;
            this.rb1080p.TabStop = true;
            this.rb1080p.Text = "1080";
            this.rb1080p.UseVisualStyleBackColor = true;
            // 
            // rbNativa
            // 
            this.rbNativa.AutoSize = true;
            this.rbNativa.Location = new System.Drawing.Point(7, 20);
            this.rbNativa.Name = "rbNativa";
            this.rbNativa.Size = new System.Drawing.Size(56, 17);
            this.rbNativa.TabIndex = 0;
            this.rbNativa.TabStop = true;
            this.rbNativa.Text = "Nativa";
            this.rbNativa.UseVisualStyleBackColor = true;
            // 
            // pbEliminarDispositivo
            // 
            this.pbEliminarDispositivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEliminarDispositivo.Image = global::ADC__Android_Device_Connector_.Properties.Resources.delete;
            this.pbEliminarDispositivo.Location = new System.Drawing.Point(540, 2);
            this.pbEliminarDispositivo.Name = "pbEliminarDispositivo";
            this.pbEliminarDispositivo.Size = new System.Drawing.Size(42, 45);
            this.pbEliminarDispositivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminarDispositivo.TabIndex = 10;
            this.pbEliminarDispositivo.TabStop = false;
            // 
            // pbNuevoDispositivo
            // 
            this.pbNuevoDispositivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNuevoDispositivo.Image = global::ADC__Android_Device_Connector_.Properties.Resources.smartphone;
            this.pbNuevoDispositivo.Location = new System.Drawing.Point(575, 2);
            this.pbNuevoDispositivo.Name = "pbNuevoDispositivo";
            this.pbNuevoDispositivo.Size = new System.Drawing.Size(53, 45);
            this.pbNuevoDispositivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNuevoDispositivo.TabIndex = 9;
            this.pbNuevoDispositivo.TabStop = false;
            this.pbNuevoDispositivo.Click += new System.EventHandler(this.pbNuevoDispositivo_Click);
            // 
            // pbEditDevice
            // 
            this.pbEditDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditDevice.Image = global::ADC__Android_Device_Connector_.Properties.Resources.edit;
            this.pbEditDevice.Location = new System.Drawing.Point(481, 2);
            this.pbEditDevice.Name = "pbEditDevice";
            this.pbEditDevice.Size = new System.Drawing.Size(53, 45);
            this.pbEditDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditDevice.TabIndex = 8;
            this.pbEditDevice.TabStop = false;
            this.pbEditDevice.Click += new System.EventHandler(this.pbEditDevice_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(881, 391);
            this.Controls.Add(this.gbResolucion);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.lOpciones);
            this.Controls.Add(this.rtbCMD);
            this.Controls.Add(this.pbEliminarDispositivo);
            this.Controls.Add(this.pbNuevoDispositivo);
            this.Controls.Add(this.pbEditDevice);
            this.Controls.Add(this.butPath);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butScreenMirror);
            this.Controls.Add(this.butKillServer);
            this.Controls.Add(this.butConnect);
            this.Controls.Add(this.butDevices);
            this.Controls.Add(this.dataGVDevices);
            this.Controls.Add(this.lDispositivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADC (Android Device Connector) v0.1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDevices)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.gbResolucion.ResumeLayout(false);
            this.gbResolucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarDispositivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoDispositivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDispositivos;
        private System.Windows.Forms.DataGridView dataGVDevices;
        private System.Windows.Forms.Button butDevices;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butKillServer;
        private System.Windows.Forms.Button butScreenMirror;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butPath;
        private System.Windows.Forms.PictureBox pbEditDevice;
        private System.Windows.Forms.PictureBox pbNuevoDispositivo;
        private System.Windows.Forms.PictureBox pbEliminarDispositivo;
        private System.Windows.Forms.RichTextBox rtbCMD;
        private System.Windows.Forms.Label lOpciones;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.CheckBox cbScreenOn;
        private System.Windows.Forms.CheckBox cbShowTouches;
        private System.Windows.Forms.CheckBox cbScreenOff;
        private System.Windows.Forms.CheckBox cbAllFps;
        private System.Windows.Forms.CheckBox cbDisableControl;
        private System.Windows.Forms.CheckBox cbAlwayOnTop;
        private System.Windows.Forms.GroupBox gbResolucion;
        private System.Windows.Forms.RadioButton rb240p;
        private System.Windows.Forms.RadioButton rb480p;
        private System.Windows.Forms.RadioButton rb720p;
        private System.Windows.Forms.RadioButton rb1080p;
        private System.Windows.Forms.RadioButton rbNativa;
    }
}
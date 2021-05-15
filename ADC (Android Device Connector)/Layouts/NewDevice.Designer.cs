
namespace ADC__Android_Device_Connector_.Layouts
{
    partial class NewDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDevice));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.butDevices = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = global::ADC__Android_Device_Connector_.Properties.Resources.smartphone;
            this.pbImage.Location = new System.Drawing.Point(55, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(169, 186);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pbImage_PreviewKeyDown);
            // 
            // butDevices
            // 
            this.butDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDevices.ForeColor = System.Drawing.Color.White;
            this.butDevices.Location = new System.Drawing.Point(76, 326);
            this.butDevices.Name = "butDevices";
            this.butDevices.Size = new System.Drawing.Size(134, 23);
            this.butDevices.TabIndex = 1;
            this.butDevices.Text = "Agregar dispositivo";
            this.butDevices.UseVisualStyleBackColor = false;
            this.butDevices.Click += new System.EventHandler(this.butDevices_Click);
            this.butDevices.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.butDevices_PreviewKeyDown);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.tbNombre.Location = new System.Drawing.Point(12, 217);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(260, 29);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.Text = "Ingrese el nombre del dispositivo.";
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNombre.Click += new System.EventHandler(this.tbNombre_Click);
            this.tbNombre.Leave += new System.EventHandler(this.tbNombre_Leave);
            this.tbNombre.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbNombre_PreviewKeyDown);
            // 
            // tbIp
            // 
            this.tbIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbIp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbIp.ForeColor = System.Drawing.Color.DarkGray;
            this.tbIp.Location = new System.Drawing.Point(12, 263);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(260, 29);
            this.tbIp.TabIndex = 3;
            this.tbIp.Text = "Ingrese la ip del dispositivo.";
            this.tbIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIp.Click += new System.EventHandler(this.tbIp_Click);
            this.tbIp.Leave += new System.EventHandler(this.tbIp_Leave);
            // 
            // NewDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.butDevices);
            this.Controls.Add(this.pbImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar dispositivo.";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button butDevices;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbIp;
    }
}
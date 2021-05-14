
namespace ADC__Android_Device_Connector_.Layouts
{
    partial class EditDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDevice));
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.butEditDevice = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.tbNombre.Location = new System.Drawing.Point(12, 216);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(260, 29);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.Text = "Ingrese el nombre del dispositivo.";
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIp
            // 
            this.tbIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbIp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbIp.ForeColor = System.Drawing.Color.DarkGray;
            this.tbIp.Location = new System.Drawing.Point(12, 262);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(260, 29);
            this.tbIp.TabIndex = 2;
            this.tbIp.Text = "Ingrese la ip del dispositivo.";
            this.tbIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butEditDevice
            // 
            this.butEditDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butEditDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEditDevice.ForeColor = System.Drawing.Color.White;
            this.butEditDevice.Location = new System.Drawing.Point(74, 326);
            this.butEditDevice.Name = "butEditDevice";
            this.butEditDevice.Size = new System.Drawing.Size(134, 23);
            this.butEditDevice.TabIndex = 3;
            this.butEditDevice.Text = "Editar dispositivo";
            this.butEditDevice.UseVisualStyleBackColor = false;
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::ADC__Android_Device_Connector_.Properties.Resources.edit;
            this.pbIcon.Location = new System.Drawing.Point(56, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(169, 186);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // EditDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.butEditDevice);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.pbIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar dispositivo.";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.Button butEditDevice;
    }
}
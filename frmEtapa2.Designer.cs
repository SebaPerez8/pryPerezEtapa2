namespace pryPerezEtapa2
{
    partial class frmEtapa2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCrearVehiculo = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCrearVehiculo
            // 
            btnCrearVehiculo.Location = new Point(229, 276);
            btnCrearVehiculo.Name = "btnCrearVehiculo";
            btnCrearVehiculo.Size = new Size(122, 44);
            btnCrearVehiculo.TabIndex = 1;
            btnCrearVehiculo.Text = "Crear Vehiculo";
            btnCrearVehiculo.UseVisualStyleBackColor = true;
            btnCrearVehiculo.Click += btnCrearVehiculo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(85, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 181);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frmEtapa2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 332);
            Controls.Add(pictureBox1);
            Controls.Add(btnCrearVehiculo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEtapa2";
            Text = "Etapa 2 - CREAR OBJETOS POR CÓDIGO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCrearVehiculo;
        private PictureBox pictureBox1;
    }
}

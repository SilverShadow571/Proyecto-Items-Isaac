namespace Isaac_Items
{
    partial class AplicacionObjetos
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
            DatosObjetos = new DataGridView();
            BtnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DatosObjetos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DatosObjetos
            // 
            DatosObjetos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatosObjetos.Location = new Point(97, 80);
            DatosObjetos.Name = "DatosObjetos";
            DatosObjetos.Size = new Size(379, 150);
            DatosObjetos.TabIndex = 0;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(638, 301);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 1;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(542, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 119);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // AplicacionObjetos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSalir);
            Controls.Add(DatosObjetos);
            Name = "AplicacionObjetos";
            Text = "Aplicacion";
            FormClosing += AplicacionObjetos_FormClosing;
            ((System.ComponentModel.ISupportInitialize)DatosObjetos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DatosObjetos;
        private Button BtnSalir;
        private PictureBox pictureBox1;
    }
}
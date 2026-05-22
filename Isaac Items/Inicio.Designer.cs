namespace Isaac_Items
{
    partial class Inicio
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirIsaacItemsToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            configuracToolStripMenuItem = new ToolStripMenuItem();
            preferenciasToolStripMenuItem = new ToolStripMenuItem();
            salidaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, opcionesToolStripMenuItem, salidaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirIsaacItemsToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // abrirIsaacItemsToolStripMenuItem
            // 
            abrirIsaacItemsToolStripMenuItem.Name = "abrirIsaacItemsToolStripMenuItem";
            abrirIsaacItemsToolStripMenuItem.Size = new Size(180, 22);
            abrirIsaacItemsToolStripMenuItem.Text = "Abrir Isaac Items";
            abrirIsaacItemsToolStripMenuItem.Click += abrirIsaacItemsToolStripMenuItem_Click;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configuracToolStripMenuItem, preferenciasToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // configuracToolStripMenuItem
            // 
            configuracToolStripMenuItem.Name = "configuracToolStripMenuItem";
            configuracToolStripMenuItem.Size = new Size(150, 22);
            configuracToolStripMenuItem.Text = "Configuracion";
            configuracToolStripMenuItem.Click += configuracToolStripMenuItem_Click;
            // 
            // preferenciasToolStripMenuItem
            // 
            preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            preferenciasToolStripMenuItem.Size = new Size(150, 22);
            preferenciasToolStripMenuItem.Text = "Preferencias";
            preferenciasToolStripMenuItem.Click += preferenciasToolStripMenuItem_Click;
            // 
            // salidaToolStripMenuItem
            // 
            salidaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            salidaToolStripMenuItem.Size = new Size(50, 20);
            salidaToolStripMenuItem.Text = "Salida";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click_1;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirIsaacItemsToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem configuracToolStripMenuItem;
        private ToolStripMenuItem preferenciasToolStripMenuItem;
        private ToolStripMenuItem salidaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
    #endregion
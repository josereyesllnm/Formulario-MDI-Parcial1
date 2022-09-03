
namespace Formulario_MDI
{
    partial class MENU
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.equposDeEscritorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GamaAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GamaMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GamaBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadroDeDialogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Violet;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menuToolStripMenuItem1,
            this.menu3ToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cuadroDeDialogoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion1ToolStripMenuItem,
            this.opcion2ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.menuToolStripMenuItem.Text = "Combos";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // opcion1ToolStripMenuItem
            // 
            this.opcion1ToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            this.opcion1ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.opcion1ToolStripMenuItem.Text = "DESCUENTOS";
            this.opcion1ToolStripMenuItem.Click += new System.EventHandler(this.opcion1ToolStripMenuItem_Click);
            // 
            // opcion2ToolStripMenuItem
            // 
            this.opcion2ToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.opcion2ToolStripMenuItem.Name = "opcion2ToolStripMenuItem";
            this.opcion2ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.opcion2ToolStripMenuItem.Text = "OFERTAS DEL MES";
            this.opcion2ToolStripMenuItem.Click += new System.EventHandler(this.opcion2ToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equposDeEscritorioToolStripMenuItem});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.menuToolStripMenuItem1.Text = "Productos";
            this.menuToolStripMenuItem1.Click += new System.EventHandler(this.menuToolStripMenuItem1_Click);
            // 
            // equposDeEscritorioToolStripMenuItem
            // 
            this.equposDeEscritorioToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.equposDeEscritorioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equposDeEscritorioToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.equposDeEscritorioToolStripMenuItem.Name = "equposDeEscritorioToolStripMenuItem";
            this.equposDeEscritorioToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.equposDeEscritorioToolStripMenuItem.Text = "EQUIPOS TECNOLOGICOS";
            this.equposDeEscritorioToolStripMenuItem.Click += new System.EventHandler(this.equposDeEscritorioToolStripMenuItem_Click);
            // 
            // menu3ToolStripMenuItem
            // 
            this.menu3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GamaAltaToolStripMenuItem,
            this.GamaMediaToolStripMenuItem,
            this.GamaBajaToolStripMenuItem});
            this.menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
            this.menu3ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.menu3ToolStripMenuItem.Text = "Portatiles";
            this.menu3ToolStripMenuItem.Click += new System.EventHandler(this.menu3ToolStripMenuItem_Click);
            // 
            // GamaAltaToolStripMenuItem
            // 
            this.GamaAltaToolStripMenuItem.Name = "GamaAltaToolStripMenuItem";
            this.GamaAltaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            // 
            // GamaMediaToolStripMenuItem
            // 
            this.GamaMediaToolStripMenuItem.Name = "GamaMediaToolStripMenuItem";
            this.GamaMediaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.GamaMediaToolStripMenuItem.Text = "Gama Media";
            this.GamaMediaToolStripMenuItem.Click += new System.EventHandler(this.GamaMediaToolStripMenuItem_Click);
            // 
            // GamaBajaToolStripMenuItem
            // 
            this.GamaBajaToolStripMenuItem.Name = "GamaBajaToolStripMenuItem";
            this.GamaBajaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.GamaBajaToolStripMenuItem.Text = "Gama Baja";
            this.GamaBajaToolStripMenuItem.Click += new System.EventHandler(this.GamaBajaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Ayuda";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(547, 703);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU";
            this.Text = "Formulario MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadroDeDialogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GamaAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GamaMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GamaBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem equposDeEscritorioToolStripMenuItem;
    }
}


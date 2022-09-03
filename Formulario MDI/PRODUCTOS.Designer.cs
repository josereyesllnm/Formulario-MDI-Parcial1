
namespace Formulario_MDI
{
    partial class EquiposDeEscritorio
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
            this.btnescritorio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnescritorio
            // 
            this.btnescritorio.BackColor = System.Drawing.Color.Violet;
            this.btnescritorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnescritorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnescritorio.Location = new System.Drawing.Point(53, 78);
            this.btnescritorio.Name = "btnescritorio";
            this.btnescritorio.Size = new System.Drawing.Size(192, 71);
            this.btnescritorio.TabIndex = 2;
            this.btnescritorio.Text = "COMPUTADORAS DE ESCRITORIO";
            this.btnescritorio.UseVisualStyleBackColor = false;
            this.btnescritorio.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "ACCESORIOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Violet;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(53, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "COMPUTADORAS PORTATILES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EquiposDeEscritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(890, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnescritorio);
            this.Name = "EquiposDeEscritorio";
            this.Text = "PRODUCTOS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnescritorio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
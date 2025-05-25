namespace SerpientesEscaleras
{
    partial class frmPregunta
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
            this.components = new System.ComponentModel.Container();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.pcBoxOpc1 = new System.Windows.Forms.PictureBox();
            this.pcBoxOpc2 = new System.Windows.Forms.PictureBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lblContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpc2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPregunta.Location = new System.Drawing.Point(515, 60);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(577, 31);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "¿Cuál de los siguientes corresponde al método";
            // 
            // pcBoxOpc1
            // 
            this.pcBoxOpc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBoxOpc1.Location = new System.Drawing.Point(77, 135);
            this.pcBoxOpc1.Name = "pcBoxOpc1";
            this.pcBoxOpc1.Size = new System.Drawing.Size(800, 850);
            this.pcBoxOpc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxOpc1.TabIndex = 1;
            this.pcBoxOpc1.TabStop = false;
            this.pcBoxOpc1.Click += new System.EventHandler(this.pcBoxOpc1_Click);
            // 
            // pcBoxOpc2
            // 
            this.pcBoxOpc2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBoxOpc2.Location = new System.Drawing.Point(1044, 135);
            this.pcBoxOpc2.Name = "pcBoxOpc2";
            this.pcBoxOpc2.Size = new System.Drawing.Size(800, 850);
            this.pcBoxOpc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxOpc2.TabIndex = 2;
            this.pcBoxOpc2.TabStop = false;
            this.pcBoxOpc2.Click += new System.EventHandler(this.pcBoxOpc2_Click);
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(908, 180);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(106, 76);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "15";
            this.lblContador.Click += new System.EventHandler(this.lblContador_Click);
            // 
            // frmPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.pcBoxOpc2);
            this.Controls.Add(this.pcBoxOpc1);
            this.Controls.Add(this.lblPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPregunta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpc2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.PictureBox pcBoxOpc1;
        private System.Windows.Forms.PictureBox pcBoxOpc2;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lblContador;
    }
}
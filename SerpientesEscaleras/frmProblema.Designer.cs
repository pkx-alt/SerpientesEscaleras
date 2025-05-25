namespace SerpientesEscaleras
{
    partial class frmProblema
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
            this.lblContador = new System.Windows.Forms.Label();
            this.cronometro = new System.Windows.Forms.Timer(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pcBoxOpc = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(415, 62);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(1102, 31);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Realiza el siguiente problema con el método indicado y escribe tu respuesta (9 de" +
    "cimales):";
            this.lblPregunta.Click += new System.EventHandler(this.lblPregunta_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(222, 57);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(102, 39);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "15:00";
            // 
            // cronometro
            // 
            this.cronometro.Interval = 1000;
            this.cronometro.Tick += new System.EventHandler(this.cronometro_Tick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Tan;
            this.btnAceptar.Location = new System.Drawing.Point(1074, 333);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(184, 49);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1071, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escribe tu respuesta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(1074, 262);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(797, 38);
            this.txtRespuesta.TabIndex = 8;
            // 
            // pcBoxOpc
            // 
            this.pcBoxOpc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBoxOpc.Location = new System.Drawing.Point(215, 137);
            this.pcBoxOpc.Name = "pcBoxOpc";
            this.pcBoxOpc.Size = new System.Drawing.Size(800, 850);
            this.pcBoxOpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxOpc.TabIndex = 5;
            this.pcBoxOpc.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1069, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(665, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Si la respuesta tiene más de un valor, separar por comas, por ejemplo: x,y,z";
            // 
            // frmProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pcBoxOpc);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProblema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProblema";
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxOpc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Timer cronometro;
        private System.Windows.Forms.PictureBox pcBoxOpc;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
    }
}
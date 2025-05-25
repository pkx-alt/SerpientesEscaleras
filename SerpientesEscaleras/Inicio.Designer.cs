namespace SerpientesEscaleras
{
    partial class Inicio
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
            System.Windows.Forms.Button button2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblJugadores = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInstrucciones = new System.Windows.Forms.PictureBox();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnInstrucciones)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.AntiqueWhite;
            button2.Enabled = false;
            button2.Location = new System.Drawing.Point(378, 200);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(1213, 609);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblJugadores
            // 
            this.lblJugadores.AutoSize = true;
            this.lblJugadores.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadores.Location = new System.Drawing.Point(961, 454);
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(29, 31);
            this.lblJugadores.TabIndex = 16;
            this.lblJugadores.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(1341, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "INSTRUCCIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(807, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "¡BIENVENIDO AL JUEGO!";
            // 
            // btnAumentar
            // 
            this.btnAumentar.BackColor = System.Drawing.Color.Moccasin;
            this.btnAumentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAumentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.Location = new System.Drawing.Point(1063, 445);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(40, 40);
            this.btnAumentar.TabIndex = 12;
            this.btnAumentar.Text = "+";
            this.btnAumentar.UseVisualStyleBackColor = false;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(831, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad de jugadores:";
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.BackColor = System.Drawing.Color.Transparent;
            this.btnDisminuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisminuir.Enabled = false;
            this.btnDisminuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuir.Location = new System.Drawing.Point(837, 445);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(40, 40);
            this.btnDisminuir.TabIndex = 10;
            this.btnDisminuir.Text = "-";
            this.btnDisminuir.UseVisualStyleBackColor = false;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Peru;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(855, 633);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(232, 56);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "JUGAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(830, 546);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(295, 29);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Insertar nombres de jugadores";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(1288, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 180);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.BackColor = System.Drawing.Color.Ivory;
            this.btnInstrucciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstrucciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstrucciones.Image = ((System.Drawing.Image)(resources.GetObject("btnInstrucciones.Image")));
            this.btnInstrucciones.Location = new System.Drawing.Point(1334, 428);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(114, 96);
            this.btnInstrucciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInstrucciones.TabIndex = 18;
            this.btnInstrucciones.TabStop = false;
            this.btnInstrucciones.Click += new System.EventHandler(this.btnInstrucciones_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnInstrucciones);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblJugadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisminuir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.button1);
            this.Controls.Add(button2);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btnInstrucciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJugadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox btnInstrucciones;
        private System.Windows.Forms.Button button1;
    }
}
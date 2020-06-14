namespace VirtualDriver
{
    partial class TestManejo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestManejo));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnIncio = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelPreg0 = new System.Windows.Forms.Panel();
            this.panelPreg1 = new System.Windows.Forms.Panel();
            this.btn1B = new System.Windows.Forms.Button();
            this.btn1A = new System.Windows.Forms.Button();
            this.btn1Correcto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCorrecto = new System.Windows.Forms.Panel();
            this.btnCorrecto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelError = new System.Windows.Forms.Panel();
            this.btnIncorrecto = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelPreg0.SuspendLayout();
            this.panelPreg1.SuspendLayout();
            this.panelCorrecto.SuspendLayout();
            this.panelError.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraTitulo.Controls.Add(this.btnIncio);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(600, 35);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnIncio
            // 
            this.btnIncio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnIncio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnIncio.FlatAppearance.BorderSize = 0;
            this.btnIncio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnIncio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncio.Image = ((System.Drawing.Image)(resources.GetObject("btnIncio.Image")));
            this.btnIncio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncio.Location = new System.Drawing.Point(12, 6);
            this.btnIncio.Name = "btnIncio";
            this.btnIncio.Size = new System.Drawing.Size(116, 23);
            this.btnIncio.TabIndex = 5;
            this.btnIncio.Text = "Inicio";
            this.btnIncio.UseVisualStyleBackColor = false;
            this.btnIncio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.ErrorImage")));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.InitialImage")));
            this.btnMaximizar.Location = new System.Drawing.Point(529, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.ErrorImage")));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.InitialImage")));
            this.btnMinimizar.Location = new System.Drawing.Point(492, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.ErrorImage")));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.InitialImage")));
            this.btnRestaurar.Location = new System.Drawing.Point(529, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(31, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ErrorImage")));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.InitialImage")));
            this.btnCerrar.Location = new System.Drawing.Point(566, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelPreg0
            // 
            this.panelPreg0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPreg0.BackgroundImage")));
            this.panelPreg0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPreg0.Controls.Add(this.panelPreg1);
            this.panelPreg0.Controls.Add(this.panelCorrecto);
            this.panelPreg0.Controls.Add(this.panelError);
            this.panelPreg0.Controls.Add(this.button3);
            this.panelPreg0.Controls.Add(this.button2);
            this.panelPreg0.Controls.Add(this.button1);
            this.panelPreg0.Controls.Add(this.label2);
            this.panelPreg0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPreg0.Location = new System.Drawing.Point(0, 35);
            this.panelPreg0.Name = "panelPreg0";
            this.panelPreg0.Size = new System.Drawing.Size(600, 315);
            this.panelPreg0.TabIndex = 2;
            // 
            // panelPreg1
            // 
            this.panelPreg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPreg1.BackgroundImage")));
            this.panelPreg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPreg1.Controls.Add(this.btn1B);
            this.panelPreg1.Controls.Add(this.btn1A);
            this.panelPreg1.Controls.Add(this.btn1Correcto);
            this.panelPreg1.Controls.Add(this.label3);
            this.panelPreg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPreg1.Location = new System.Drawing.Point(0, 0);
            this.panelPreg1.Name = "panelPreg1";
            this.panelPreg1.Size = new System.Drawing.Size(600, 315);
            this.panelPreg1.TabIndex = 7;
            this.panelPreg1.Visible = false;
            // 
            // btn1B
            // 
            this.btn1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1B.Location = new System.Drawing.Point(417, 233);
            this.btn1B.Name = "btn1B";
            this.btn1B.Size = new System.Drawing.Size(128, 55);
            this.btn1B.TabIndex = 3;
            this.btn1B.Text = "Nada, No hay ningun problema";
            this.btn1B.UseVisualStyleBackColor = true;
            this.btn1B.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn1A
            // 
            this.btn1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1A.Location = new System.Drawing.Point(60, 233);
            this.btn1A.Name = "btn1A";
            this.btn1A.Size = new System.Drawing.Size(113, 52);
            this.btn1A.TabIndex = 2;
            this.btn1A.Text = "Manejar Con Precaucion";
            this.btn1A.UseVisualStyleBackColor = true;
            this.btn1A.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn1Correcto
            // 
            this.btn1Correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Correcto.Location = new System.Drawing.Point(237, 233);
            this.btn1Correcto.Name = "btn1Correcto";
            this.btn1Correcto.Size = new System.Drawing.Size(109, 55);
            this.btn1Correcto.TabIndex = 1;
            this.btn1Correcto.Text = "Predir un Taxi";
            this.btn1Correcto.UseVisualStyleBackColor = true;
            this.btn1Correcto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "¿Que debe hacer al consmir bebidas alcoholicas?";
            // 
            // panelCorrecto
            // 
            this.panelCorrecto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCorrecto.BackgroundImage")));
            this.panelCorrecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCorrecto.Controls.Add(this.btnCorrecto);
            this.panelCorrecto.Controls.Add(this.label1);
            this.panelCorrecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCorrecto.Location = new System.Drawing.Point(0, 0);
            this.panelCorrecto.Name = "panelCorrecto";
            this.panelCorrecto.Size = new System.Drawing.Size(600, 315);
            this.panelCorrecto.TabIndex = 6;
            this.panelCorrecto.Visible = false;
            // 
            // btnCorrecto
            // 
            this.btnCorrecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCorrecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCorrecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrecto.ForeColor = System.Drawing.Color.Transparent;
            this.btnCorrecto.Location = new System.Drawing.Point(492, 262);
            this.btnCorrecto.Name = "btnCorrecto";
            this.btnCorrecto.Size = new System.Drawing.Size(75, 23);
            this.btnCorrecto.TabIndex = 7;
            this.btnCorrecto.Text = "Siguiente";
            this.btnCorrecto.UseVisualStyleBackColor = false;
            this.btnCorrecto.Click += new System.EventHandler(this.btnCorrecto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Muy Buena Respuesta";
            // 
            // panelError
            // 
            this.panelError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelError.BackgroundImage")));
            this.panelError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelError.Controls.Add(this.btnIncorrecto);
            this.panelError.Controls.Add(this.lblError);
            this.panelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelError.Location = new System.Drawing.Point(0, 0);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(600, 315);
            this.panelError.TabIndex = 5;
            this.panelError.Visible = false;
            // 
            // btnIncorrecto
            // 
            this.btnIncorrecto.BackColor = System.Drawing.Color.Red;
            this.btnIncorrecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncorrecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncorrecto.ForeColor = System.Drawing.Color.Transparent;
            this.btnIncorrecto.Location = new System.Drawing.Point(492, 265);
            this.btnIncorrecto.Name = "btnIncorrecto";
            this.btnIncorrecto.Size = new System.Drawing.Size(75, 23);
            this.btnIncorrecto.TabIndex = 8;
            this.btnIncorrecto.Text = "Siguiente";
            this.btnIncorrecto.UseVisualStyleBackColor = false;
            this.btnIncorrecto.Click += new System.EventHandler(this.btnIncorrecto_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Red;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(198, 13);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(218, 26);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Respuesta Incorrecta";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(400, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "C) Encender el vehiculo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(220, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "B) Revisar que esté vacio el baul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "A) Colocarce el Cinturon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Que es lo primero que debe hacer \r\nal subirse al vehiculo?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestManejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.panelPreg0);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestManejo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestManejo";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelPreg0.ResumeLayout(false);
            this.panelPreg0.PerformLayout();
            this.panelPreg1.ResumeLayout(false);
            this.panelPreg1.PerformLayout();
            this.panelCorrecto.ResumeLayout(false);
            this.panelCorrecto.PerformLayout();
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelPreg0;
        private System.Windows.Forms.Button btnIncio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panelCorrecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCorrecto;
        private System.Windows.Forms.Button btnIncorrecto;
        private System.Windows.Forms.Panel panelPreg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1Correcto;
        private System.Windows.Forms.Button btn1B;
        private System.Windows.Forms.Button btn1A;
    }
}
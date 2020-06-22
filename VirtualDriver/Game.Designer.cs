namespace VirtualDriver
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblchoque = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cartelcop = new System.Windows.Forms.Label();
            this.Infracciones = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rESETToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iNICIOToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.car = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.cop = new System.Windows.Forms.PictureBox();
            this.semaforo = new System.Windows.Forms.PictureBox();
            this.senda = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.min30 = new System.Windows.Forms.PictureBox();
            this.max90 = new System.Windows.Forms.PictureBox();
            this.max60 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max60)).BeginInit();
            this.SuspendLayout();
            // 
            // lblchoque
            // 
            this.lblchoque.AutoSize = true;
            this.lblchoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblchoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblchoque.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblchoque.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchoque.ForeColor = System.Drawing.Color.Blue;
            this.lblchoque.Location = new System.Drawing.Point(54, 177);
            this.lblchoque.Name = "lblchoque";
            this.lblchoque.Size = new System.Drawing.Size(291, 92);
            this.lblchoque.TabIndex = 51;
            this.lblchoque.Text = "CHOCASTE :(\r\nVuelve a intentarlo\r\n(Ctrl+R ó RESET)";
            this.lblchoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(281, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Velocidad = 0";
            // 
            // cartelcop
            // 
            this.cartelcop.AutoSize = true;
            this.cartelcop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cartelcop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartelcop.ForeColor = System.Drawing.Color.Red;
            this.cartelcop.Location = new System.Drawing.Point(358, 106);
            this.cartelcop.Name = "cartelcop";
            this.cartelcop.Size = new System.Drawing.Size(53, 16);
            this.cartelcop.TabIndex = 49;
            this.cartelcop.Text = "PARE!";
            // 
            // Infracciones
            // 
            this.Infracciones.AutoSize = true;
            this.Infracciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Infracciones.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infracciones.ForeColor = System.Drawing.Color.Red;
            this.Infracciones.Location = new System.Drawing.Point(27, 0);
            this.Infracciones.Name = "Infracciones";
            this.Infracciones.Size = new System.Drawing.Size(150, 18);
            this.Infracciones.TabIndex = 43;
            this.Infracciones.Text = "Infracciones = 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(276, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Puntaje = 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rESETToolStripMenuItem1,
            this.iNICIOToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 462);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rESETToolStripMenuItem1
            // 
            this.rESETToolStripMenuItem1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rESETToolStripMenuItem1.ForeColor = System.Drawing.Color.GreenYellow;
            this.rESETToolStripMenuItem1.Name = "rESETToolStripMenuItem1";
            this.rESETToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rESETToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.rESETToolStripMenuItem1.Text = "RESET";
            this.rESETToolStripMenuItem1.Click += new System.EventHandler(this.rESETToolStripMenuItem1_Click_1);
            // 
            // iNICIOToolStripMenuItem2
            // 
            this.iNICIOToolStripMenuItem2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNICIOToolStripMenuItem2.ForeColor = System.Drawing.Color.GreenYellow;
            this.iNICIOToolStripMenuItem2.Name = "iNICIOToolStripMenuItem2";
            this.iNICIOToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.iNICIOToolStripMenuItem2.Size = new System.Drawing.Size(65, 20);
            this.iNICIOToolStripMenuItem2.Text = "INICIO";
            this.iNICIOToolStripMenuItem2.Click += new System.EventHandler(this.iNICIOToolStripMenuItem2_Click);
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(316, 358);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(29, 58);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 48;
            this.car.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(229, 272);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(29, 58);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 47;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(138, 272);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(29, 58);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 46;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(54, 272);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(29, 58);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 45;
            this.enemy1.TabStop = false;
            // 
            // cop
            // 
            this.cop.Image = ((System.Drawing.Image)(resources.GetObject("cop.Image")));
            this.cop.Location = new System.Drawing.Point(361, 125);
            this.cop.Name = "cop";
            this.cop.Size = new System.Drawing.Size(50, 66);
            this.cop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cop.TabIndex = 44;
            this.cop.TabStop = false;
            // 
            // semaforo
            // 
            this.semaforo.Image = ((System.Drawing.Image)(resources.GetObject("semaforo.Image")));
            this.semaforo.Location = new System.Drawing.Point(364, 49);
            this.semaforo.Name = "semaforo";
            this.semaforo.Size = new System.Drawing.Size(47, 54);
            this.semaforo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.semaforo.TabIndex = 42;
            this.semaforo.TabStop = false;
            // 
            // senda
            // 
            this.senda.Image = ((System.Drawing.Image)(resources.GetObject("senda.Image")));
            this.senda.Location = new System.Drawing.Point(30, 59);
            this.senda.Name = "senda";
            this.senda.Size = new System.Drawing.Size(353, 44);
            this.senda.TabIndex = 41;
            this.senda.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox7.Location = new System.Drawing.Point(283, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 90);
            this.pictureBox7.TabIndex = 40;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Gold;
            this.pictureBox11.Location = new System.Drawing.Point(195, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(14, 462);
            this.pictureBox11.TabIndex = 37;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox10.Location = new System.Drawing.Point(283, 358);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(10, 90);
            this.pictureBox10.TabIndex = 36;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Location = new System.Drawing.Point(104, 358);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 90);
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox9.Location = new System.Drawing.Point(283, 240);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 90);
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Location = new System.Drawing.Point(104, 240);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 90);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(2, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 462);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(380, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 462);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox8.Location = new System.Drawing.Point(283, 119);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(10, 90);
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(104, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 90);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(104, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 90);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // min30
            // 
            this.min30.Image = global::VirtualDriver.Properties.Resources.velocidad_minima_30;
            this.min30.Location = new System.Drawing.Point(205, 439);
            this.min30.Name = "min30";
            this.min30.Size = new System.Drawing.Size(53, 50);
            this.min30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min30.TabIndex = 54;
            this.min30.TabStop = false;
            // 
            // max90
            // 
            this.max90.Image = global::VirtualDriver.Properties.Resources.maximo_90;
            this.max90.Location = new System.Drawing.Point(356, 441);
            this.max90.Name = "max90";
            this.max90.Size = new System.Drawing.Size(53, 45);
            this.max90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.max90.TabIndex = 55;
            this.max90.TabStop = false;
            this.max90.Visible = false;
            // 
            // max60
            // 
            this.max60.Image = global::VirtualDriver.Properties.Resources.maximo_60;
            this.max60.Location = new System.Drawing.Point(283, 439);
            this.max60.Name = "max60";
            this.max60.Size = new System.Drawing.Size(54, 47);
            this.max60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.max60.TabIndex = 56;
            this.max60.TabStop = false;
            this.max60.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(409, 486);
            this.Controls.Add(this.max60);
            this.Controls.Add(this.max90);
            this.Controls.Add(this.min30);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblchoque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cartelcop);
            this.Controls.Add(this.car);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.cop);
            this.Controls.Add(this.Infracciones);
            this.Controls.Add(this.semaforo);
            this.Controls.Add(this.senda);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max60)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblchoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cartelcop;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox cop;
        private System.Windows.Forms.Label Infracciones;
        private System.Windows.Forms.PictureBox semaforo;
        private System.Windows.Forms.PictureBox senda;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rESETToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox min30;
        private System.Windows.Forms.PictureBox max90;
        private System.Windows.Forms.PictureBox max60;
    }
}
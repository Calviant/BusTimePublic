namespace KURSOVAYA
{
    partial class emVoditel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emVoditel));
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.voditel_phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.voditel_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.voditel_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.VoditelDGV = new System.Windows.Forms.DataGridView();
            this.voditel_numUDtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.voditel_idtb = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.tbre = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.FIOVodCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nameVOD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoditelDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(242, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(376, 30);
            this.label13.TabIndex = 63;
            this.label13.Text = "Добавить  водителя в базе данных";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 661);
            this.panel1.TabIndex = 77;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(50, 26);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(98, 95);
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(48, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Билет";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(48, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Автобус";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(48, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пассажир";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(48, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Водитель";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(48, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Рейсы";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 46);
            this.panel2.TabIndex = 78;
            // 
            // voditel_phone
            // 
            this.voditel_phone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voditel_phone.Location = new System.Drawing.Point(961, 96);
            this.voditel_phone.Name = "voditel_phone";
            this.voditel_phone.Size = new System.Drawing.Size(184, 25);
            this.voditel_phone.TabIndex = 76;
            this.voditel_phone.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(957, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 75;
            this.label9.Text = "Номер телефона";
            // 
            // voditel_name
            // 
            this.voditel_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voditel_name.Location = new System.Drawing.Point(469, 96);
            this.voditel_name.Name = "voditel_name";
            this.voditel_name.Size = new System.Drawing.Size(167, 25);
            this.voditel_name.TabIndex = 74;
            this.voditel_name.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(466, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Имя";
            // 
            // voditel_lastname
            // 
            this.voditel_lastname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voditel_lastname.Location = new System.Drawing.Point(669, 96);
            this.voditel_lastname.Name = "voditel_lastname";
            this.voditel_lastname.Size = new System.Drawing.Size(253, 25);
            this.voditel_lastname.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(665, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Фамилия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(260, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "ID водителя";
            // 
            // VoditelDGV
            // 
            this.VoditelDGV.BackgroundColor = System.Drawing.Color.LightGray;
            this.VoditelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VoditelDGV.GridColor = System.Drawing.SystemColors.HotTrack;
            this.VoditelDGV.Location = new System.Drawing.Point(283, 254);
            this.VoditelDGV.Name = "VoditelDGV";
            this.VoditelDGV.RowHeadersWidth = 62;
            this.VoditelDGV.RowTemplate.Height = 28;
            this.VoditelDGV.Size = new System.Drawing.Size(880, 395);
            this.VoditelDGV.TabIndex = 69;
            this.VoditelDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VoditelDGV_CellContentClick);
            // 
            // voditel_numUDtb
            // 
            this.voditel_numUDtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voditel_numUDtb.Location = new System.Drawing.Point(670, 151);
            this.voditel_numUDtb.Name = "voditel_numUDtb";
            this.voditel_numUDtb.Size = new System.Drawing.Size(252, 25);
            this.voditel_numUDtb.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(666, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Номер удостоверения";
            // 
            // voditel_idtb
            // 
            this.voditel_idtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voditel_idtb.Location = new System.Drawing.Point(263, 96);
            this.voditel_idtb.Name = "voditel_idtb";
            this.voditel_idtb.Size = new System.Drawing.Size(166, 25);
            this.voditel_idtb.TabIndex = 66;
            this.voditel_idtb.Text = " ";
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.Location = new System.Drawing.Point(283, 182);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(167, 47);
            this.Addbutton.TabIndex = 63;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // tbre
            // 
            this.tbre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbre.Location = new System.Drawing.Point(717, 214);
            this.tbre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbre.Name = "tbre";
            this.tbre.Size = new System.Drawing.Size(129, 33);
            this.tbre.TabIndex = 81;
            this.tbre.Text = "Вернуть таблицу";
            this.tbre.UseVisualStyleBackColor = true;
            this.tbre.Click += new System.EventHandler(this.tbre_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(475, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 21);
            this.label12.TabIndex = 80;
            this.label12.Text = "Найти водителя по ФИО";
            // 
            // FIOVodCB
            // 
            this.FIOVodCB.BackColor = System.Drawing.Color.Transparent;
            this.FIOVodCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FIOVodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FIOVodCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FIOVodCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FIOVodCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FIOVodCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FIOVodCB.ItemHeight = 30;
            this.FIOVodCB.Location = new System.Drawing.Point(478, 212);
            this.FIOVodCB.Name = "FIOVodCB";
            this.FIOVodCB.Size = new System.Drawing.Size(231, 36);
            this.FIOVodCB.TabIndex = 79;
            this.FIOVodCB.SelectedIndexChanged += new System.EventHandler(this.FIOVodCB_SelectedIndexChanged);
            // 
            // nameVOD
            // 
            this.nameVOD.AutoSize = true;
            this.nameVOD.Location = new System.Drawing.Point(1137, 60);
            this.nameVOD.Name = "nameVOD";
            this.nameVOD.Size = new System.Drawing.Size(35, 13);
            this.nameVOD.TabIndex = 82;
            this.nameVOD.Text = "label3";
            this.nameVOD.Visible = false;
            // 
            // emVoditel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.nameVOD);
            this.Controls.Add(this.tbre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.FIOVodCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.voditel_phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.voditel_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voditel_lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VoditelDGV);
            this.Controls.Add(this.voditel_numUDtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.voditel_idtb);
            this.Controls.Add(this.Addbutton);
            this.Name = "emVoditel";
            this.Load += new System.EventHandler(this.emVoditel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoditelDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox voditel_phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox voditel_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox voditel_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView VoditelDGV;
        private System.Windows.Forms.TextBox voditel_numUDtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox voditel_idtb;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button tbre;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox FIOVodCB;
        private System.Windows.Forms.Label nameVOD;
    }
}
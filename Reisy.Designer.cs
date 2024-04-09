namespace KURSOVAYA
{
    partial class Reisy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reisy));
            this.reisy_IdAvttb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.reisy_idvodtb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BusList = new System.Windows.Forms.DataGridView();
            this.reisy_mestoNAZtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reisy_mestoOTtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reisy_numtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataOTtp = new System.Windows.Forms.DateTimePicker();
            this.dataPRIBtp = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.idReisaCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BusList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reisy_IdAvttb
            // 
            this.reisy_IdAvttb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reisy_IdAvttb.Location = new System.Drawing.Point(450, 151);
            this.reisy_IdAvttb.Name = "reisy_IdAvttb";
            this.reisy_IdAvttb.Size = new System.Drawing.Size(166, 25);
            this.reisy_IdAvttb.TabIndex = 39;
            this.reisy_IdAvttb.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(446, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "ID автобуса";
            // 
            // reisy_idvodtb
            // 
            this.reisy_idvodtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reisy_idvodtb.Location = new System.Drawing.Point(449, 96);
            this.reisy_idvodtb.Name = "reisy_idvodtb";
            this.reisy_idvodtb.Size = new System.Drawing.Size(167, 25);
            this.reisy_idvodtb.TabIndex = 37;
            this.reisy_idvodtb.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(446, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "ID водителя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(917, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Дата и время пребытия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(916, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Дата и время отправления";
            // 
            // BusList
            // 
            this.BusList.BackgroundColor = System.Drawing.Color.LightGray;
            this.BusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusList.GridColor = System.Drawing.SystemColors.HotTrack;
            this.BusList.Location = new System.Drawing.Point(263, 254);
            this.BusList.Name = "BusList";
            this.BusList.RowHeadersWidth = 62;
            this.BusList.RowTemplate.Height = 28;
            this.BusList.Size = new System.Drawing.Size(880, 395);
            this.BusList.TabIndex = 31;
            this.BusList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BusList_CellContentClick);
            // 
            // reisy_mestoNAZtb
            // 
            this.reisy_mestoNAZtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reisy_mestoNAZtb.Location = new System.Drawing.Point(650, 151);
            this.reisy_mestoNAZtb.Name = "reisy_mestoNAZtb";
            this.reisy_mestoNAZtb.Size = new System.Drawing.Size(252, 25);
            this.reisy_mestoNAZtb.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(646, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Место назначения";
            // 
            // reisy_mestoOTtb
            // 
            this.reisy_mestoOTtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reisy_mestoOTtb.Location = new System.Drawing.Point(649, 96);
            this.reisy_mestoOTtb.Name = "reisy_mestoOTtb";
            this.reisy_mestoOTtb.Size = new System.Drawing.Size(253, 25);
            this.reisy_mestoOTtb.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(645, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Место отправления";
            // 
            // reisy_numtb
            // 
            this.reisy_numtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reisy_numtb.Location = new System.Drawing.Point(243, 96);
            this.reisy_numtb.Name = "reisy_numtb";
            this.reisy_numtb.Size = new System.Drawing.Size(166, 25);
            this.reisy_numtb.TabIndex = 26;
            this.reisy_numtb.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(239, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Номер рейса";
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletebutton.Location = new System.Drawing.Point(649, 182);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(180, 49);
            this.Deletebutton.TabIndex = 24;
            this.Deletebutton.Text = "Удалить";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Editbutton.Location = new System.Drawing.Point(450, 182);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(166, 47);
            this.Editbutton.TabIndex = 23;
            this.Editbutton.Text = "Изменить";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.Location = new System.Drawing.Point(263, 182);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(167, 47);
            this.Addbutton.TabIndex = 22;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 46);
            this.panel2.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(268, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(441, 30);
            this.label13.TabIndex = 0;
            this.label13.Text = "Добавить или убрать рейс в базе данных";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 661);
            this.panel1.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(47, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 25);
            this.label14.TabIndex = 42;
            this.label14.Text = "Сотрудники";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(52, 35);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(98, 95);
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(48, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Билет";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(48, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Автобус";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(48, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Пассажир";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(48, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Водитель";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(48, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Рейсы";
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
            // dataOTtp
            // 
            this.dataOTtp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataOTtp.Location = new System.Drawing.Point(919, 93);
            this.dataOTtp.Name = "dataOTtp";
            this.dataOTtp.Size = new System.Drawing.Size(195, 25);
            this.dataOTtp.TabIndex = 40;
            // 
            // dataPRIBtp
            // 
            this.dataPRIBtp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataPRIBtp.Location = new System.Drawing.Point(919, 151);
            this.dataPRIBtp.Name = "dataPRIBtp";
            this.dataPRIBtp.Size = new System.Drawing.Size(195, 25);
            this.dataPRIBtp.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(852, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 21);
            this.label16.TabIndex = 64;
            this.label16.Text = "Найти рейс по ID";
            // 
            // idReisaCB
            // 
            this.idReisaCB.BackColor = System.Drawing.Color.Transparent;
            this.idReisaCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.idReisaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idReisaCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idReisaCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idReisaCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idReisaCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.idReisaCB.ItemHeight = 30;
            this.idReisaCB.Location = new System.Drawing.Point(855, 212);
            this.idReisaCB.Name = "idReisaCB";
            this.idReisaCB.Size = new System.Drawing.Size(231, 36);
            this.idReisaCB.TabIndex = 63;
            this.idReisaCB.SelectedIndexChanged += new System.EventHandler(this.idReisaCB_SelectedIndexChanged);
            // 
            // tbre
            // 
            this.tbre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbre.Location = new System.Drawing.Point(1094, 195);
            this.tbre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbre.Name = "tbre";
            this.tbre.Size = new System.Drawing.Size(90, 53);
            this.tbre.TabIndex = 67;
            this.tbre.Text = "Вернуть таблицу";
            this.tbre.UseVisualStyleBackColor = true;
            this.tbre.Click += new System.EventHandler(this.tbre_Click);
            // 
            // Reisy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tbre);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.idReisaCB);
            this.Controls.Add(this.dataPRIBtp);
            this.Controls.Add(this.dataOTtp);
            this.Controls.Add(this.reisy_IdAvttb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reisy_idvodtb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BusList);
            this.Controls.Add(this.reisy_mestoNAZtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reisy_mestoOTtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reisy_numtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Reisy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Reisy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BusList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reisy_IdAvttb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox reisy_idvodtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView BusList;
        private System.Windows.Forms.TextBox reisy_mestoNAZtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reisy_mestoOTtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reisy_numtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dataOTtp;
        private System.Windows.Forms.DateTimePicker dataPRIBtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2ComboBox idReisaCB;
        private System.Windows.Forms.Button tbre;
    }
}
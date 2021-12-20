
namespace MordochkaRom
{
    partial class FormClients
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelcount = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.topAll = new System.Windows.Forms.Button();
            this.top100 = new System.Windows.Forms.Button();
            this.top50 = new System.Windows.Forms.Button();
            this.top10 = new System.Windows.Forms.Button();
            this.BtnMan = new System.Windows.Forms.Button();
            this.BtnWoman = new System.Windows.Forms.Button();
            this.BtnAllGender = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchPhone = new System.Windows.Forms.TextBox();
            this.SearchMail = new System.Windows.Forms.TextBox();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBirthday = new System.Windows.Forms.Button();
            this.btnVisits = new System.Windows.Forms.Button();
            this.Lastdate = new System.Windows.Forms.Button();
            this.btnsortFname = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelNameDel = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.BtnUpd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(904, 420);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewClients);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(927, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиенты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelcount);
            this.groupBox2.Controls.Add(this.btnForward);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.topAll);
            this.groupBox2.Controls.Add(this.top100);
            this.groupBox2.Controls.Add(this.top50);
            this.groupBox2.Controls.Add(this.top10);
            this.groupBox2.Location = new System.Drawing.Point(14, 473);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(337, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Панель управления";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(278, 31);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(27, 16);
            this.labelcount.TabIndex = 4;
            this.labelcount.Text = "0/0";
            this.labelcount.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnForward.Location = new System.Drawing.Point(234, 23);
            this.btnForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(36, 31);
            this.btnForward.TabIndex = 8;
            this.btnForward.Text = "→";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnBack.Location = new System.Drawing.Point(191, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 31);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // topAll
            // 
            this.topAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.topAll.Location = new System.Drawing.Point(143, 23);
            this.topAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topAll.Name = "topAll";
            this.topAll.Size = new System.Drawing.Size(41, 31);
            this.topAll.TabIndex = 6;
            this.topAll.Text = "Все";
            this.topAll.UseVisualStyleBackColor = false;
            this.topAll.Click += new System.EventHandler(this.topAll_Click);
            // 
            // top100
            // 
            this.top100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.top100.Location = new System.Drawing.Point(93, 23);
            this.top100.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.top100.Name = "top100";
            this.top100.Size = new System.Drawing.Size(43, 31);
            this.top100.TabIndex = 5;
            this.top100.Text = "100";
            this.top100.UseVisualStyleBackColor = false;
            this.top100.Click += new System.EventHandler(this.top100_Click);
            // 
            // top50
            // 
            this.top50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.top50.Location = new System.Drawing.Point(50, 23);
            this.top50.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.top50.Name = "top50";
            this.top50.Size = new System.Drawing.Size(36, 31);
            this.top50.TabIndex = 4;
            this.top50.Text = "50";
            this.top50.UseVisualStyleBackColor = false;
            this.top50.Click += new System.EventHandler(this.top50_Click);
            // 
            // top10
            // 
            this.top10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.top10.Location = new System.Drawing.Point(7, 23);
            this.top10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.top10.Name = "top10";
            this.top10.Size = new System.Drawing.Size(36, 31);
            this.top10.TabIndex = 3;
            this.top10.Text = "10";
            this.top10.UseVisualStyleBackColor = false;
            this.top10.Click += new System.EventHandler(this.top10_Click);
            // 
            // BtnMan
            // 
            this.BtnMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.BtnMan.Location = new System.Drawing.Point(7, 27);
            this.BtnMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMan.Name = "BtnMan";
            this.BtnMan.Size = new System.Drawing.Size(36, 31);
            this.BtnMan.TabIndex = 9;
            this.BtnMan.Text = "М";
            this.BtnMan.UseVisualStyleBackColor = false;
            this.BtnMan.Click += new System.EventHandler(this.BtnMan_Click);
            // 
            // BtnWoman
            // 
            this.BtnWoman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.BtnWoman.Location = new System.Drawing.Point(50, 27);
            this.BtnWoman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnWoman.Name = "BtnWoman";
            this.BtnWoman.Size = new System.Drawing.Size(36, 31);
            this.BtnWoman.TabIndex = 10;
            this.BtnWoman.Text = "Ж";
            this.BtnWoman.UseVisualStyleBackColor = false;
            this.BtnWoman.Click += new System.EventHandler(this.BtnWoman_Click);
            // 
            // BtnAllGender
            // 
            this.BtnAllGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.BtnAllGender.Location = new System.Drawing.Point(7, 65);
            this.BtnAllGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAllGender.Name = "BtnAllGender";
            this.BtnAllGender.Size = new System.Drawing.Size(79, 31);
            this.BtnAllGender.TabIndex = 11;
            this.BtnAllGender.Text = "Все";
            this.BtnAllGender.UseVisualStyleBackColor = false;
            this.BtnAllGender.Click += new System.EventHandler(this.BtnAllGender_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnMan);
            this.groupBox3.Controls.Add(this.BtnAllGender);
            this.groupBox3.Controls.Add(this.BtnWoman);
            this.groupBox3.Location = new System.Drawing.Point(948, 350);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(92, 111);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пол";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.SearchPhone);
            this.groupBox4.Controls.Add(this.SearchMail);
            this.groupBox4.Controls.Add(this.SearchName);
            this.groupBox4.Location = new System.Drawing.Point(948, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(233, 123);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // SearchPhone
            // 
            this.SearchPhone.Location = new System.Drawing.Point(7, 87);
            this.SearchPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchPhone.Name = "SearchPhone";
            this.SearchPhone.Size = new System.Drawing.Size(131, 23);
            this.SearchPhone.TabIndex = 2;
            this.SearchPhone.TextChanged += new System.EventHandler(this.SearchPhone_TextChanged);
            // 
            // SearchMail
            // 
            this.SearchMail.Location = new System.Drawing.Point(7, 55);
            this.SearchMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchMail.Name = "SearchMail";
            this.SearchMail.Size = new System.Drawing.Size(131, 23);
            this.SearchMail.TabIndex = 1;
            this.SearchMail.TextChanged += new System.EventHandler(this.SearchMail_TextChanged);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(7, 23);
            this.SearchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(131, 23);
            this.SearchName.TabIndex = 0;
            this.SearchName.TextChanged += new System.EventHandler(this.SearchName_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBirthday);
            this.groupBox5.Controls.Add(this.btnVisits);
            this.groupBox5.Controls.Add(this.Lastdate);
            this.groupBox5.Controls.Add(this.btnsortFname);
            this.groupBox5.Location = new System.Drawing.Point(948, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 209);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Сортировка";
            // 
            // btnBirthday
            // 
            this.btnBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnBirthday.Location = new System.Drawing.Point(6, 140);
            this.btnBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBirthday.Name = "btnBirthday";
            this.btnBirthday.Size = new System.Drawing.Size(173, 54);
            this.btnBirthday.TabIndex = 15;
            this.btnBirthday.Text = "День рождения в этом месяце";
            this.btnBirthday.UseVisualStyleBackColor = false;
            this.btnBirthday.Click += new System.EventHandler(this.btnBirthday_Click);
            // 
            // btnVisits
            // 
            this.btnVisits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnVisits.Location = new System.Drawing.Point(6, 101);
            this.btnVisits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisits.Name = "btnVisits";
            this.btnVisits.Size = new System.Drawing.Size(173, 31);
            this.btnVisits.TabIndex = 14;
            this.btnVisits.Text = "Посещения";
            this.btnVisits.UseVisualStyleBackColor = false;
            this.btnVisits.Click += new System.EventHandler(this.btnVisits_Click);
            // 
            // Lastdate
            // 
            this.Lastdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.Lastdate.Location = new System.Drawing.Point(6, 62);
            this.Lastdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lastdate.Name = "Lastdate";
            this.Lastdate.Size = new System.Drawing.Size(173, 31);
            this.Lastdate.TabIndex = 13;
            this.Lastdate.Text = "Последние посещения";
            this.Lastdate.UseVisualStyleBackColor = false;
            this.Lastdate.Click += new System.EventHandler(this.Lastdate_Click);
            // 
            // btnsortFname
            // 
            this.btnsortFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnsortFname.Location = new System.Drawing.Point(6, 23);
            this.btnsortFname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsortFname.Name = "btnsortFname";
            this.btnsortFname.Size = new System.Drawing.Size(173, 31);
            this.btnsortFname.TabIndex = 12;
            this.btnsortFname.Text = "Фамилии А-Я";
            this.btnsortFname.UseVisualStyleBackColor = false;
            this.btnsortFname.Click += new System.EventHandler(this.btnsortFname_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btndelete.Location = new System.Drawing.Point(458, 504);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 24);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Удалить по ID";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(569, 504);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(54, 23);
            this.textBoxID.TabIndex = 15;
            // 
            // labelNameDel
            // 
            this.labelNameDel.AutoSize = true;
            this.labelNameDel.Location = new System.Drawing.Point(629, 508);
            this.labelNameDel.Name = "labelNameDel";
            this.labelNameDel.Size = new System.Drawing.Size(0, 16);
            this.labelNameDel.TabIndex = 16;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnAddClient.Location = new System.Drawing.Point(752, 474);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(189, 47);
            this.btnAddClient.TabIndex = 16;
            this.btnAddClient.Text = "Добавить пользователя";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // BtnUpd
            // 
            this.BtnUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.BtnUpd.Location = new System.Drawing.Point(752, 529);
            this.BtnUpd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpd.Name = "BtnUpd";
            this.BtnUpd.Size = new System.Drawing.Size(189, 46);
            this.BtnUpd.TabIndex = 17;
            this.BtnUpd.Text = "Редактирование пользователя";
            this.BtnUpd.UseVisualStyleBackColor = false;
            this.BtnUpd.Click += new System.EventHandler(this.BtnUpd_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 578);
            this.Controls.Add(this.BtnUpd);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.labelNameDel);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormClients";
            this.Text = "Mordochka\'s Clients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button topAll;
        private System.Windows.Forms.Button top100;
        private System.Windows.Forms.Button top50;
        private System.Windows.Forms.Button top10;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Button BtnMan;
        private System.Windows.Forms.Button BtnWoman;
        private System.Windows.Forms.Button BtnAllGender;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox SearchPhone;
        private System.Windows.Forms.TextBox SearchMail;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnsortFname;
        private System.Windows.Forms.Button Lastdate;
        private System.Windows.Forms.Button btnVisits;
        private System.Windows.Forms.Button btnBirthday;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelNameDel;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button BtnUpd;
    }
}


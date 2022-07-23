namespace RZHDWithDB
{
    partial class Main
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
            this.label5 = new System.Windows.Forms.Label();
            this.bSoldTickets = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpMainDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFirstDate = new System.Windows.Forms.DateTimePicker();
            this.tbDurationFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDurationTo = new System.Windows.Forms.TextBox();
            this.tbPriceTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPriceFrom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRouteCategorie = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbDepartStation = new System.Windows.Forms.ComboBox();
            this.cbArivalStation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTrainType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bUnsoldTickets = new System.Windows.Forms.Button();
            this.bReturnTickets = new System.Windows.Forms.Button();
            this.bGetRoutes = new System.Windows.Forms.Button();
            this.lblStat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Длительность (часы) от";
            // 
            // bSoldTickets
            // 
            this.bSoldTickets.Location = new System.Drawing.Point(13, 264);
            this.bSoldTickets.Name = "bSoldTickets";
            this.bSoldTickets.Size = new System.Drawing.Size(169, 23);
            this.bSoldTickets.TabIndex = 21;
            this.bSoldTickets.Text = "Проданные билеты";
            this.bSoldTickets.UseVisualStyleBackColor = true;
            this.bSoldTickets.Click += new System.EventHandler(this.bSoldTickets_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(222, 41);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 13);
            this.lblTo.TabIndex = 19;
            this.lblTo.Text = "По";
            this.lblTo.Visible = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(18, 41);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(14, 13);
            this.lblFrom.TabIndex = 18;
            this.lblFrom.Text = "С";
            this.lblFrom.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(408, 161);
            this.dataGridView1.TabIndex = 16;
            // 
            // dtpMainDate
            // 
            this.dtpMainDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpMainDate.Location = new System.Drawing.Point(252, 37);
            this.dtpMainDate.Name = "dtpMainDate";
            this.dtpMainDate.Size = new System.Drawing.Size(143, 20);
            this.dtpMainDate.TabIndex = 13;
            // 
            // dtpFirstDate
            // 
            this.dtpFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFirstDate.Location = new System.Drawing.Point(38, 37);
            this.dtpFirstDate.Name = "dtpFirstDate";
            this.dtpFirstDate.Size = new System.Drawing.Size(143, 20);
            this.dtpFirstDate.TabIndex = 12;
            this.dtpFirstDate.Visible = false;
            // 
            // tbDurationFrom
            // 
            this.tbDurationFrom.Location = new System.Drawing.Point(148, 210);
            this.tbDurationFrom.Name = "tbDurationFrom";
            this.tbDurationFrom.Size = new System.Drawing.Size(63, 20);
            this.tbDurationFrom.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "до";
            // 
            // tbDurationTo
            // 
            this.tbDurationTo.Location = new System.Drawing.Point(282, 210);
            this.tbDurationTo.Name = "tbDurationTo";
            this.tbDurationTo.Size = new System.Drawing.Size(63, 20);
            this.tbDurationTo.TabIndex = 25;
            // 
            // tbPriceTo
            // 
            this.tbPriceTo.Location = new System.Drawing.Point(282, 238);
            this.tbPriceTo.Name = "tbPriceTo";
            this.tbPriceTo.Size = new System.Drawing.Size(63, 20);
            this.tbPriceTo.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "до";
            // 
            // tbPriceFrom
            // 
            this.tbPriceFrom.Location = new System.Drawing.Point(148, 238);
            this.tbPriceFrom.Name = "tbPriceFrom";
            this.tbPriceFrom.Size = new System.Drawing.Size(63, 20);
            this.tbPriceFrom.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Цена (рубли) от";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Категория маршрута";
            // 
            // cbRouteCategorie
            // 
            this.cbRouteCategorie.FormattingEnabled = true;
            this.cbRouteCategorie.Location = new System.Drawing.Point(227, 63);
            this.cbRouteCategorie.Name = "cbRouteCategorie";
            this.cbRouteCategorie.Size = new System.Drawing.Size(169, 21);
            this.cbRouteCategorie.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Станция отправления";
            // 
            // cbDepartStation
            // 
            this.cbDepartStation.FormattingEnabled = true;
            this.cbDepartStation.Location = new System.Drawing.Point(227, 89);
            this.cbDepartStation.Name = "cbDepartStation";
            this.cbDepartStation.Size = new System.Drawing.Size(169, 21);
            this.cbDepartStation.TabIndex = 33;
            // 
            // cbArivalStation
            // 
            this.cbArivalStation.FormattingEnabled = true;
            this.cbArivalStation.Location = new System.Drawing.Point(227, 116);
            this.cbArivalStation.Name = "cbArivalStation";
            this.cbArivalStation.Size = new System.Drawing.Size(169, 21);
            this.cbArivalStation.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Станция назначения";
            // 
            // cbTrainType
            // 
            this.cbTrainType.FormattingEnabled = true;
            this.cbTrainType.Location = new System.Drawing.Point(227, 143);
            this.cbTrainType.Name = "cbTrainType";
            this.cbTrainType.Size = new System.Drawing.Size(169, 21);
            this.cbTrainType.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Тип поезда";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Выбрать период";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bUnsoldTickets
            // 
            this.bUnsoldTickets.Location = new System.Drawing.Point(227, 264);
            this.bUnsoldTickets.Name = "bUnsoldTickets";
            this.bUnsoldTickets.Size = new System.Drawing.Size(169, 23);
            this.bUnsoldTickets.TabIndex = 39;
            this.bUnsoldTickets.Text = "Невыкупленные билеты";
            this.bUnsoldTickets.UseVisualStyleBackColor = true;
            this.bUnsoldTickets.Click += new System.EventHandler(this.bUnsoldTickets_Click);
            // 
            // bReturnTickets
            // 
            this.bReturnTickets.Location = new System.Drawing.Point(13, 293);
            this.bReturnTickets.Name = "bReturnTickets";
            this.bReturnTickets.Size = new System.Drawing.Size(168, 23);
            this.bReturnTickets.TabIndex = 45;
            this.bReturnTickets.Text = "Сданные билеты";
            this.bReturnTickets.Click += new System.EventHandler(this.bReturnTickets_Click);
            // 
            // bGetRoutes
            // 
            this.bGetRoutes.Location = new System.Drawing.Point(227, 293);
            this.bGetRoutes.Name = "bGetRoutes";
            this.bGetRoutes.Size = new System.Drawing.Size(169, 23);
            this.bGetRoutes.TabIndex = 41;
            this.bGetRoutes.Text = "Перечень маршрутов";
            this.bGetRoutes.UseVisualStyleBackColor = true;
            this.bGetRoutes.Click += new System.EventHandler(this.bGetRoutes_Click);
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStat.Location = new System.Drawing.Point(0, 345);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(10, 13);
            this.lblStat.TabIndex = 42;
            this.lblStat.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Рейс";
            // 
            // cbTrip
            // 
            this.cbTrip.FormattingEnabled = true;
            this.cbTrip.Location = new System.Drawing.Point(227, 173);
            this.cbTrip.Name = "cbTrip";
            this.cbTrip.Size = new System.Drawing.Size(169, 21);
            this.cbTrip.TabIndex = 44;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 519);
            this.Controls.Add(this.cbTrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.bGetRoutes);
            this.Controls.Add(this.bReturnTickets);
            this.Controls.Add(this.bUnsoldTickets);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbTrainType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbArivalStation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbDepartStation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbRouteCategorie);
            this.Controls.Add(this.tbPriceTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPriceFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDurationTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDurationFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bSoldTickets);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpMainDate);
            this.Controls.Add(this.dtpFirstDate);
            this.Name = "Main";
            this.Text = "Касса РЖД";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bSoldTickets;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpMainDate;
        private System.Windows.Forms.DateTimePicker dtpFirstDate;
        private System.Windows.Forms.TextBox tbDurationFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDurationTo;
        private System.Windows.Forms.TextBox tbPriceTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPriceFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRouteCategorie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbDepartStation;
        private System.Windows.Forms.ComboBox cbArivalStation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTrainType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bUnsoldTickets;
        private System.Windows.Forms.Button bReturnTickets;
        private System.Windows.Forms.Button bGetRoutes;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTrip;
    }
}


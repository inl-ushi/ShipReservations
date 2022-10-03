namespace ShipReservations
{
    partial class 名門大洋フェリーInputForm
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
            this.txドアNO = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tx消費税 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bt入力 = new System.Windows.Forms.Button();
            this.dtp月日 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx請求額 = new System.Windows.Forms.TextBox();
            this.tx備考 = new System.Windows.Forms.TextBox();
            this.tx調整金 = new System.Windows.Forms.TextBox();
            this.tx車幅 = new System.Windows.Forms.TextBox();
            this.tx車長 = new System.Windows.Forms.TextBox();
            this.tx車番検索 = new System.Windows.Forms.TextBox();
            this.tx車両基本金額 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb利用区分 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tx曜日 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tx便名 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tx車種 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tx台数 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tx等級 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tx人数 = new System.Windows.Forms.TextBox();
            this.tx旅客基本金額 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tx旅客割引額 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tx積賃 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx卸料 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tx当月発生 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tx車番 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txドアNO
            // 
            this.txドアNO.Font = new System.Drawing.Font("メイリオ", 9F);
            this.txドアNO.FormattingEnabled = true;
            this.txドアNO.Location = new System.Drawing.Point(545, 109);
            this.txドアNO.Name = "txドアNO";
            this.txドアNO.Size = new System.Drawing.Size(70, 26);
            this.txドアNO.TabIndex = 16;
            this.txドアNO.SelectedIndexChanged += new System.EventHandler(this.txドアNO_SelectedIndexChanged);
            this.txドアNO.Enter += new System.EventHandler(this.txドアNO_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(1118, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "消費税";
            // 
            // tx消費税
            // 
            this.tx消費税.BackColor = System.Drawing.SystemColors.Control;
            this.tx消費税.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx消費税.Location = new System.Drawing.Point(1118, 109);
            this.tx消費税.Name = "tx消費税";
            this.tx消費税.ReadOnly = true;
            this.tx消費税.Size = new System.Drawing.Size(52, 25);
            this.tx消費税.TabIndex = 43;
            this.tx消費税.TabStop = false;
            this.tx消費税.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(10, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(303, 36);
            this.label14.TabIndex = 0;
            this.label14.Text = "名門大洋フェリー入力画面";
            // 
            // bt入力
            // 
            this.bt入力.Location = new System.Drawing.Point(1299, 12);
            this.bt入力.Name = "bt入力";
            this.bt入力.Size = new System.Drawing.Size(115, 40);
            this.bt入力.TabIndex = 0;
            this.bt入力.Text = "入　　力";
            this.bt入力.UseVisualStyleBackColor = true;
            this.bt入力.Click += new System.EventHandler(this.bt入力_Click);
            // 
            // dtp月日
            // 
            this.dtp月日.CalendarFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp月日.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp月日.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp月日.Location = new System.Drawing.Point(134, 110);
            this.dtp月日.Name = "dtp月日";
            this.dtp月日.Size = new System.Drawing.Size(107, 25);
            this.dtp月日.TabIndex = 4;
            this.dtp月日.ValueChanged += new System.EventHandler(this.dtp月日_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(541, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "ドアNO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(1172, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "請求額（込）";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(1278, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "請求備考";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(821, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 48);
            this.label8.TabIndex = 30;
            this.label8.Text = "燃料油価格変動調整金";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(661, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 43);
            this.label7.TabIndex = 28;
            this.label7.Text = "車幅";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(621, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 43);
            this.label6.TabIndex = 17;
            this.label6.Text = "車長";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(339, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "車番検索";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(755, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 47);
            this.label3.TabIndex = 27;
            this.label3.Text = "車両基本金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(130, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "月日";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tx請求額
            // 
            this.tx請求額.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx請求額.Location = new System.Drawing.Point(1176, 109);
            this.tx請求額.Name = "tx請求額";
            this.tx請求額.Size = new System.Drawing.Size(100, 25);
            this.tx請求額.TabIndex = 45;
            this.tx請求額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tx請求額.TextChanged += new System.EventHandler(this.tx請求額_TextChanged);
            // 
            // tx備考
            // 
            this.tx備考.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx備考.Location = new System.Drawing.Point(1282, 109);
            this.tx備考.Name = "tx備考";
            this.tx備考.ReadOnly = true;
            this.tx備考.Size = new System.Drawing.Size(88, 25);
            this.tx備考.TabIndex = 47;
            this.tx備考.TabStop = false;
            // 
            // tx調整金
            // 
            this.tx調整金.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx調整金.Location = new System.Drawing.Point(823, 109);
            this.tx調整金.Name = "tx調整金";
            this.tx調整金.ReadOnly = true;
            this.tx調整金.Size = new System.Drawing.Size(72, 25);
            this.tx調整金.TabIndex = 31;
            this.tx調整金.TabStop = false;
            this.tx調整金.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tx車幅
            // 
            this.tx車幅.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx車幅.Location = new System.Drawing.Point(663, 109);
            this.tx車幅.Name = "tx車幅";
            this.tx車幅.ReadOnly = true;
            this.tx車幅.Size = new System.Drawing.Size(18, 25);
            this.tx車幅.TabIndex = 20;
            this.tx車幅.TabStop = false;
            // 
            // tx車長
            // 
            this.tx車長.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx車長.Location = new System.Drawing.Point(621, 109);
            this.tx車長.Name = "tx車長";
            this.tx車長.Size = new System.Drawing.Size(36, 25);
            this.tx車長.TabIndex = 18;
            this.tx車長.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tx車番検索
            // 
            this.tx車番検索.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx車番検索.Location = new System.Drawing.Point(339, 110);
            this.tx車番検索.Name = "tx車番検索";
            this.tx車番検索.Size = new System.Drawing.Size(70, 25);
            this.tx車番検索.TabIndex = 12;
            this.tx車番検索.TextChanged += new System.EventHandler(this.tx車番検索_TextChanged);
            // 
            // tx車両基本金額
            // 
            this.tx車両基本金額.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx車両基本金額.Location = new System.Drawing.Point(759, 109);
            this.tx車両基本金額.Name = "tx車両基本金額";
            this.tx車両基本金額.ReadOnly = true;
            this.tx車両基本金額.Size = new System.Drawing.Size(58, 25);
            this.tx車両基本金額.TabIndex = 29;
            this.tx車両基本金額.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "利用区分";
            // 
            // cb利用区分
            // 
            this.cb利用区分.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cb利用区分.FormattingEnabled = true;
            this.cb利用区分.Location = new System.Drawing.Point(14, 110);
            this.cb利用区分.Name = "cb利用区分";
            this.cb利用区分.Size = new System.Drawing.Size(114, 26);
            this.cb利用区分.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(249, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "曜日";
            // 
            // tx曜日
            // 
            this.tx曜日.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx曜日.Location = new System.Drawing.Point(247, 110);
            this.tx曜日.Name = "tx曜日";
            this.tx曜日.ReadOnly = true;
            this.tx曜日.Size = new System.Drawing.Size(38, 25);
            this.tx曜日.TabIndex = 6;
            this.tx曜日.TabStop = false;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(291, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 43);
            this.label15.TabIndex = 7;
            this.label15.Text = "便名";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // tx便名
            // 
            this.tx便名.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx便名.Location = new System.Drawing.Point(291, 110);
            this.tx便名.Name = "tx便名";
            this.tx便名.ReadOnly = true;
            this.tx便名.Size = new System.Drawing.Size(18, 25);
            this.tx便名.TabIndex = 8;
            this.tx便名.TabStop = false;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(315, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 43);
            this.label16.TabIndex = 9;
            this.label16.Text = "車種";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // tx車種
            // 
            this.tx車種.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx車種.Location = new System.Drawing.Point(315, 110);
            this.tx車種.Name = "tx車種";
            this.tx車種.ReadOnly = true;
            this.tx車種.Size = new System.Drawing.Size(18, 25);
            this.tx車種.TabIndex = 10;
            this.tx車種.TabStop = false;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(686, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 43);
            this.label17.TabIndex = 21;
            this.label17.Text = "台数";
            // 
            // tx台数
            // 
            this.tx台数.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx台数.Location = new System.Drawing.Point(687, 109);
            this.tx台数.Name = "tx台数";
            this.tx台数.ReadOnly = true;
            this.tx台数.Size = new System.Drawing.Size(18, 25);
            this.tx台数.TabIndex = 22;
            this.tx台数.TabStop = false;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(710, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 43);
            this.label18.TabIndex = 23;
            this.label18.Text = "等級";
            // 
            // tx等級
            // 
            this.tx等級.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx等級.Location = new System.Drawing.Point(711, 109);
            this.tx等級.Name = "tx等級";
            this.tx等級.ReadOnly = true;
            this.tx等級.Size = new System.Drawing.Size(18, 25);
            this.tx等級.TabIndex = 24;
            this.tx等級.TabStop = false;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(734, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 43);
            this.label19.TabIndex = 25;
            this.label19.Text = "人数";
            // 
            // tx人数
            // 
            this.tx人数.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx人数.Location = new System.Drawing.Point(735, 109);
            this.tx人数.Name = "tx人数";
            this.tx人数.ReadOnly = true;
            this.tx人数.Size = new System.Drawing.Size(18, 25);
            this.tx人数.TabIndex = 26;
            this.tx人数.TabStop = false;
            // 
            // tx旅客基本金額
            // 
            this.tx旅客基本金額.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx旅客基本金額.Location = new System.Drawing.Point(901, 109);
            this.tx旅客基本金額.Name = "tx旅客基本金額";
            this.tx旅客基本金額.ReadOnly = true;
            this.tx旅客基本金額.Size = new System.Drawing.Size(64, 25);
            this.tx旅客基本金額.TabIndex = 33;
            this.tx旅客基本金額.TabStop = false;
            this.tx旅客基本金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(901, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 48);
            this.label21.TabIndex = 32;
            this.label21.Text = "旅客基本金額";
            // 
            // tx旅客割引額
            // 
            this.tx旅客割引額.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx旅客割引額.Location = new System.Drawing.Point(971, 109);
            this.tx旅客割引額.Name = "tx旅客割引額";
            this.tx旅客割引額.ReadOnly = true;
            this.tx旅客割引額.Size = new System.Drawing.Size(53, 25);
            this.tx旅客割引額.TabIndex = 35;
            this.tx旅客割引額.TabStop = false;
            this.tx旅客割引額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label22.Location = new System.Drawing.Point(971, 67);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 48);
            this.label22.TabIndex = 34;
            this.label22.Text = "旅客割引額";
            // 
            // tx積賃
            // 
            this.tx積賃.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx積賃.Location = new System.Drawing.Point(1030, 109);
            this.tx積賃.Name = "tx積賃";
            this.tx積賃.ReadOnly = true;
            this.tx積賃.Size = new System.Drawing.Size(18, 25);
            this.tx積賃.TabIndex = 37;
            this.tx積賃.TabStop = false;
            this.tx積賃.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(1027, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 43);
            this.label4.TabIndex = 36;
            this.label4.Text = "積賃";
            // 
            // tx卸料
            // 
            this.tx卸料.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx卸料.Location = new System.Drawing.Point(1054, 109);
            this.tx卸料.Name = "tx卸料";
            this.tx卸料.ReadOnly = true;
            this.tx卸料.Size = new System.Drawing.Size(18, 25);
            this.tx卸料.TabIndex = 39;
            this.tx卸料.TabStop = false;
            this.tx卸料.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label23.Location = new System.Drawing.Point(1051, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 43);
            this.label23.TabIndex = 38;
            this.label23.Text = "卸料";
            // 
            // tx当月発生
            // 
            this.tx当月発生.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx当月発生.Location = new System.Drawing.Point(1078, 109);
            this.tx当月発生.Name = "tx当月発生";
            this.tx当月発生.ReadOnly = true;
            this.tx当月発生.Size = new System.Drawing.Size(34, 25);
            this.tx当月発生.TabIndex = 41;
            this.tx当月発生.TabStop = false;
            this.tx当月発生.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label24.Location = new System.Drawing.Point(1075, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 43);
            this.label24.TabIndex = 40;
            this.label24.Text = "当月発生";
            // 
            // tx車番
            // 
            this.tx車番.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tx車番.FormattingEnabled = true;
            this.tx車番.Location = new System.Drawing.Point(415, 109);
            this.tx車番.Name = "tx車番";
            this.tx車番.Size = new System.Drawing.Size(124, 26);
            this.tx車番.TabIndex = 14;
            this.tx車番.SelectedIndexChanged += new System.EventHandler(this.tx車番_SelectedIndexChanged);
            this.tx車番.Enter += new System.EventHandler(this.tx車番_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label20.Location = new System.Drawing.Point(413, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 20);
            this.label20.TabIndex = 13;
            this.label20.Text = "車番";
            // 
            // 名門大洋フェリーInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 152);
            this.Controls.Add(this.tx当月発生);
            this.Controls.Add(this.tx卸料);
            this.Controls.Add(this.tx積賃);
            this.Controls.Add(this.tx旅客割引額);
            this.Controls.Add(this.tx旅客基本金額);
            this.Controls.Add(this.tx調整金);
            this.Controls.Add(this.tx車両基本金額);
            this.Controls.Add(this.tx台数);
            this.Controls.Add(this.tx人数);
            this.Controls.Add(this.tx等級);
            this.Controls.Add(this.tx車幅);
            this.Controls.Add(this.tx消費税);
            this.Controls.Add(this.tx車番);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tx車長);
            this.Controls.Add(this.tx車種);
            this.Controls.Add(this.tx便名);
            this.Controls.Add(this.tx曜日);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txドアNO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bt入力);
            this.Controls.Add(this.dtp月日);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx請求額);
            this.Controls.Add(this.tx備考);
            this.Controls.Add(this.tx車番検索);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb利用区分);
            this.Name = "名門大洋フェリーInputForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.名門大洋フェリーInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txドアNO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx消費税;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bt入力;
        private System.Windows.Forms.DateTimePicker dtp月日;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx請求額;
        private System.Windows.Forms.TextBox tx備考;
        private System.Windows.Forms.TextBox tx調整金;
        private System.Windows.Forms.TextBox tx車幅;
        private System.Windows.Forms.TextBox tx車長;
        private System.Windows.Forms.TextBox tx車番検索;
        private System.Windows.Forms.TextBox tx車両基本金額;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb利用区分;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tx曜日;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tx便名;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tx車種;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tx台数;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tx等級;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tx人数;
        private System.Windows.Forms.TextBox tx旅客基本金額;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tx旅客割引額;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tx積賃;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx卸料;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tx当月発生;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox tx車番;
        private System.Windows.Forms.Label label20;
    }
}
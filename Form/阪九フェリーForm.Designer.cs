namespace ShipReservations
{
    partial class 阪九フェリーForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.編集 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.削除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.利用区分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年月日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.曜日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.便名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.車種 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.車番 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ドアNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.全長 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.全幅 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手数料 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.調整額 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.燃料油価格変動調整金 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.請求金額 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.消費税 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.計上年月 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tx計上年 = new System.Windows.Forms.TextBox();
            this.tx計上月 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt読込 = new System.Windows.Forms.Button();
            this.btクリア = new System.Windows.Forms.Button();
            this.bt閉じる = new System.Windows.Forms.Button();
            this.bt請求データ = new System.Windows.Forms.Button();
            this.bt登録 = new System.Windows.Forms.Button();
            this.bt新規 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx合計 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx調整金計 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx消費税計 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx請求書計 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "阪九フェリー入力一覧";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.編集,
            this.削除,
            this.利用区分,
            this.年月日,
            this.曜日,
            this.便名,
            this.車種,
            this.車番,
            this.ドアNO,
            this.全長,
            this.全幅,
            this.手数料,
            this.調整額,
            this.燃料油価格変動調整金,
            this.請求金額,
            this.消費税,
            this.計上年月});
            this.dgv1.Location = new System.Drawing.Point(21, 94);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 21;
            this.dgv1.Size = new System.Drawing.Size(1347, 274);
            this.dgv1.TabIndex = 2;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // sid
            // 
            this.sid.DataPropertyName = "sid";
            this.sid.HeaderText = "sid";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.Visible = false;
            // 
            // 編集
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = "編集";
            this.編集.DefaultCellStyle = dataGridViewCellStyle11;
            this.編集.HeaderText = "編集";
            this.編集.Name = "編集";
            this.編集.ReadOnly = true;
            this.編集.Text = "";
            this.編集.Width = 40;
            // 
            // 削除
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = "削除";
            this.削除.DefaultCellStyle = dataGridViewCellStyle12;
            this.削除.HeaderText = "削除";
            this.削除.Name = "削除";
            this.削除.ReadOnly = true;
            this.削除.Text = "";
            this.削除.Width = 40;
            // 
            // 利用区分
            // 
            this.利用区分.DataPropertyName = "利用区分";
            this.利用区分.HeaderText = "利用区分";
            this.利用区分.Name = "利用区分";
            this.利用区分.ReadOnly = true;
            this.利用区分.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 年月日
            // 
            this.年月日.DataPropertyName = "乗船日";
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.年月日.DefaultCellStyle = dataGridViewCellStyle13;
            this.年月日.HeaderText = "年月日";
            this.年月日.Name = "年月日";
            this.年月日.ReadOnly = true;
            this.年月日.Width = 70;
            // 
            // 曜日
            // 
            this.曜日.DataPropertyName = "曜日";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver;
            this.曜日.DefaultCellStyle = dataGridViewCellStyle14;
            this.曜日.HeaderText = "曜日";
            this.曜日.Name = "曜日";
            this.曜日.ReadOnly = true;
            this.曜日.Width = 55;
            // 
            // 便名
            // 
            this.便名.DataPropertyName = "便名";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Silver;
            this.便名.DefaultCellStyle = dataGridViewCellStyle15;
            this.便名.HeaderText = "便名";
            this.便名.Name = "便名";
            this.便名.ReadOnly = true;
            this.便名.Width = 180;
            // 
            // 車種
            // 
            this.車種.DataPropertyName = "車種";
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            this.車種.DefaultCellStyle = dataGridViewCellStyle16;
            this.車種.HeaderText = "車種";
            this.車種.Name = "車種";
            this.車種.ReadOnly = true;
            this.車種.Width = 80;
            // 
            // 車番
            // 
            this.車番.DataPropertyName = "車番";
            this.車番.HeaderText = "車番";
            this.車番.Name = "車番";
            this.車番.ReadOnly = true;
            this.車番.Width = 200;
            // 
            // ドアNO
            // 
            this.ドアNO.DataPropertyName = "ドアNO";
            this.ドアNO.HeaderText = "ドアNO";
            this.ドアNO.Name = "ドアNO";
            this.ドアNO.ReadOnly = true;
            this.ドアNO.Width = 80;
            // 
            // 全長
            // 
            this.全長.DataPropertyName = "車長";
            this.全長.HeaderText = "全長";
            this.全長.Name = "全長";
            this.全長.ReadOnly = true;
            this.全長.Width = 70;
            // 
            // 全幅
            // 
            this.全幅.DataPropertyName = "全幅";
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Silver;
            this.全幅.DefaultCellStyle = dataGridViewCellStyle17;
            this.全幅.HeaderText = "全幅";
            this.全幅.Name = "全幅";
            this.全幅.ReadOnly = true;
            this.全幅.Width = 70;
            // 
            // 手数料
            // 
            this.手数料.DataPropertyName = "手数料";
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver;
            this.手数料.DefaultCellStyle = dataGridViewCellStyle18;
            this.手数料.HeaderText = "手数料";
            this.手数料.Name = "手数料";
            this.手数料.ReadOnly = true;
            this.手数料.Width = 70;
            // 
            // 調整額
            // 
            this.調整額.DataPropertyName = "調整額";
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver;
            this.調整額.DefaultCellStyle = dataGridViewCellStyle19;
            this.調整額.HeaderText = "調整額";
            this.調整額.Name = "調整額";
            this.調整額.ReadOnly = true;
            this.調整額.Width = 70;
            // 
            // 燃料油価格変動調整金
            // 
            this.燃料油価格変動調整金.DataPropertyName = "調整金";
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Silver;
            this.燃料油価格変動調整金.DefaultCellStyle = dataGridViewCellStyle20;
            this.燃料油価格変動調整金.HeaderText = "燃料油価格変動調整金";
            this.燃料油価格変動調整金.Name = "燃料油価格変動調整金";
            this.燃料油価格変動調整金.ReadOnly = true;
            // 
            // 請求金額
            // 
            this.請求金額.DataPropertyName = "請求額";
            this.請求金額.HeaderText = "請求金額";
            this.請求金額.Name = "請求金額";
            this.請求金額.ReadOnly = true;
            // 
            // 消費税
            // 
            this.消費税.DataPropertyName = "消費税";
            this.消費税.HeaderText = "消費税";
            this.消費税.Name = "消費税";
            this.消費税.ReadOnly = true;
            this.消費税.Visible = false;
            // 
            // 計上年月
            // 
            this.計上年月.DataPropertyName = "計上年月";
            this.計上年月.HeaderText = "計上年月";
            this.計上年月.Name = "計上年月";
            this.計上年月.ReadOnly = true;
            this.計上年月.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(358, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "計上年";
            // 
            // tx計上年
            // 
            this.tx計上年.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx計上年.Location = new System.Drawing.Point(412, 12);
            this.tx計上年.Name = "tx計上年";
            this.tx計上年.Size = new System.Drawing.Size(47, 25);
            this.tx計上年.TabIndex = 4;
            this.tx計上年.Leave += new System.EventHandler(this.tx計上年_Leave);
            // 
            // tx計上月
            // 
            this.tx計上月.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx計上月.Location = new System.Drawing.Point(523, 12);
            this.tx計上月.Name = "tx計上月";
            this.tx計上月.Size = new System.Drawing.Size(20, 25);
            this.tx計上月.TabIndex = 6;
            this.tx計上月.TextChanged += new System.EventHandler(this.tx計上月_TextChanged);
            this.tx計上月.Leave += new System.EventHandler(this.tx計上月_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(469, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "計上月";
            // 
            // bt読込
            // 
            this.bt読込.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt読込.Location = new System.Drawing.Point(674, 19);
            this.bt読込.Name = "bt読込";
            this.bt読込.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bt読込.Size = new System.Drawing.Size(114, 57);
            this.bt読込.TabIndex = 9;
            this.bt読込.Text = "読　　込";
            this.bt読込.UseVisualStyleBackColor = true;
            this.bt読込.Click += new System.EventHandler(this.bt読込_Click);
            // 
            // btクリア
            // 
            this.btクリア.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btクリア.Location = new System.Drawing.Point(914, 19);
            this.btクリア.Name = "btクリア";
            this.btクリア.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btクリア.Size = new System.Drawing.Size(114, 57);
            this.btクリア.TabIndex = 10;
            this.btクリア.Text = "クリア";
            this.btクリア.UseVisualStyleBackColor = true;
            this.btクリア.Click += new System.EventHandler(this.btクリア_Click);
            // 
            // bt閉じる
            // 
            this.bt閉じる.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt閉じる.Location = new System.Drawing.Point(1034, 19);
            this.bt閉じる.Name = "bt閉じる";
            this.bt閉じる.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bt閉じる.Size = new System.Drawing.Size(114, 57);
            this.bt閉じる.TabIndex = 11;
            this.bt閉じる.Text = "閉じる";
            this.bt閉じる.UseVisualStyleBackColor = true;
            this.bt閉じる.Click += new System.EventHandler(this.bt閉じる_Click);
            // 
            // bt請求データ
            // 
            this.bt請求データ.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt請求データ.Location = new System.Drawing.Point(1154, 19);
            this.bt請求データ.Name = "bt請求データ";
            this.bt請求データ.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bt請求データ.Size = new System.Drawing.Size(114, 57);
            this.bt請求データ.TabIndex = 12;
            this.bt請求データ.Text = "請求データ";
            this.bt請求データ.UseVisualStyleBackColor = true;
            this.bt請求データ.Click += new System.EventHandler(this.bt請求データ_Click);
            // 
            // bt登録
            // 
            this.bt登録.Enabled = false;
            this.bt登録.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt登録.Location = new System.Drawing.Point(1254, 381);
            this.bt登録.Name = "bt登録";
            this.bt登録.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bt登録.Size = new System.Drawing.Size(114, 57);
            this.bt登録.TabIndex = 13;
            this.bt登録.Text = "登　　録";
            this.bt登録.UseVisualStyleBackColor = true;
            this.bt登録.Click += new System.EventHandler(this.bt登録_Click);
            // 
            // bt新規
            // 
            this.bt新規.Enabled = false;
            this.bt新規.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt新規.Location = new System.Drawing.Point(794, 19);
            this.bt新規.Name = "bt新規";
            this.bt新規.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bt新規.Size = new System.Drawing.Size(114, 57);
            this.bt新規.TabIndex = 14;
            this.bt新規.Text = "新規作成";
            this.bt新規.UseVisualStyleBackColor = true;
            this.bt新規.Click += new System.EventHandler(this.bt新規_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(1113, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "＝";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(997, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "＋";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(884, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "＋";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(1137, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "合計";
            // 
            // tx合計
            // 
            this.tx合計.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx合計.Location = new System.Drawing.Point(1141, 411);
            this.tx合計.Name = "tx合計";
            this.tx合計.ReadOnly = true;
            this.tx合計.Size = new System.Drawing.Size(87, 25);
            this.tx合計.TabIndex = 33;
            this.tx合計.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(1016, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "調整金計";
            // 
            // tx調整金計
            // 
            this.tx調整金計.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx調整金計.Location = new System.Drawing.Point(1020, 411);
            this.tx調整金計.Name = "tx調整金計";
            this.tx調整金計.ReadOnly = true;
            this.tx調整金計.Size = new System.Drawing.Size(87, 25);
            this.tx調整金計.TabIndex = 31;
            this.tx調整金計.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(904, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "消費税計";
            // 
            // tx消費税計
            // 
            this.tx消費税計.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx消費税計.Location = new System.Drawing.Point(908, 411);
            this.tx消費税計.Name = "tx消費税計";
            this.tx消費税計.ReadOnly = true;
            this.tx消費税計.Size = new System.Drawing.Size(87, 25);
            this.tx消費税計.TabIndex = 29;
            this.tx消費税計.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(790, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "請求額計";
            // 
            // tx請求書計
            // 
            this.tx請求書計.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx請求書計.Location = new System.Drawing.Point(794, 411);
            this.tx請求書計.Name = "tx請求書計";
            this.tx請求書計.ReadOnly = true;
            this.tx請求書計.Size = new System.Drawing.Size(87, 25);
            this.tx請求書計.TabIndex = 27;
            this.tx請求書計.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 阪九フェリーForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx合計);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx調整金計);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx消費税計);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx請求書計);
            this.Controls.Add(this.bt新規);
            this.Controls.Add(this.bt登録);
            this.Controls.Add(this.bt請求データ);
            this.Controls.Add(this.bt閉じる);
            this.Controls.Add(this.btクリア);
            this.Controls.Add(this.bt読込);
            this.Controls.Add(this.tx計上月);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx計上年);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label1);
            this.Name = "阪九フェリーForm";
            this.Text = "阪九フェリー入力一覧";
            this.Load += new System.EventHandler(this.阪九Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx計上年;
        private System.Windows.Forms.TextBox tx計上月;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt読込;
        private System.Windows.Forms.Button btクリア;
        private System.Windows.Forms.Button bt閉じる;
        private System.Windows.Forms.Button bt請求データ;
        private System.Windows.Forms.Button bt登録;
        private System.Windows.Forms.Button bt新規;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewButtonColumn 編集;
        private System.Windows.Forms.DataGridViewButtonColumn 削除;
        private System.Windows.Forms.DataGridViewTextBoxColumn 利用区分;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年月日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 曜日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 便名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 車種;
        private System.Windows.Forms.DataGridViewTextBoxColumn 車番;
        private System.Windows.Forms.DataGridViewTextBoxColumn ドアNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn 全長;
        private System.Windows.Forms.DataGridViewTextBoxColumn 全幅;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手数料;
        private System.Windows.Forms.DataGridViewTextBoxColumn 調整額;
        private System.Windows.Forms.DataGridViewTextBoxColumn 燃料油価格変動調整金;
        private System.Windows.Forms.DataGridViewTextBoxColumn 請求金額;
        private System.Windows.Forms.DataGridViewTextBoxColumn 消費税;
        private System.Windows.Forms.DataGridViewTextBoxColumn 計上年月;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx合計;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx調整金計;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx消費税計;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx請求書計;
    }
}
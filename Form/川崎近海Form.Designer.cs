namespace ShipReservations
{
    partial class 川崎近海Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.編集 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.削除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.利用区分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.積日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.摘要 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.車番 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.車種 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ドアNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIZE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.運賃 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.調整金 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.消費税額 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.計上年月 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tx計上年 = new System.Windows.Forms.TextBox();
            this.tx計上月 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx燃料価格調整金 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label11 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(207, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "川崎近海入力一覧";
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
            this.NO,
            this.積日,
            this.摘要,
            this.車番,
            this.車種,
            this.ドアNO,
            this.SIZE,
            this.品目,
            this.運賃,
            this.調整金,
            this.消費税額,
            this.備考,
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
            this.sid.Frozen = true;
            this.sid.HeaderText = "sid";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.Visible = false;
            // 
            // 編集
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = "編集";
            this.編集.DefaultCellStyle = dataGridViewCellStyle8;
            this.編集.Frozen = true;
            this.編集.HeaderText = "編集";
            this.編集.Name = "編集";
            this.編集.ReadOnly = true;
            this.編集.UseColumnTextForButtonValue = true;
            this.編集.Width = 40;
            // 
            // 削除
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = "削除";
            this.削除.DefaultCellStyle = dataGridViewCellStyle9;
            this.削除.Frozen = true;
            this.削除.HeaderText = "削除";
            this.削除.Name = "削除";
            this.削除.ReadOnly = true;
            this.削除.UseColumnTextForButtonValue = true;
            this.削除.Width = 40;
            // 
            // 利用区分
            // 
            this.利用区分.DataPropertyName = "利用区分";
            this.利用区分.HeaderText = "利用区分";
            this.利用区分.Name = "利用区分";
            this.利用区分.ReadOnly = true;
            // 
            // NO
            // 
            this.NO.DataPropertyName = "NO";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            this.NO.DefaultCellStyle = dataGridViewCellStyle10;
            this.NO.HeaderText = "NO";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Width = 40;
            // 
            // 積日
            // 
            this.積日.DataPropertyName = "乗船日";
            this.積日.HeaderText = "積日";
            this.積日.Name = "積日";
            this.積日.ReadOnly = true;
            // 
            // 摘要
            // 
            this.摘要.DataPropertyName = "摘要";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            this.摘要.DefaultCellStyle = dataGridViewCellStyle11;
            this.摘要.HeaderText = "摘要";
            this.摘要.Name = "摘要";
            this.摘要.ReadOnly = true;
            // 
            // 車番
            // 
            this.車番.DataPropertyName = "車番";
            this.車番.HeaderText = "車番";
            this.車番.Name = "車番";
            this.車番.ReadOnly = true;
            // 
            // 車種
            // 
            this.車種.DataPropertyName = "車種";
            this.車種.HeaderText = "車種";
            this.車種.Name = "車種";
            this.車種.ReadOnly = true;
            this.車種.Visible = false;
            // 
            // ドアNO
            // 
            this.ドアNO.DataPropertyName = "ドアNO";
            this.ドアNO.HeaderText = "ドアNO";
            this.ドアNO.Name = "ドアNO";
            this.ドアNO.ReadOnly = true;
            this.ドアNO.Width = 60;
            // 
            // SIZE
            // 
            this.SIZE.DataPropertyName = "車長";
            this.SIZE.HeaderText = "SIZE";
            this.SIZE.Name = "SIZE";
            this.SIZE.ReadOnly = true;
            // 
            // 品目
            // 
            this.品目.DataPropertyName = "品目";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
            this.品目.DefaultCellStyle = dataGridViewCellStyle12;
            this.品目.HeaderText = "品目";
            this.品目.Name = "品目";
            this.品目.ReadOnly = true;
            // 
            // 運賃
            // 
            this.運賃.DataPropertyName = "請求額";
            this.運賃.HeaderText = "運賃";
            this.運賃.Name = "運賃";
            this.運賃.ReadOnly = true;
            this.運賃.Width = 120;
            // 
            // 調整金
            // 
            this.調整金.DataPropertyName = "調整金";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            this.調整金.DefaultCellStyle = dataGridViewCellStyle13;
            this.調整金.HeaderText = "調整金";
            this.調整金.Name = "調整金";
            this.調整金.ReadOnly = true;
            this.調整金.Width = 110;
            // 
            // 消費税額
            // 
            this.消費税額.DataPropertyName = "消費税";
            this.消費税額.HeaderText = "消費税額";
            this.消費税額.Name = "消費税額";
            this.消費税額.ReadOnly = true;
            // 
            // 備考
            // 
            this.備考.DataPropertyName = "備考";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver;
            this.備考.DefaultCellStyle = dataGridViewCellStyle14;
            this.備考.FillWeight = 230F;
            this.備考.HeaderText = "備考";
            this.備考.Name = "備考";
            this.備考.ReadOnly = true;
            this.備考.Width = 230;
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
            this.tx計上年.Size = new System.Drawing.Size(45, 25);
            this.tx計上年.TabIndex = 4;
            this.tx計上年.Leave += new System.EventHandler(this.tx計上年_Leave);
            // 
            // tx計上月
            // 
            this.tx計上月.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx計上月.Location = new System.Drawing.Point(524, 12);
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
            this.label3.Location = new System.Drawing.Point(473, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "計上月";
            // 
            // tx燃料価格調整金
            // 
            this.tx燃料価格調整金.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx燃料価格調整金.Location = new System.Drawing.Point(412, 43);
            this.tx燃料価格調整金.Name = "tx燃料価格調整金";
            this.tx燃料価格調整金.ReadOnly = true;
            this.tx燃料価格調整金.Size = new System.Drawing.Size(92, 25);
            this.tx燃料価格調整金.TabIndex = 8;
            this.tx燃料価格調整金.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(306, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "燃料価格調整金";
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
            this.bt新規.TabIndex = 15;
            this.bt新規.Text = "新規作成";
            this.bt新規.UseVisualStyleBackColor = true;
            this.bt新規.Click += new System.EventHandler(this.bt新規_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(1115, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "＝";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(999, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "＋";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(886, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "＋";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(1139, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "合計";
            // 
            // tx合計
            // 
            this.tx合計.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx合計.Location = new System.Drawing.Point(1143, 412);
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
            this.label6.Location = new System.Drawing.Point(1018, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "調整金計";
            // 
            // tx調整金計
            // 
            this.tx調整金計.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx調整金計.Location = new System.Drawing.Point(1022, 412);
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
            this.label5.Location = new System.Drawing.Point(906, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "消費税計";
            // 
            // tx消費税計
            // 
            this.tx消費税計.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx消費税計.Location = new System.Drawing.Point(910, 412);
            this.tx消費税計.Name = "tx消費税計";
            this.tx消費税計.ReadOnly = true;
            this.tx消費税計.Size = new System.Drawing.Size(87, 25);
            this.tx消費税計.TabIndex = 29;
            this.tx消費税計.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(792, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "請求額計";
            // 
            // tx請求書計
            // 
            this.tx請求書計.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx請求書計.Location = new System.Drawing.Point(796, 412);
            this.tx請求書計.Name = "tx請求書計";
            this.tx請求書計.ReadOnly = true;
            this.tx請求書計.Size = new System.Drawing.Size(87, 25);
            this.tx請求書計.TabIndex = 27;
            this.tx請求書計.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 川崎近海Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx合計);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx調整金計);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx消費税計);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tx請求書計);
            this.Controls.Add(this.bt新規);
            this.Controls.Add(this.bt登録);
            this.Controls.Add(this.bt請求データ);
            this.Controls.Add(this.bt閉じる);
            this.Controls.Add(this.btクリア);
            this.Controls.Add(this.bt読込);
            this.Controls.Add(this.tx燃料価格調整金);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx計上月);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx計上年);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label1);
            this.Name = "川崎近海Form";
            this.Text = "川崎近海入力一覧";
            this.Load += new System.EventHandler(this.川崎近海Form_Load);
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
        private System.Windows.Forms.TextBox tx燃料価格調整金;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn 積日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 摘要;
        private System.Windows.Forms.DataGridViewTextBoxColumn 車番;
        private System.Windows.Forms.DataGridViewTextBoxColumn 車種;
        private System.Windows.Forms.DataGridViewTextBoxColumn ドアNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIZE;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品目;
        private System.Windows.Forms.DataGridViewTextBoxColumn 運賃;
        private System.Windows.Forms.DataGridViewTextBoxColumn 調整金;
        private System.Windows.Forms.DataGridViewTextBoxColumn 消費税額;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tx請求書計;
    }
}
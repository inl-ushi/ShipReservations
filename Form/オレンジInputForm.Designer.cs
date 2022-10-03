namespace ShipReservations
{
    partial class オレンジInputForm
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
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tx摘要 = new System.Windows.Forms.TextBox();
            this.txタリフ = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tx運転手 = new System.Windows.Forms.TextBox();
            this.txドアNO = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bt入力 = new System.Windows.Forms.Button();
            this.dtp乗船日 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx運賃 = new System.Windows.Forms.TextBox();
            this.tx車番検索 = new System.Windows.Forms.TextBox();
            this.tx車長 = new System.Windows.Forms.TextBox();
            this.tx予約番号 = new System.Windows.Forms.TextBox();
            this.tx区間 = new System.Windows.Forms.TextBox();
            this.tx便 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb利用区分 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tx車番 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(995, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "摘要";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(814, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "タリフ";
            // 
            // tx摘要
            // 
            this.tx摘要.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx摘要.Location = new System.Drawing.Point(999, 89);
            this.tx摘要.Name = "tx摘要";
            this.tx摘要.ReadOnly = true;
            this.tx摘要.Size = new System.Drawing.Size(141, 25);
            this.tx摘要.TabIndex = 26;
            // 
            // txタリフ
            // 
            this.txタリフ.Font = new System.Drawing.Font("メイリオ", 9F);
            this.txタリフ.Location = new System.Drawing.Point(814, 89);
            this.txタリフ.Name = "txタリフ";
            this.txタリフ.ReadOnly = true;
            this.txタリフ.Size = new System.Drawing.Size(73, 25);
            this.txタリフ.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(760, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "運転手";
            // 
            // tx運転手
            // 
            this.tx運転手.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx運転手.Location = new System.Drawing.Point(760, 89);
            this.tx運転手.Name = "tx運転手";
            this.tx運転手.ReadOnly = true;
            this.tx運転手.Size = new System.Drawing.Size(48, 25);
            this.tx運転手.TabIndex = 20;
            // 
            // txドアNO
            // 
            this.txドアNO.Font = new System.Drawing.Font("メイリオ", 9F);
            this.txドアNO.FormattingEnabled = true;
            this.txドアNO.Location = new System.Drawing.Point(679, 89);
            this.txドアNO.Name = "txドアNO";
            this.txドアNO.Size = new System.Drawing.Size(75, 26);
            this.txドアNO.TabIndex = 18;
            this.txドアNO.SelectedIndexChanged += new System.EventHandler(this.txドアNO_SelectedIndexChanged);
            this.txドアNO.Enter += new System.EventHandler(this.txドアNO_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(12, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(351, 36);
            this.label14.TabIndex = 0;
            this.label14.Text = "九西オレンジフェリー入力画面";
            // 
            // bt入力
            // 
            this.bt入力.Location = new System.Drawing.Point(1026, 12);
            this.bt入力.Name = "bt入力";
            this.bt入力.Size = new System.Drawing.Size(115, 40);
            this.bt入力.TabIndex = 27;
            this.bt入力.Text = "入　　力";
            this.bt入力.UseVisualStyleBackColor = true;
            this.bt入力.Click += new System.EventHandler(this.bt入力_Click);
            // 
            // dtp乗船日
            // 
            this.dtp乗船日.CalendarFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp乗船日.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp乗船日.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp乗船日.Location = new System.Drawing.Point(131, 89);
            this.dtp乗船日.Name = "dtp乗船日";
            this.dtp乗船日.Size = new System.Drawing.Size(114, 25);
            this.dtp乗船日.TabIndex = 4;
            this.dtp乗船日.ValueChanged += new System.EventHandler(this.dtp乗船日_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(675, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "ドアNO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(889, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "運賃";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(447, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "車番検索";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(406, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "車長";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(325, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "予約番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(287, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "区間";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(249, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "便";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(127, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "乗船日";
            // 
            // tx運賃
            // 
            this.tx運賃.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx運賃.Location = new System.Drawing.Point(893, 89);
            this.tx運賃.Name = "tx運賃";
            this.tx運賃.Size = new System.Drawing.Size(100, 25);
            this.tx運賃.TabIndex = 24;
            this.tx運賃.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tx運賃.TextChanged += new System.EventHandler(this.tx運賃_TextChanged);
            // 
            // tx車番検索
            // 
            this.tx車番検索.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx車番検索.Location = new System.Drawing.Point(444, 89);
            this.tx車番検索.Name = "tx車番検索";
            this.tx車番検索.Size = new System.Drawing.Size(79, 25);
            this.tx車番検索.TabIndex = 14;
            this.tx車番検索.TextChanged += new System.EventHandler(this.tx車番検索_TextChanged);
            // 
            // tx車長
            // 
            this.tx車長.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx車長.Location = new System.Drawing.Point(407, 89);
            this.tx車長.Name = "tx車長";
            this.tx車長.Size = new System.Drawing.Size(31, 25);
            this.tx車長.TabIndex = 12;
            this.tx車長.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tx車長.TextChanged += new System.EventHandler(this.tx車長_TextChanged);
            this.tx車長.Leave += new System.EventHandler(this.tx車長_Leave);
            // 
            // tx予約番号
            // 
            this.tx予約番号.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx予約番号.Location = new System.Drawing.Point(325, 89);
            this.tx予約番号.Name = "tx予約番号";
            this.tx予約番号.ReadOnly = true;
            this.tx予約番号.Size = new System.Drawing.Size(76, 25);
            this.tx予約番号.TabIndex = 10;
            this.tx予約番号.TabStop = false;
            // 
            // tx区間
            // 
            this.tx区間.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx区間.Location = new System.Drawing.Point(288, 89);
            this.tx区間.Name = "tx区間";
            this.tx区間.ReadOnly = true;
            this.tx区間.Size = new System.Drawing.Size(31, 25);
            this.tx区間.TabIndex = 8;
            this.tx区間.TabStop = false;
            // 
            // tx便
            // 
            this.tx便.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tx便.Location = new System.Drawing.Point(251, 89);
            this.tx便.Name = "tx便";
            this.tx便.ReadOnly = true;
            this.tx便.Size = new System.Drawing.Size(31, 25);
            this.tx便.TabIndex = 6;
            this.tx便.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "利用区分";
            // 
            // cb利用区分
            // 
            this.cb利用区分.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cb利用区分.FormattingEnabled = true;
            this.cb利用区分.Location = new System.Drawing.Point(11, 89);
            this.cb利用区分.Name = "cb利用区分";
            this.cb利用区分.Size = new System.Drawing.Size(114, 26);
            this.cb利用区分.TabIndex = 2;
            this.cb利用区分.SelectedIndexChanged += new System.EventHandler(this.cb利用区分_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(527, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "車番";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tx車番
            // 
            this.tx車番.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tx車番.FormattingEnabled = true;
            this.tx車番.Location = new System.Drawing.Point(529, 88);
            this.tx車番.Name = "tx車番";
            this.tx車番.Size = new System.Drawing.Size(144, 26);
            this.tx車番.TabIndex = 16;
            this.tx車番.SelectedIndexChanged += new System.EventHandler(this.tx車番_SelectedIndexChanged);
            this.tx車番.Enter += new System.EventHandler(this.tx車番_Enter);
            // 
            // オレンジInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 127);
            this.Controls.Add(this.tx車番);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tx摘要);
            this.Controls.Add(this.txタリフ);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tx運転手);
            this.Controls.Add(this.txドアNO);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bt入力);
            this.Controls.Add(this.dtp乗船日);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx運賃);
            this.Controls.Add(this.tx車番検索);
            this.Controls.Add(this.tx車長);
            this.Controls.Add(this.tx予約番号);
            this.Controls.Add(this.tx区間);
            this.Controls.Add(this.tx便);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb利用区分);
            this.Name = "オレンジInputForm";
            this.Text = "オレンジInputForm";
            this.Load += new System.EventHandler(this.オレンジInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tx摘要;
        private System.Windows.Forms.TextBox txタリフ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tx運転手;
        private System.Windows.Forms.ComboBox txドアNO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bt入力;
        private System.Windows.Forms.DateTimePicker dtp乗船日;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx運賃;
        private System.Windows.Forms.TextBox tx車番検索;
        private System.Windows.Forms.TextBox tx車長;
        private System.Windows.Forms.TextBox tx予約番号;
        private System.Windows.Forms.TextBox tx区間;
        private System.Windows.Forms.TextBox tx便;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb利用区分;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tx車番;
    }
}
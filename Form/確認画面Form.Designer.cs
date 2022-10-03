namespace ShipReservations
{
    partial class 確認画面Form
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
            this.btマニュアル１ = new System.Windows.Forms.Button();
            this.btマニュアル２ = new System.Windows.Forms.Button();
            this.bt請求データ保管場所 = new System.Windows.Forms.Button();
            this.bt予約一覧表 = new System.Windows.Forms.Button();
            this.tx計上年 = new System.Windows.Forms.TextBox();
            this.tx計上月 = new System.Windows.Forms.TextBox();
            this.cb営業所 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btマニュアル１
            // 
            this.btマニュアル１.Location = new System.Drawing.Point(281, 47);
            this.btマニュアル１.Name = "btマニュアル１";
            this.btマニュアル１.Size = new System.Drawing.Size(148, 36);
            this.btマニュアル１.TabIndex = 7;
            this.btマニュアル１.Text = "マニュアル 経理用";
            this.btマニュアル１.UseVisualStyleBackColor = true;
            this.btマニュアル１.Click += new System.EventHandler(this.btマニュアル１_Click);
            // 
            // btマニュアル２
            // 
            this.btマニュアル２.Location = new System.Drawing.Point(281, 89);
            this.btマニュアル２.Name = "btマニュアル２";
            this.btマニュアル２.Size = new System.Drawing.Size(148, 36);
            this.btマニュアル２.TabIndex = 8;
            this.btマニュアル２.Text = "マニュアル";
            this.btマニュアル２.UseVisualStyleBackColor = true;
            this.btマニュアル２.Click += new System.EventHandler(this.btマニュアル２_Click);
            // 
            // bt請求データ保管場所
            // 
            this.bt請求データ保管場所.Location = new System.Drawing.Point(281, 131);
            this.bt請求データ保管場所.Name = "bt請求データ保管場所";
            this.bt請求データ保管場所.Size = new System.Drawing.Size(148, 36);
            this.bt請求データ保管場所.TabIndex = 9;
            this.bt請求データ保管場所.Text = "請求データ保管場所";
            this.bt請求データ保管場所.UseVisualStyleBackColor = true;
            this.bt請求データ保管場所.Click += new System.EventHandler(this.bt請求データ保管場所_Click);
            // 
            // bt予約一覧表
            // 
            this.bt予約一覧表.Location = new System.Drawing.Point(281, 173);
            this.bt予約一覧表.Name = "bt予約一覧表";
            this.bt予約一覧表.Size = new System.Drawing.Size(148, 36);
            this.bt予約一覧表.TabIndex = 10;
            this.bt予約一覧表.Text = "予約一覧表";
            this.bt予約一覧表.UseVisualStyleBackColor = true;
            this.bt予約一覧表.Click += new System.EventHandler(this.bt予約一覧表_Click);
            // 
            // tx計上年
            // 
            this.tx計上年.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tx計上年.Location = new System.Drawing.Point(64, 62);
            this.tx計上年.Name = "tx計上年";
            this.tx計上年.Size = new System.Drawing.Size(63, 25);
            this.tx計上年.TabIndex = 2;
            // 
            // tx計上月
            // 
            this.tx計上月.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tx計上月.Location = new System.Drawing.Point(202, 62);
            this.tx計上月.Name = "tx計上月";
            this.tx計上月.Size = new System.Drawing.Size(24, 25);
            this.tx計上月.TabIndex = 4;
            this.tx計上月.Leave += new System.EventHandler(this.tx計上月_Leave);
            // 
            // cb営業所
            // 
            this.cb営業所.Font = new System.Drawing.Font("メイリオ", 9F);
            this.cb営業所.FormattingEnabled = true;
            this.cb営業所.Location = new System.Drawing.Point(159, 93);
            this.cb営業所.Name = "cb営業所";
            this.cb営業所.Size = new System.Drawing.Size(101, 26);
            this.cb営業所.TabIndex = 6;
            this.cb営業所.SelectedIndexChanged += new System.EventHandler(this.cb営業所_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F);
            this.label1.Location = new System.Drawing.Point(109, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "営業所";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F);
            this.label2.Location = new System.Drawing.Point(153, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "計上月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F);
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "計上年";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 15.25F);
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "確認画面";
            // 
            // 確認画面Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 230);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb営業所);
            this.Controls.Add(this.tx計上月);
            this.Controls.Add(this.tx計上年);
            this.Controls.Add(this.bt予約一覧表);
            this.Controls.Add(this.bt請求データ保管場所);
            this.Controls.Add(this.btマニュアル２);
            this.Controls.Add(this.btマニュアル１);
            this.Name = "確認画面Form";
            this.Text = "確認画面";
            this.Load += new System.EventHandler(this.確認画面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btマニュアル１;
        private System.Windows.Forms.Button btマニュアル２;
        private System.Windows.Forms.Button bt請求データ保管場所;
        private System.Windows.Forms.Button bt予約一覧表;
        private System.Windows.Forms.TextBox tx計上年;
        private System.Windows.Forms.TextBox tx計上月;
        private System.Windows.Forms.ComboBox cb営業所;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
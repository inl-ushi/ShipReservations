namespace ShipReservations
{
    partial class mainmenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bt周防灘 = new System.Windows.Forms.Button();
            this.bt川崎近海 = new System.Windows.Forms.Button();
            this.bt阪九 = new System.Windows.Forms.Button();
            this.bt名門フェリー = new System.Windows.Forms.Button();
            this.btさんふらわ = new System.Windows.Forms.Button();
            this.btオレンジ = new System.Windows.Forms.Button();
            this.bt宇和島 = new System.Windows.Forms.Button();
            this.bt燃料調整金設定 = new System.Windows.Forms.Button();
            this.dgv更新履歴 = new System.Windows.Forms.DataGridView();
            this.更新日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.バージョン = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btマニュアル = new System.Windows.Forms.Button();
            this.bt閉じる = new System.Windows.Forms.Button();
            this.bt請求書E = new System.Windows.Forms.Button();
            this.bt共有サーバ = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb部門 = new System.Windows.Forms.ComboBox();
            this.sl接続先 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slユーザ名 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.btオーシャントランス = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv更新履歴)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "フェリー会社選択メニュー";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // bt周防灘
            // 
            this.bt周防灘.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt周防灘.Location = new System.Drawing.Point(18, 98);
            this.bt周防灘.Name = "bt周防灘";
            this.bt周防灘.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt周防灘.Size = new System.Drawing.Size(225, 101);
            this.bt周防灘.TabIndex = 1;
            this.bt周防灘.Text = "周防灘";
            this.bt周防灘.UseVisualStyleBackColor = true;
            this.bt周防灘.Click += new System.EventHandler(this.bt周防灘_Click);
            // 
            // bt川崎近海
            // 
            this.bt川崎近海.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt川崎近海.Location = new System.Drawing.Point(249, 98);
            this.bt川崎近海.Name = "bt川崎近海";
            this.bt川崎近海.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt川崎近海.Size = new System.Drawing.Size(225, 101);
            this.bt川崎近海.TabIndex = 2;
            this.bt川崎近海.Text = "川崎近海";
            this.bt川崎近海.UseVisualStyleBackColor = true;
            this.bt川崎近海.Click += new System.EventHandler(this.bt川崎近海_Click);
            // 
            // bt阪九
            // 
            this.bt阪九.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt阪九.Location = new System.Drawing.Point(480, 98);
            this.bt阪九.Name = "bt阪九";
            this.bt阪九.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt阪九.Size = new System.Drawing.Size(225, 101);
            this.bt阪九.TabIndex = 3;
            this.bt阪九.Text = "阪九";
            this.bt阪九.UseVisualStyleBackColor = true;
            this.bt阪九.Click += new System.EventHandler(this.bt阪九_Click);
            // 
            // bt名門フェリー
            // 
            this.bt名門フェリー.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt名門フェリー.Location = new System.Drawing.Point(711, 98);
            this.bt名門フェリー.Name = "bt名門フェリー";
            this.bt名門フェリー.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt名門フェリー.Size = new System.Drawing.Size(225, 101);
            this.bt名門フェリー.TabIndex = 4;
            this.bt名門フェリー.Text = "名門フェリー";
            this.bt名門フェリー.UseVisualStyleBackColor = true;
            this.bt名門フェリー.Click += new System.EventHandler(this.bt名門フェリー_Click);
            // 
            // btさんふらわ
            // 
            this.btさんふらわ.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btさんふらわ.Location = new System.Drawing.Point(18, 205);
            this.btさんふらわ.Name = "btさんふらわ";
            this.btさんふらわ.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btさんふらわ.Size = new System.Drawing.Size(225, 101);
            this.btさんふらわ.TabIndex = 5;
            this.btさんふらわ.Text = "さんふらわ";
            this.btさんふらわ.UseVisualStyleBackColor = true;
            this.btさんふらわ.Click += new System.EventHandler(this.btさんふらわ_Click);
            // 
            // btオレンジ
            // 
            this.btオレンジ.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btオレンジ.Location = new System.Drawing.Point(249, 205);
            this.btオレンジ.Name = "btオレンジ";
            this.btオレンジ.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btオレンジ.Size = new System.Drawing.Size(225, 101);
            this.btオレンジ.TabIndex = 6;
            this.btオレンジ.Text = "オレンジ";
            this.btオレンジ.UseVisualStyleBackColor = true;
            this.btオレンジ.Click += new System.EventHandler(this.btオレンジ_Click);
            // 
            // bt宇和島
            // 
            this.bt宇和島.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt宇和島.Location = new System.Drawing.Point(480, 205);
            this.bt宇和島.Name = "bt宇和島";
            this.bt宇和島.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt宇和島.Size = new System.Drawing.Size(225, 101);
            this.bt宇和島.TabIndex = 7;
            this.bt宇和島.Text = "宇和島";
            this.bt宇和島.UseVisualStyleBackColor = true;
            this.bt宇和島.Click += new System.EventHandler(this.bt宇和島_Click);
            // 
            // bt燃料調整金設定
            // 
            this.bt燃料調整金設定.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt燃料調整金設定.Location = new System.Drawing.Point(960, 262);
            this.bt燃料調整金設定.Name = "bt燃料調整金設定";
            this.bt燃料調整金設定.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt燃料調整金設定.Size = new System.Drawing.Size(169, 101);
            this.bt燃料調整金設定.TabIndex = 8;
            this.bt燃料調整金設定.Text = "燃料調整金設定";
            this.bt燃料調整金設定.UseVisualStyleBackColor = true;
            this.bt燃料調整金設定.Click += new System.EventHandler(this.bt燃料調整金設定_Click);
            // 
            // dgv更新履歴
            // 
            this.dgv更新履歴.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv更新履歴.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.更新日,
            this.バージョン,
            this.内容});
            this.dgv更新履歴.Location = new System.Drawing.Point(18, 348);
            this.dgv更新履歴.Name = "dgv更新履歴";
            this.dgv更新履歴.RowHeadersVisible = false;
            this.dgv更新履歴.RowTemplate.Height = 21;
            this.dgv更新履歴.Size = new System.Drawing.Size(918, 202);
            this.dgv更新履歴.TabIndex = 9;
            // 
            // 更新日
            // 
            this.更新日.DataPropertyName = "更新日";
            this.更新日.HeaderText = "更新日";
            this.更新日.Name = "更新日";
            // 
            // バージョン
            // 
            this.バージョン.DataPropertyName = "バージョン";
            this.バージョン.HeaderText = "バージョン";
            this.バージョン.Name = "バージョン";
            // 
            // 内容
            // 
            this.内容.DataPropertyName = "内容";
            this.内容.HeaderText = "内容";
            this.内容.Name = "内容";
            this.内容.Width = 700;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(14, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "更新履歴";
            // 
            // btマニュアル
            // 
            this.btマニュアル.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.btマニュアル.Location = new System.Drawing.Point(960, 74);
            this.btマニュアル.Name = "btマニュアル";
            this.btマニュアル.Size = new System.Drawing.Size(169, 41);
            this.btマニュアル.TabIndex = 11;
            this.btマニュアル.Text = "マニュアル";
            this.btマニュアル.UseVisualStyleBackColor = true;
            this.btマニュアル.Click += new System.EventHandler(this.btマニュアル_Click);
            // 
            // bt閉じる
            // 
            this.bt閉じる.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.bt閉じる.Location = new System.Drawing.Point(960, 121);
            this.bt閉じる.Name = "bt閉じる";
            this.bt閉じる.Size = new System.Drawing.Size(169, 41);
            this.bt閉じる.TabIndex = 12;
            this.bt閉じる.Text = "閉じる";
            this.bt閉じる.UseVisualStyleBackColor = true;
            this.bt閉じる.Click += new System.EventHandler(this.bt閉じる_Click);
            // 
            // bt請求書E
            // 
            this.bt請求書E.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.bt請求書E.Location = new System.Drawing.Point(960, 168);
            this.bt請求書E.Name = "bt請求書E";
            this.bt請求書E.Size = new System.Drawing.Size(169, 41);
            this.bt請求書E.TabIndex = 13;
            this.bt請求書E.Text = "請求書Excel";
            this.bt請求書E.UseVisualStyleBackColor = true;
            this.bt請求書E.Click += new System.EventHandler(this.bt請求書E_Click);
            // 
            // bt共有サーバ
            // 
            this.bt共有サーバ.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.bt共有サーバ.Location = new System.Drawing.Point(960, 215);
            this.bt共有サーバ.Name = "bt共有サーバ";
            this.bt共有サーバ.Size = new System.Drawing.Size(169, 41);
            this.bt共有サーバ.TabIndex = 14;
            this.bt共有サーバ.Text = "共有サーバ";
            this.bt共有サーバ.UseVisualStyleBackColor = true;
            this.bt共有サーバ.Click += new System.EventHandler(this.bt共有サーバ_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9F);
            this.label7.Location = new System.Drawing.Point(324, 31);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "利用可能営業所";
            // 
            // cb部門
            // 
            this.cb部門.Font = new System.Drawing.Font("メイリオ", 9F);
            this.cb部門.FormattingEnabled = true;
            this.cb部門.Location = new System.Drawing.Point(421, 28);
            this.cb部門.Name = "cb部門";
            this.cb部門.Size = new System.Drawing.Size(138, 26);
            this.cb部門.TabIndex = 21;
            this.cb部門.SelectedIndexChanged += new System.EventHandler(this.cb部門_SelectedIndexChanged);
            // 
            // sl接続先
            // 
            this.sl接続先.Name = "sl接続先";
            this.sl接続先.Size = new System.Drawing.Size(43, 17);
            this.sl接続先.Text = "接続先";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // slユーザ名
            // 
            this.slユーザ名.Name = "slユーザ名";
            this.slユーザ名.Size = new System.Drawing.Size(47, 17);
            this.slユーザ名.Text = "ユーザ名";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sl接続先,
            this.toolStripStatusLabel2,
            this.slSpacer,
            this.slユーザ名});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1152, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.slSpacer_ItemClicked);
            // 
            // slSpacer
            // 
            this.slSpacer.Name = "slSpacer";
            this.slSpacer.Size = new System.Drawing.Size(1047, 17);
            this.slSpacer.Spring = true;
            // 
            // btオーシャントランス
            // 
            this.btオーシャントランス.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btオーシャントランス.Location = new System.Drawing.Point(711, 205);
            this.btオーシャントランス.Name = "btオーシャントランス";
            this.btオーシャントランス.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btオーシャントランス.Size = new System.Drawing.Size(225, 101);
            this.btオーシャントランス.TabIndex = 25;
            this.btオーシャントランス.Text = "オーシャントランス";
            this.btオーシャントランス.UseVisualStyleBackColor = true;
            this.btオーシャントランス.Click += new System.EventHandler(this.btオーシャントランス_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(963, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "ver 2.1.6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(537, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "※各フェリー会社の入力画面では、白い項目の部分だけを入力してください。グレー部分の入力は必要ありません。";
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btオーシャントランス);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb部門);
            this.Controls.Add(this.bt共有サーバ);
            this.Controls.Add(this.bt請求書E);
            this.Controls.Add(this.bt閉じる);
            this.Controls.Add(this.btマニュアル);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv更新履歴);
            this.Controls.Add(this.bt燃料調整金設定);
            this.Controls.Add(this.bt宇和島);
            this.Controls.Add(this.btオレンジ);
            this.Controls.Add(this.btさんふらわ);
            this.Controls.Add(this.bt名門フェリー);
            this.Controls.Add(this.bt阪九);
            this.Controls.Add(this.bt川崎近海);
            this.Controls.Add(this.bt周防灘);
            this.Controls.Add(this.label1);
            this.Name = "mainmenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgv更新履歴)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt周防灘;
        private System.Windows.Forms.Button bt川崎近海;
        private System.Windows.Forms.Button bt阪九;
        private System.Windows.Forms.Button bt名門フェリー;
        private System.Windows.Forms.Button btさんふらわ;
        private System.Windows.Forms.Button btオレンジ;
        private System.Windows.Forms.Button bt宇和島;
        private System.Windows.Forms.Button bt燃料調整金設定;
        private System.Windows.Forms.DataGridView dgv更新履歴;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btマニュアル;
        private System.Windows.Forms.Button bt閉じる;
        private System.Windows.Forms.Button bt請求書E;
        private System.Windows.Forms.Button bt共有サーバ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb部門;
        private System.Windows.Forms.ToolStripStatusLabel sl接続先;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel slユーザ名;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slSpacer;
        private System.Windows.Forms.Button btオーシャントランス;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 更新日;
        private System.Windows.Forms.DataGridViewTextBoxColumn バージョン;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内容;
        private System.Windows.Forms.Label label4;
    }
}


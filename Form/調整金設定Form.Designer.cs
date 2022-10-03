namespace ShipReservations
{
    partial class 調整金設定Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tx年月 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx調整金 = new System.Windows.Forms.TextBox();
            this.cbフェリー名 = new System.Windows.Forms.ComboBox();
            this.bt追加 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tx長さ = new System.Windows.Forms.TextBox();
            this.bt削除 = new System.Windows.Forms.Button();
            this.訂正 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.年月 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.フェリー名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.長さ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.調整金 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.訂正,
            this.年月,
            this.フェリー名,
            this.長さ,
            this.調整金});
            this.dgv1.Location = new System.Drawing.Point(23, 93);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 21;
            this.dgv1.Size = new System.Drawing.Size(362, 349);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "調整金設定画面";
            // 
            // tx年月
            // 
            this.tx年月.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tx年月.Location = new System.Drawing.Point(406, 133);
            this.tx年月.Name = "tx年月";
            this.tx年月.Size = new System.Drawing.Size(79, 25);
            this.tx年月.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(403, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "年月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(488, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "フェリー名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(665, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "調整金";
            // 
            // tx調整金
            // 
            this.tx調整金.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tx調整金.Location = new System.Drawing.Point(668, 134);
            this.tx調整金.Name = "tx調整金";
            this.tx調整金.Size = new System.Drawing.Size(78, 25);
            this.tx調整金.TabIndex = 3;
            this.tx調整金.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbフェリー名
            // 
            this.cbフェリー名.Font = new System.Drawing.Font("メイリオ", 9F);
            this.cbフェリー名.FormattingEnabled = true;
            this.cbフェリー名.Location = new System.Drawing.Point(491, 133);
            this.cbフェリー名.Name = "cbフェリー名";
            this.cbフェリー名.Size = new System.Drawing.Size(117, 26);
            this.cbフェリー名.TabIndex = 1;
            // 
            // bt追加
            // 
            this.bt追加.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt追加.Location = new System.Drawing.Point(631, 386);
            this.bt追加.Name = "bt追加";
            this.bt追加.Size = new System.Drawing.Size(115, 32);
            this.bt追加.TabIndex = 4;
            this.bt追加.Text = "追加・更新";
            this.bt追加.UseVisualStyleBackColor = true;
            this.bt追加.Click += new System.EventHandler(this.bt追加_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(611, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "長さ";
            // 
            // tx長さ
            // 
            this.tx長さ.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tx長さ.Location = new System.Drawing.Point(614, 134);
            this.tx長さ.Name = "tx長さ";
            this.tx長さ.Size = new System.Drawing.Size(48, 25);
            this.tx長さ.TabIndex = 2;
            this.tx長さ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt削除
            // 
            this.bt削除.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt削除.Location = new System.Drawing.Point(510, 386);
            this.bt削除.Name = "bt削除";
            this.bt削除.Size = new System.Drawing.Size(115, 32);
            this.bt削除.TabIndex = 10;
            this.bt削除.Text = "削　　除";
            this.bt削除.UseVisualStyleBackColor = true;
            this.bt削除.Click += new System.EventHandler(this.bt削除_Click);
            // 
            // 訂正
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "訂正";
            this.訂正.DefaultCellStyle = dataGridViewCellStyle3;
            this.訂正.HeaderText = "訂正";
            this.訂正.Name = "訂正";
            this.訂正.ReadOnly = true;
            this.訂正.UseColumnTextForButtonValue = true;
            this.訂正.Width = 40;
            // 
            // 年月
            // 
            this.年月.DataPropertyName = "年月";
            this.年月.HeaderText = "年月";
            this.年月.Name = "年月";
            this.年月.ReadOnly = true;
            this.年月.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.年月.Width = 60;
            // 
            // フェリー名
            // 
            this.フェリー名.DataPropertyName = "フェリー名";
            this.フェリー名.HeaderText = "フェリー名";
            this.フェリー名.Name = "フェリー名";
            this.フェリー名.ReadOnly = true;
            this.フェリー名.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 長さ
            // 
            this.長さ.DataPropertyName = "長さ";
            this.長さ.HeaderText = "長さ";
            this.長さ.Name = "長さ";
            this.長さ.ReadOnly = true;
            this.長さ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.長さ.Width = 50;
            // 
            // 調整金
            // 
            this.調整金.DataPropertyName = "調整金";
            this.調整金.HeaderText = "調整金";
            this.調整金.Name = "調整金";
            this.調整金.ReadOnly = true;
            this.調整金.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.調整金.Width = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "現在登録されている調整金一覧";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "追加・更新・削除対象データ";
            // 
            // 調整金設定Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt削除);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx長さ);
            this.Controls.Add(this.bt追加);
            this.Controls.Add(this.cbフェリー名);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx調整金);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx年月);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Name = "調整金設定Form";
            this.Text = "調整金設定Form";
            this.Load += new System.EventHandler(this.調整金設定Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx年月;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx調整金;
        private System.Windows.Forms.ComboBox cbフェリー名;
        private System.Windows.Forms.Button bt追加;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx長さ;
        private System.Windows.Forms.Button bt削除;
        private System.Windows.Forms.DataGridViewButtonColumn 訂正;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年月;
        private System.Windows.Forms.DataGridViewTextBoxColumn フェリー名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 長さ;
        private System.Windows.Forms.DataGridViewTextBoxColumn 調整金;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
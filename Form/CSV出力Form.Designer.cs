namespace ShipReservations
{
    partial class CSV出力Form
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
            this.tx計上年月 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCSV出力 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx計上年月
            // 
            this.tx計上年月.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tx計上年月.Location = new System.Drawing.Point(80, 19);
            this.tx計上年月.Name = "tx計上年月";
            this.tx計上年月.Size = new System.Drawing.Size(87, 25);
            this.tx計上年月.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "乗船年月";
            // 
            // btCSV出力
            // 
            this.btCSV出力.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCSV出力.Location = new System.Drawing.Point(230, 14);
            this.btCSV出力.Name = "btCSV出力";
            this.btCSV出力.Size = new System.Drawing.Size(92, 35);
            this.btCSV出力.TabIndex = 4;
            this.btCSV出力.Text = "CSV出力";
            this.btCSV出力.UseVisualStyleBackColor = true;
            this.btCSV出力.Click += new System.EventHandler(this.btCSV出力_Click);
            // 
            // CSV出力Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 61);
            this.Controls.Add(this.btCSV出力);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx計上年月);
            this.Name = "CSV出力Form";
            this.Text = "CSV取込画面";
            this.Load += new System.EventHandler(this.CSV取込Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx計上年月;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCSV出力;
    }
}

namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btDisp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(137, 15);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(738, 28);
            this.tbUrl.TabIndex = 1;
            // 
            // lbTitles
            // 
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 12;
            this.lbTitles.Location = new System.Drawing.Point(18, 245);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(301, 844);
            this.lbTitles.TabIndex = 2;
            this.lbTitles.SelectedIndexChanged += new System.EventHandler(this.lbTitles_SelectedIndexChanged);
            // 
            // btRead
            // 
            this.btRead.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRead.Location = new System.Drawing.Point(893, 15);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(153, 49);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lbDesc
            // 
            this.lbDesc.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDesc.Location = new System.Drawing.Point(333, 294);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(1162, 518);
            this.lbDesc.TabIndex = 6;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbDate.Location = new System.Drawing.Point(334, 222);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 27);
            this.lbDate.TabIndex = 7;
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(1276, 1001);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(219, 85);
            this.wbBrowser.TabIndex = 3;
            // 
            // btDisp
            // 
            this.btDisp.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDisp.Location = new System.Drawing.Point(1080, 15);
            this.btDisp.Name = "btDisp";
            this.btDisp.Size = new System.Drawing.Size(153, 49);
            this.btDisp.TabIndex = 8;
            this.btDisp.Text = "ブラウザ表示";
            this.btDisp.UseVisualStyleBackColor = true;
            this.btDisp.Click += new System.EventHandler(this.btDisp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 1098);
            this.Controls.Add(this.btDisp);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "32021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btDisp;
    }
}


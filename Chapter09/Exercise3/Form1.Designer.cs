
namespace Exercise3 {
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
            this.btStart = new System.Windows.Forms.Button();
            this.tbPath1 = new System.Windows.Forms.TextBox();
            this.tbPath2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(323, 147);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(92, 42);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "実行";
            this.btStart.UseVisualStyleBackColor = true;
            // 
            // tbPath1
            // 
            this.tbPath1.Location = new System.Drawing.Point(195, 97);
            this.tbPath1.Name = "tbPath1";
            this.tbPath1.Size = new System.Drawing.Size(354, 19);
            this.tbPath1.TabIndex = 1;
            // 
            // tbPath2
            // 
            this.tbPath2.Location = new System.Drawing.Point(195, 122);
            this.tbPath2.Name = "tbPath2";
            this.tbPath2.Size = new System.Drawing.Size(354, 19);
            this.tbPath2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 280);
            this.Controls.Add(this.tbPath2);
            this.Controls.Add(this.tbPath1);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbPath1;
        private System.Windows.Forms.TextBox tbPath2;
    }
}



namespace RssReader {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(21, 13);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(87, 36);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(137, 12);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(91, 37);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "進む";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(12, 54);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(1421, 859);
            this.wbBrowser.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 925);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.WebBrowser wbBrowser;
    }
}
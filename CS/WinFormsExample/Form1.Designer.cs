namespace WinFormsExample {
    partial class Form1 {
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
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.myPivotGridControl1 = new WinFormsExample.MyPivotGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // filterControl1
            // 
            this.filterControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filterControl1.Location = new System.Drawing.Point(0, 249);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(637, 108);
            this.filterControl1.TabIndex = 1;
            this.filterControl1.Text = "filterControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(550, 322);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Apply";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // myPivotGridControl1
            // 
            this.myPivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myPivotGridControl1.Name = "myPivotGridControl1";
            this.myPivotGridControl1.Size = new System.Drawing.Size(637, 249);
            this.myPivotGridControl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 357);
            this.Controls.Add(this.myPivotGridControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.filterControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private WinFormsExample.MyPivotGridControl myPivotGridControl1;
    }
}


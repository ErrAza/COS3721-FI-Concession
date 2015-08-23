namespace CommonInterface
{
    partial class frmMain
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
            this.btnThreadProg = new System.Windows.Forms.Button();
            this.btnSynchroProg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThreadProg
            // 
            this.btnThreadProg.Location = new System.Drawing.Point(12, 12);
            this.btnThreadProg.Name = "btnThreadProg";
            this.btnThreadProg.Size = new System.Drawing.Size(122, 108);
            this.btnThreadProg.TabIndex = 0;
            this.btnThreadProg.Text = "ThreadProg";
            this.btnThreadProg.UseVisualStyleBackColor = true;
            this.btnThreadProg.Click += new System.EventHandler(this.btnThreadProg_Click);
            // 
            // btnSynchroProg
            // 
            this.btnSynchroProg.Location = new System.Drawing.Point(154, 12);
            this.btnSynchroProg.Name = "btnSynchroProg";
            this.btnSynchroProg.Size = new System.Drawing.Size(118, 108);
            this.btnSynchroProg.TabIndex = 1;
            this.btnSynchroProg.Text = "SynchroProg";
            this.btnSynchroProg.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.btnSynchroProg);
            this.Controls.Add(this.btnThreadProg);
            this.Name = "frmMain";
            this.Text = "49460951 - COS3721";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThreadProg;
        private System.Windows.Forms.Button btnSynchroProg;
    }
}


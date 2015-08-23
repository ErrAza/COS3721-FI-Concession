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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThreadProg
            // 
            this.btnThreadProg.Location = new System.Drawing.Point(12, 44);
            this.btnThreadProg.Name = "btnThreadProg";
            this.btnThreadProg.Size = new System.Drawing.Size(122, 108);
            this.btnThreadProg.TabIndex = 0;
            this.btnThreadProg.Text = "ThreadProg";
            this.btnThreadProg.UseVisualStyleBackColor = true;
            this.btnThreadProg.Click += new System.EventHandler(this.btnThreadProg_Click);
            // 
            // btnSynchroProg
            // 
            this.btnSynchroProg.Location = new System.Drawing.Point(154, 44);
            this.btnSynchroProg.Name = "btnSynchroProg";
            this.btnSynchroProg.Size = new System.Drawing.Size(118, 108);
            this.btnSynchroProg.TabIndex = 1;
            this.btnSynchroProg.Text = "SynchroProg";
            this.btnSynchroProg.UseVisualStyleBackColor = true;
            this.btnSynchroProg.Click += new System.EventHandler(this.btnSynchroProg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Command Line Arguments for SynchroProg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ready";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSynchroProg);
            this.Controls.Add(this.btnThreadProg);
            this.Name = "frmMain";
            this.Text = "49460951 - COS3721";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThreadProg;
        private System.Windows.Forms.Button btnSynchroProg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


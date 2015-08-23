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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnThreadProg = new System.Windows.Forms.Button();
            this.btnSynchroProg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThreadProg
            // 
            this.btnThreadProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThreadProg.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThreadProg.Image = ((System.Drawing.Image)(resources.GetObject("btnThreadProg.Image")));
            this.btnThreadProg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThreadProg.Location = new System.Drawing.Point(12, 44);
            this.btnThreadProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThreadProg.Name = "btnThreadProg";
            this.btnThreadProg.Size = new System.Drawing.Size(122, 108);
            this.btnThreadProg.TabIndex = 0;
            this.btnThreadProg.Text = "Launch\r\nThreadProg";
            this.btnThreadProg.UseVisualStyleBackColor = true;
            this.btnThreadProg.Click += new System.EventHandler(this.btnThreadProg_Click);
            // 
            // btnSynchroProg
            // 
            this.btnSynchroProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSynchroProg.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSynchroProg.Image = ((System.Drawing.Image)(resources.GetObject("btnSynchroProg.Image")));
            this.btnSynchroProg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSynchroProg.Location = new System.Drawing.Point(154, 44);
            this.btnSynchroProg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSynchroProg.Name = "btnSynchroProg";
            this.btnSynchroProg.Size = new System.Drawing.Size(118, 108);
            this.btnSynchroProg.TabIndex = 1;
            this.btnSynchroProg.Text = "Launch \r\nSynchroProg";
            this.btnSynchroProg.UseVisualStyleBackColor = true;
            this.btnSynchroProg.Click += new System.EventHandler(this.btnSynchroProg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 209);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(37, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Command Line Arguments for SynchroProg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ready";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSynchroProg);
            this.Controls.Add(this.btnThreadProg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "49460951 - COS3721";
            this.Load += new System.EventHandler(this.frmMain_Load);
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


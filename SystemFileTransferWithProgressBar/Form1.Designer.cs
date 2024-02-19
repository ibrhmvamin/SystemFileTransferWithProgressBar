namespace SystemFileTransferWithProgressBar
{
    partial class Form1
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
            this.fromtxtbox = new System.Windows.Forms.TextBox();
            this.totxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.suspendbtn = new System.Windows.Forms.Button();
            this.resumebtn = new System.Windows.Forms.Button();
            this.abortbtn = new System.Windows.Forms.Button();
            this.copybtn = new System.Windows.Forms.Button();
            this.tofilesbtn = new System.Windows.Forms.Button();
            this.filesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromtxtbox
            // 
            this.fromtxtbox.Location = new System.Drawing.Point(198, 135);
            this.fromtxtbox.Name = "fromtxtbox";
            this.fromtxtbox.Size = new System.Drawing.Size(333, 22);
            this.fromtxtbox.TabIndex = 0;
            // 
            // totxtbox
            // 
            this.totxtbox.Location = new System.Drawing.Point(198, 192);
            this.totxtbox.Name = "totxtbox";
            this.totxtbox.Size = new System.Drawing.Size(333, 22);
            this.totxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(146, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(143, 30);
            this.progressBar1.TabIndex = 4;
            // 
            // suspendbtn
            // 
            this.suspendbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.suspendbtn.Location = new System.Drawing.Point(295, 251);
            this.suspendbtn.Name = "suspendbtn";
            this.suspendbtn.Size = new System.Drawing.Size(83, 31);
            this.suspendbtn.TabIndex = 5;
            this.suspendbtn.Text = "suspend";
            this.suspendbtn.UseVisualStyleBackColor = false;
            this.suspendbtn.Click += new System.EventHandler(this.suspendbtn_Click);
            // 
            // resumebtn
            // 
            this.resumebtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resumebtn.Location = new System.Drawing.Point(378, 251);
            this.resumebtn.Name = "resumebtn";
            this.resumebtn.Size = new System.Drawing.Size(91, 31);
            this.resumebtn.TabIndex = 6;
            this.resumebtn.Text = "resume";
            this.resumebtn.UseVisualStyleBackColor = false;
            this.resumebtn.Click += new System.EventHandler(this.resumebtn_Click);
            // 
            // abortbtn
            // 
            this.abortbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.abortbtn.Location = new System.Drawing.Point(470, 251);
            this.abortbtn.Name = "abortbtn";
            this.abortbtn.Size = new System.Drawing.Size(81, 31);
            this.abortbtn.TabIndex = 7;
            this.abortbtn.Text = "abort";
            this.abortbtn.UseVisualStyleBackColor = false;
            this.abortbtn.Click += new System.EventHandler(this.abortbtn_Click);
            // 
            // copybtn
            // 
            this.copybtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.copybtn.Location = new System.Drawing.Point(557, 252);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(81, 30);
            this.copybtn.TabIndex = 8;
            this.copybtn.Text = "Copy";
            this.copybtn.UseVisualStyleBackColor = false;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // tofilesbtn
            // 
            this.tofilesbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tofilesbtn.Location = new System.Drawing.Point(557, 192);
            this.tofilesbtn.Name = "tofilesbtn";
            this.tofilesbtn.Size = new System.Drawing.Size(81, 27);
            this.tofilesbtn.TabIndex = 9;
            this.tofilesbtn.Text = "File...";
            this.tofilesbtn.UseVisualStyleBackColor = false;
            this.tofilesbtn.Click += new System.EventHandler(this.tofilesbtn_Click);
            // 
            // filesbtn
            // 
            this.filesbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.filesbtn.Location = new System.Drawing.Point(557, 135);
            this.filesbtn.Name = "filesbtn";
            this.filesbtn.Size = new System.Drawing.Size(81, 29);
            this.filesbtn.TabIndex = 10;
            this.filesbtn.Text = "File...";
            this.filesbtn.UseVisualStyleBackColor = false;
            this.filesbtn.Click += new System.EventHandler(this.filesbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filesbtn);
            this.Controls.Add(this.tofilesbtn);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.abortbtn);
            this.Controls.Add(this.resumebtn);
            this.Controls.Add(this.suspendbtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totxtbox);
            this.Controls.Add(this.fromtxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromtxtbox;
        private System.Windows.Forms.TextBox totxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button suspendbtn;
        private System.Windows.Forms.Button resumebtn;
        private System.Windows.Forms.Button abortbtn;
        private System.Windows.Forms.Button copybtn;
        private System.Windows.Forms.Button tofilesbtn;
        private System.Windows.Forms.Button filesbtn;
    }
}


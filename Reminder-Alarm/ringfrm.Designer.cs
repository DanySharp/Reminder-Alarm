namespace Reminder_Alarm
{
    partial class ringfrm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnsnooze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(327, 246);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(78, 270);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 52);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnsnooze
            // 
            this.btnsnooze.Location = new System.Drawing.Point(200, 270);
            this.btnsnooze.Name = "btnsnooze";
            this.btnsnooze.Size = new System.Drawing.Size(75, 52);
            this.btnsnooze.TabIndex = 1;
            this.btnsnooze.Text = "Snooze";
            this.btnsnooze.UseVisualStyleBackColor = true;
            this.btnsnooze.Click += new System.EventHandler(this.btnsnooze_Click);
            // 
            // ringfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(328, 334);
            this.Controls.Add(this.btnsnooze);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ringfrm";
            this.Text = "ringfrm";
            this.Load += new System.EventHandler(this.ringfrm_Load);
            this.Shown += new System.EventHandler(this.ringfrm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnsnooze;
    }
}
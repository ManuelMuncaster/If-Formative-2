namespace If_Formative_2
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
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.colorTextbox = new System.Windows.Forms.TextBox();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.shapeTextbox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Location = new System.Drawing.Point(12, 18);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(156, 13);
            this.titleLabel1.TabIndex = 0;
            this.titleLabel1.Text = "Enter g for Green and r for Red:";
            // 
            // colorTextbox
            // 
            this.colorTextbox.Location = new System.Drawing.Point(174, 15);
            this.colorTextbox.Name = "colorTextbox";
            this.colorTextbox.Size = new System.Drawing.Size(100, 20);
            this.colorTextbox.TabIndex = 1;
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Location = new System.Drawing.Point(12, 47);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(67, 13);
            this.titleLabel2.TabIndex = 2;
            this.titleLabel2.Text = "Enter shape:";
            // 
            // shapeTextbox
            // 
            this.shapeTextbox.Location = new System.Drawing.Point(86, 47);
            this.shapeTextbox.Name = "shapeTextbox";
            this.shapeTextbox.Size = new System.Drawing.Size(100, 20);
            this.shapeTextbox.TabIndex = 3;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(199, 47);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter!";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.shapeTextbox);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.colorTextbox);
            this.Controls.Add(this.titleLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.TextBox colorTextbox;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.TextBox shapeTextbox;
        private System.Windows.Forms.Button enterButton;
    }
}


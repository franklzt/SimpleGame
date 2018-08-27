namespace GameLibWindow
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
            this.GenerateSQLITCode = new System.Windows.Forms.Button();
            this.GenerateProtoCode = new System.Windows.Forms.Button();
            this.GenerateMessageCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateSQLITCode
            // 
            this.GenerateSQLITCode.Location = new System.Drawing.Point(56, 54);
            this.GenerateSQLITCode.Name = "GenerateSQLITCode";
            this.GenerateSQLITCode.Size = new System.Drawing.Size(136, 68);
            this.GenerateSQLITCode.TabIndex = 0;
            this.GenerateSQLITCode.Text = "GenerateSQLITCode";
            this.GenerateSQLITCode.UseVisualStyleBackColor = true;
            this.GenerateSQLITCode.Click += new System.EventHandler(this.GenerateSQLITCode_Click);
            // 
            // GenerateProtoCode
            // 
            this.GenerateProtoCode.Location = new System.Drawing.Point(56, 143);
            this.GenerateProtoCode.Name = "GenerateProtoCode";
            this.GenerateProtoCode.Size = new System.Drawing.Size(136, 68);
            this.GenerateProtoCode.TabIndex = 1;
            this.GenerateProtoCode.Text = "GenerateProtoCode";
            this.GenerateProtoCode.UseVisualStyleBackColor = true;
            this.GenerateProtoCode.Click += new System.EventHandler(this.GenerateProtoCode_Click);
            // 
            // GenerateMessageCode
            // 
            this.GenerateMessageCode.Location = new System.Drawing.Point(56, 233);
            this.GenerateMessageCode.Name = "GenerateMessageCode";
            this.GenerateMessageCode.Size = new System.Drawing.Size(136, 68);
            this.GenerateMessageCode.TabIndex = 2;
            this.GenerateMessageCode.Text = "GenerateMessageCode";
            this.GenerateMessageCode.UseVisualStyleBackColor = true;
            this.GenerateMessageCode.Click += new System.EventHandler(this.GenerateMessageCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 399);
            this.Controls.Add(this.GenerateMessageCode);
            this.Controls.Add(this.GenerateProtoCode);
            this.Controls.Add(this.GenerateSQLITCode);
            this.Name = "Form1";
            this.Text = "Code Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateSQLITCode;
        private System.Windows.Forms.Button GenerateProtoCode;
        private System.Windows.Forms.Button GenerateMessageCode;
    }
}


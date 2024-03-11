namespace SuperFileCategorizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdSelectInput = new System.Windows.Forms.Button();
            this.cmdSelectOutput = new System.Windows.Forms.Button();
            this.folderBInput = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSelectInput
            // 
            this.cmdSelectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmdSelectInput.ForeColor = System.Drawing.Color.Navy;
            this.cmdSelectInput.Location = new System.Drawing.Point(57, 38);
            this.cmdSelectInput.Name = "cmdSelectInput";
            this.cmdSelectInput.Size = new System.Drawing.Size(215, 48);
            this.cmdSelectInput.TabIndex = 0;
            this.cmdSelectInput.Text = "Select &Input Directory";
            this.cmdSelectInput.UseVisualStyleBackColor = true;
            this.cmdSelectInput.Click += new System.EventHandler(this.cmdSelectInput_Click);
            // 
            // cmdSelectOutput
            // 
            this.cmdSelectOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmdSelectOutput.ForeColor = System.Drawing.Color.Navy;
            this.cmdSelectOutput.Location = new System.Drawing.Point(57, 147);
            this.cmdSelectOutput.Name = "cmdSelectOutput";
            this.cmdSelectOutput.Size = new System.Drawing.Size(215, 48);
            this.cmdSelectOutput.TabIndex = 1;
            this.cmdSelectOutput.Text = "Select &Output Directory";
            this.cmdSelectOutput.UseVisualStyleBackColor = true;
            this.cmdSelectOutput.Click += new System.EventHandler(this.cmdSelectOutput_Click);
            // 
            // cmdCopy
            // 
            this.cmdCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmdCopy.ForeColor = System.Drawing.Color.Navy;
            this.cmdCopy.Location = new System.Drawing.Point(57, 257);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(215, 48);
            this.cmdCopy.TabIndex = 2;
            this.cmdCopy.Text = "&Copy and Categorize";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(57, 365);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(715, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.cmdSelectOutput);
            this.Controls.Add(this.cmdSelectInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super File Categorizer 2024 by Kostas A. Delimaris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSelectInput;
        private System.Windows.Forms.Button cmdSelectOutput;
        private System.Windows.Forms.FolderBrowserDialog folderBInput;
        private System.Windows.Forms.FolderBrowserDialog folderBOutput;
        private System.Windows.Forms.Button cmdCopy;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}


namespace ImageResizer
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
            this.gbxInputFolder = new System.Windows.Forms.GroupBox();
            this.lblSelectedInputFolder = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.gbxInputFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInputFolder
            // 
            this.gbxInputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInputFolder.Controls.Add(this.lblSelectedInputFolder);
            this.gbxInputFolder.Controls.Add(this.btnSelectFolder);
            this.gbxInputFolder.Location = new System.Drawing.Point(12, 12);
            this.gbxInputFolder.Name = "gbxInputFolder";
            this.gbxInputFolder.Size = new System.Drawing.Size(776, 128);
            this.gbxInputFolder.TabIndex = 0;
            this.gbxInputFolder.TabStop = false;
            this.gbxInputFolder.Text = "Input folder:";
            // 
            // lblSelectedInputFolder
            // 
            this.lblSelectedInputFolder.AutoSize = true;
            this.lblSelectedInputFolder.Location = new System.Drawing.Point(14, 91);
            this.lblSelectedInputFolder.Name = "lblSelectedInputFolder";
            this.lblSelectedInputFolder.Size = new System.Drawing.Size(148, 17);
            this.lblSelectedInputFolder.TabIndex = 1;
            this.lblSelectedInputFolder.Text = "lblSelectedInputFolder";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(17, 34);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(165, 35);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select input folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxInputFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInputFolder.ResumeLayout(false);
            this.gbxInputFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInputFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblSelectedInputFolder;
    }
}


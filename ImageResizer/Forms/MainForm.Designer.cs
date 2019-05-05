namespace ImageResizer
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblSelectedInputFolder = new System.Windows.Forms.Label();
            this.dgvFileGrid = new System.Windows.Forms.DataGridView();
            this.gbxInputFolder = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileGrid)).BeginInit();
            this.gbxInputFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // lblSelectedInputFolder
            // 
            this.lblSelectedInputFolder.AutoSize = true;
            this.lblSelectedInputFolder.Location = new System.Drawing.Point(14, 91);
            this.lblSelectedInputFolder.Name = "lblSelectedInputFolder";
            this.lblSelectedInputFolder.Size = new System.Drawing.Size(148, 17);
            this.lblSelectedInputFolder.TabIndex = 1;
            this.lblSelectedInputFolder.Text = "lblSelectedInputFolder";
            // 
            // dgvFileGrid
            // 
            this.dgvFileGrid.AllowUserToAddRows = false;
            this.dgvFileGrid.AllowUserToDeleteRows = false;
            this.dgvFileGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileGrid.Location = new System.Drawing.Point(17, 119);
            this.dgvFileGrid.MultiSelect = false;
            this.dgvFileGrid.Name = "dgvFileGrid";
            this.dgvFileGrid.ReadOnly = true;
            this.dgvFileGrid.RowTemplate.Height = 24;
            this.dgvFileGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFileGrid.Size = new System.Drawing.Size(650, 292);
            this.dgvFileGrid.TabIndex = 3;
            this.dgvFileGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFileGrid_CellContentClick);
            this.dgvFileGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFileGrid_CellDoubleClick);
            // 
            // gbxInputFolder
            // 
            this.gbxInputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInputFolder.Controls.Add(this.dgvFileGrid);
            this.gbxInputFolder.Controls.Add(this.lblSelectedInputFolder);
            this.gbxInputFolder.Controls.Add(this.btnSelectFolder);
            this.gbxInputFolder.Location = new System.Drawing.Point(12, 36);
            this.gbxInputFolder.Name = "gbxInputFolder";
            this.gbxInputFolder.Size = new System.Drawing.Size(800, 417);
            this.gbxInputFolder.TabIndex = 0;
            this.gbxInputFolder.TabStop = false;
            this.gbxInputFolder.Text = "Input folder:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 544);
            this.Controls.Add(this.gbxInputFolder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileGrid)).EndInit();
            this.gbxInputFolder.ResumeLayout(false);
            this.gbxInputFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblSelectedInputFolder;
        private System.Windows.Forms.DataGridView dgvFileGrid;
        private System.Windows.Forms.GroupBox gbxInputFolder;
    }
}


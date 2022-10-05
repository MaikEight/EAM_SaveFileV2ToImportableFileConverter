namespace EAM_SaveFileV2ToImportableFileConverter
{
    partial class UILoadAccounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lWarning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lIcons8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select your Exalt Account Manager v2.0.8 \r\nsave file";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lWarning
            // 
            this.lWarning.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWarning.ForeColor = System.Drawing.Color.Crimson;
            this.lWarning.Location = new System.Drawing.Point(0, 110);
            this.lWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWarning.Name = "lWarning";
            this.lWarning.Size = new System.Drawing.Size(384, 27);
            this.lWarning.TabIndex = 3;
            this.lWarning.Text = "Failed to parse save file!";
            this.lWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lWarning.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EAM Convertion Tool by Maik8";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Image = global::EAM_SaveFileV2ToImportableFileConverter.Properties.Resources.icons8_more_24px;
            this.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFile.Location = new System.Drawing.Point(129, 81);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(126, 27);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Choose save file";
            this.btnSelectFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lIcons8
            // 
            this.lIcons8.AutoSize = true;
            this.lIcons8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lIcons8.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIcons8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lIcons8.Location = new System.Drawing.Point(-2, 136);
            this.lIcons8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIcons8.Name = "lIcons8";
            this.lIcons8.Size = new System.Drawing.Size(165, 13);
            this.lIcons8.TabIndex = 10;
            this.lIcons8.Text = "Most Icons are provided by Icons8";
            this.lIcons8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lIcons8.Click += new System.EventHandler(this.lIcons8_Click);
            // 
            // UILoadAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lIcons8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lWarning);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UILoadAccounts";
            this.Size = new System.Drawing.Size(384, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lWarning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lIcons8;
    }
}

namespace Instagram_3._0
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.buttonClearPictureBox = new System.Windows.Forms.Button();
            this.listBoxFilters = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(234, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(482, 364);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadPicture.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(94, 50);
            this.buttonLoadPicture.TabIndex = 1;
            this.buttonLoadPicture.Text = "Load Picture";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            this.buttonLoadPicture.Click += new System.EventHandler(this.LoadPicture);
            // 
            // buttonClearPictureBox
            // 
            this.buttonClearPictureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearPictureBox.Location = new System.Drawing.Point(122, 12);
            this.buttonClearPictureBox.Name = "buttonClearPictureBox";
            this.buttonClearPictureBox.Size = new System.Drawing.Size(94, 50);
            this.buttonClearPictureBox.TabIndex = 2;
            this.buttonClearPictureBox.Text = "Clear Area";
            this.buttonClearPictureBox.UseVisualStyleBackColor = true;
            this.buttonClearPictureBox.Click += new System.EventHandler(this.ClearPictureBox);
            // 
            // listBoxFilters
            // 
            this.listBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFilters.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxFilters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFilters.FormattingEnabled = true;
            this.listBoxFilters.ItemHeight = 24;
            this.listBoxFilters.Location = new System.Drawing.Point(12, 88);
            this.listBoxFilters.Name = "listBoxFilters";
            this.listBoxFilters.Size = new System.Drawing.Size(204, 288);
            this.listBoxFilters.TabIndex = 3;
            this.listBoxFilters.DoubleClick += new System.EventHandler(this.ApplyFilter);
            this.listBoxFilters.MouseHover += new System.EventHandler(this.DetermineHoveredItem);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(728, 388);
            this.Controls.Add(this.listBoxFilters);
            this.Controls.Add(this.buttonClearPictureBox);
            this.Controls.Add(this.buttonLoadPicture);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram 3.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.Button buttonClearPictureBox;
        private System.Windows.Forms.ListBox listBoxFilters;
    }
}


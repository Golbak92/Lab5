namespace Lab5
{
    partial class ImageScraper
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
            this.buttonSaveImages = new System.Windows.Forms.Button();
            this.textBoxURLInput = new System.Windows.Forms.TextBox();
            this.buttonExtractImages = new System.Windows.Forms.Button();
            this.labelNumberOfImages = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaveImages
            // 
            this.buttonSaveImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveImages.Location = new System.Drawing.Point(581, 422);
            this.buttonSaveImages.Name = "buttonSaveImages";
            this.buttonSaveImages.Size = new System.Drawing.Size(82, 20);
            this.buttonSaveImages.TabIndex = 0;
            this.buttonSaveImages.Text = "Save Images";
            this.buttonSaveImages.UseVisualStyleBackColor = true;
            this.buttonSaveImages.Click += new System.EventHandler(this.buttonSaveImages_Click);
            // 
            // textBoxURLInput
            // 
            this.textBoxURLInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURLInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxURLInput.Name = "textBoxURLInput";
            this.textBoxURLInput.Size = new System.Drawing.Size(563, 20);
            this.textBoxURLInput.TabIndex = 1;
            // 
            // buttonExtractImages
            // 
            this.buttonExtractImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExtractImages.Location = new System.Drawing.Point(581, 12);
            this.buttonExtractImages.Name = "buttonExtractImages";
            this.buttonExtractImages.Size = new System.Drawing.Size(82, 20);
            this.buttonExtractImages.TabIndex = 2;
            this.buttonExtractImages.Text = "Extract";
            this.buttonExtractImages.UseVisualStyleBackColor = true;
            this.buttonExtractImages.Click += new System.EventHandler(this.buttonExtractImageURLS_Click);
            // 
            // labelNumberOfImages
            // 
            this.labelNumberOfImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumberOfImages.AutoSize = true;
            this.labelNumberOfImages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfImages.Location = new System.Drawing.Point(12, 422);
            this.labelNumberOfImages.Name = "labelNumberOfImages";
            this.labelNumberOfImages.Size = new System.Drawing.Size(0, 19);
            this.labelNumberOfImages.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(651, 381);
            this.textBox1.TabIndex = 5;
            // 
            // ImageScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 454);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNumberOfImages);
            this.Controls.Add(this.buttonExtractImages);
            this.Controls.Add(this.textBoxURLInput);
            this.Controls.Add(this.buttonSaveImages);
            this.Name = "ImageScraper";
            this.Text = "ImageScraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveImages;
        private System.Windows.Forms.TextBox textBoxURLInput;
        private System.Windows.Forms.Button buttonExtractImages;
        private System.Windows.Forms.Label labelNumberOfImages;
        private System.Windows.Forms.TextBox textBox1;
    }
}


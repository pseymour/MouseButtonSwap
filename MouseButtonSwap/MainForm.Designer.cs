namespace MouseButtonSwap
{
    /// <summary>
    /// This class defines the main form for the application.
    /// </summary>
    public partial class MainForm
    {
        /// <summary>
        /// Button to swap mouse button configuration.
        /// </summary>
        private System.Windows.Forms.Button btnSwap;

        /// <summary>
        /// A picture of a computer mouse.
        /// </summary>
        private System.Windows.Forms.PictureBox mousePicture;

        /// <summary>
        /// The mouse's current status (left- or right-handed).
        /// </summary>
        private System.Windows.Forms.Label statusLabel;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSwap = new System.Windows.Forms.Button();
            this.mousePicture = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mousePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwap
            // 
            this.btnSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwap.Location = new System.Drawing.Point(233, 11);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(145, 51);
            this.btnSwap.TabIndex = 0;
            this.btnSwap.Text = "&Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SwapButtonMouseUp);
            // 
            // mousePicture
            // 
            this.mousePicture.Image = global::MouseButtonSwap.Properties.Resources.Mouse;
            this.mousePicture.InitialImage = global::MouseButtonSwap.Properties.Resources.Mouse;
            this.mousePicture.Location = new System.Drawing.Point(12, 12);
            this.mousePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mousePicture.Name = "mousePicture";
            this.mousePicture.Size = new System.Drawing.Size(48, 48);
            this.mousePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mousePicture.TabIndex = 1;
            this.mousePicture.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(69, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(157, 48);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "mouse status here";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 70);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.mousePicture);
            this.Controls.Add(this.btnSwap);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mouse Button Swap";
            ((System.ComponentModel.ISupportInitialize)(this.mousePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}


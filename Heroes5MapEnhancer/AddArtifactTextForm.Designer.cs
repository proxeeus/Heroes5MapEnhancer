namespace Heroes5MapEnhancer
{
    partial class AddArtifactTextForm
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
            this.artifactTextTextBox = new System.Windows.Forms.TextBox();
            this.addArtifactTextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // artifactTextTextBox
            // 
            this.artifactTextTextBox.Location = new System.Drawing.Point(3, 12);
            this.artifactTextTextBox.Multiline = true;
            this.artifactTextTextBox.Name = "artifactTextTextBox";
            this.artifactTextTextBox.Size = new System.Drawing.Size(380, 149);
            this.artifactTextTextBox.TabIndex = 0;
            // 
            // addArtifactTextButton
            // 
            this.addArtifactTextButton.Location = new System.Drawing.Point(308, 167);
            this.addArtifactTextButton.Name = "addArtifactTextButton";
            this.addArtifactTextButton.Size = new System.Drawing.Size(75, 23);
            this.addArtifactTextButton.TabIndex = 1;
            this.addArtifactTextButton.Text = "Add";
            this.addArtifactTextButton.UseVisualStyleBackColor = true;
            // 
            // AddArtifactTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 197);
            this.Controls.Add(this.addArtifactTextButton);
            this.Controls.Add(this.artifactTextTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddArtifactTextForm";
            this.Text = "Add a text for this artifact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox artifactTextTextBox;
        private System.Windows.Forms.Button addArtifactTextButton;
    }
}
namespace Heroes5MapEnhancer
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
            this.button2 = new System.Windows.Forms.Button();
            this.artifactTabPage = new System.Windows.Forms.TabPage();
            this.artifactTextsListBox = new System.Windows.Forms.ListBox();
            this.artifactSoundTextBox = new System.Windows.Forms.TextBox();
            this.artifactSoundLabel = new System.Windows.Forms.Label();
            this.artifactIdLabel = new System.Windows.Forms.Label();
            this.artifactsComboBox = new System.Windows.Forms.ComboBox();
            this.databaseTabControl = new System.Windows.Forms.TabControl();
            this.addArtifactTextButton = new System.Windows.Forms.Button();
            this.artifactTabPage.SuspendLayout();
            this.databaseTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tests";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // artifactTabPage
            // 
            this.artifactTabPage.Controls.Add(this.addArtifactTextButton);
            this.artifactTabPage.Controls.Add(this.artifactTextsListBox);
            this.artifactTabPage.Controls.Add(this.artifactSoundTextBox);
            this.artifactTabPage.Controls.Add(this.artifactSoundLabel);
            this.artifactTabPage.Controls.Add(this.artifactIdLabel);
            this.artifactTabPage.Controls.Add(this.artifactsComboBox);
            this.artifactTabPage.Location = new System.Drawing.Point(4, 22);
            this.artifactTabPage.Name = "artifactTabPage";
            this.artifactTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.artifactTabPage.Size = new System.Drawing.Size(592, 287);
            this.artifactTabPage.TabIndex = 0;
            this.artifactTabPage.Text = "Artifacts";
            this.artifactTabPage.UseVisualStyleBackColor = true;
            // 
            // artifactTextsListBox
            // 
            this.artifactTextsListBox.FormattingEnabled = true;
            this.artifactTextsListBox.HorizontalScrollbar = true;
            this.artifactTextsListBox.Location = new System.Drawing.Point(9, 96);
            this.artifactTextsListBox.Name = "artifactTextsListBox";
            this.artifactTextsListBox.Size = new System.Drawing.Size(458, 147);
            this.artifactTextsListBox.TabIndex = 5;
            // 
            // artifactSoundTextBox
            // 
            this.artifactSoundTextBox.Location = new System.Drawing.Point(234, 39);
            this.artifactSoundTextBox.Name = "artifactSoundTextBox";
            this.artifactSoundTextBox.Size = new System.Drawing.Size(233, 20);
            this.artifactSoundTextBox.TabIndex = 3;
            // 
            // artifactSoundLabel
            // 
            this.artifactSoundLabel.AutoSize = true;
            this.artifactSoundLabel.Location = new System.Drawing.Point(231, 22);
            this.artifactSoundLabel.Name = "artifactSoundLabel";
            this.artifactSoundLabel.Size = new System.Drawing.Size(41, 13);
            this.artifactSoundLabel.TabIndex = 2;
            this.artifactSoundLabel.Text = "Sound:";
            // 
            // artifactIdLabel
            // 
            this.artifactIdLabel.AutoSize = true;
            this.artifactIdLabel.Location = new System.Drawing.Point(6, 22);
            this.artifactIdLabel.Name = "artifactIdLabel";
            this.artifactIdLabel.Size = new System.Drawing.Size(57, 13);
            this.artifactIdLabel.TabIndex = 1;
            this.artifactIdLabel.Text = "Artifact ID:";
            // 
            // artifactsComboBox
            // 
            this.artifactsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.artifactsComboBox.FormattingEnabled = true;
            this.artifactsComboBox.Location = new System.Drawing.Point(6, 38);
            this.artifactsComboBox.Name = "artifactsComboBox";
            this.artifactsComboBox.Size = new System.Drawing.Size(202, 21);
            this.artifactsComboBox.TabIndex = 0;
            this.artifactsComboBox.SelectedIndexChanged += new System.EventHandler(this.artifactsComboBox_SelectedIndexChanged);
            // 
            // databaseTabControl
            // 
            this.databaseTabControl.Controls.Add(this.artifactTabPage);
            this.databaseTabControl.Location = new System.Drawing.Point(12, 12);
            this.databaseTabControl.Name = "databaseTabControl";
            this.databaseTabControl.SelectedIndex = 0;
            this.databaseTabControl.Size = new System.Drawing.Size(600, 313);
            this.databaseTabControl.TabIndex = 2;
            // 
            // addArtifactTextButton
            // 
            this.addArtifactTextButton.Location = new System.Drawing.Point(473, 96);
            this.addArtifactTextButton.Name = "addArtifactTextButton";
            this.addArtifactTextButton.Size = new System.Drawing.Size(75, 23);
            this.addArtifactTextButton.TabIndex = 6;
            this.addArtifactTextButton.Text = "Add text";
            this.addArtifactTextButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 366);
            this.Controls.Add(this.databaseTabControl);
            this.Controls.Add(this.button2);
            this.Name = "MainForm";
            this.Text = "Heroes of Might & Magic V Tribes of the East - Flavorizator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.artifactTabPage.ResumeLayout(false);
            this.artifactTabPage.PerformLayout();
            this.databaseTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage artifactTabPage;
        private System.Windows.Forms.TabControl databaseTabControl;
        private System.Windows.Forms.Label artifactIdLabel;
        private System.Windows.Forms.ComboBox artifactsComboBox;
        private System.Windows.Forms.TextBox artifactSoundTextBox;
        private System.Windows.Forms.Label artifactSoundLabel;
        private System.Windows.Forms.ListBox artifactTextsListBox;
        private System.Windows.Forms.Button addArtifactTextButton;
    }
}


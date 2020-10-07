namespace MTGListerSorter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPanel = new System.Windows.Forms.Panel();
            this.fillFormPanel = new System.Windows.Forms.Panel();
            this.overPanel = new System.Windows.Forms.Panel();
            this.overOptionsPanel = new System.Windows.Forms.Panel();
            this.overOptionsListbox = new System.Windows.Forms.ListBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.numberPlacingCheckbox = new System.Windows.Forms.CheckBox();
            this.reorderCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.overPanel.SuspendLayout();
            this.overOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.Location = new System.Drawing.Point(12, 12);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(600, 550);
            this.listPanel.TabIndex = 0;
            // 
            // fillFormPanel
            // 
            this.fillFormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fillFormPanel.AutoScroll = true;
            this.fillFormPanel.Location = new System.Drawing.Point(618, 12);
            this.fillFormPanel.Name = "fillFormPanel";
            this.fillFormPanel.Size = new System.Drawing.Size(600, 550);
            this.fillFormPanel.TabIndex = 0;
            // 
            // overPanel
            // 
            this.overPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overPanel.Controls.Add(this.overOptionsPanel);
            this.overPanel.Controls.Add(this.applyButton);
            this.overPanel.Controls.Add(this.cancelButton);
            this.overPanel.Controls.Add(this.numberPlacingCheckbox);
            this.overPanel.Controls.Add(this.reorderCheckBox);
            this.overPanel.Controls.Add(this.textBox);
            this.overPanel.Controls.Add(this.textLabel);
            this.overPanel.Location = new System.Drawing.Point(440, 100);
            this.overPanel.Name = "overPanel";
            this.overPanel.Size = new System.Drawing.Size(350, 80);
            this.overPanel.TabIndex = 1;
            // 
            // overOptionsPanel
            // 
            this.overOptionsPanel.Controls.Add(this.overOptionsListbox);
            this.overOptionsPanel.Location = new System.Drawing.Point(-1, 41);
            this.overOptionsPanel.Name = "overOptionsPanel";
            this.overOptionsPanel.Size = new System.Drawing.Size(350, 17);
            this.overOptionsPanel.TabIndex = 5;
            // 
            // overOptionsListbox
            // 
            this.overOptionsListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overOptionsListbox.FormattingEnabled = true;
            this.overOptionsListbox.ItemHeight = 15;
            this.overOptionsListbox.Location = new System.Drawing.Point(0, 0);
            this.overOptionsListbox.Name = "overOptionsListbox";
            this.overOptionsListbox.Size = new System.Drawing.Size(350, 17);
            this.overOptionsListbox.TabIndex = 0;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(-1, 51);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(80, 51);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // numberPlacingCheckbox
            // 
            this.numberPlacingCheckbox.AutoSize = true;
            this.numberPlacingCheckbox.Location = new System.Drawing.Point(179, 51);
            this.numberPlacingCheckbox.Name = "numberPlacingCheckbox";
            this.numberPlacingCheckbox.Size = new System.Drawing.Size(87, 19);
            this.numberPlacingCheckbox.TabIndex = 2;
            this.numberPlacingCheckbox.Text = "Numbering";
            this.numberPlacingCheckbox.UseVisualStyleBackColor = true;
            // 
            // reorderCheckBox
            // 
            this.reorderCheckBox.AutoSize = true;
            this.reorderCheckBox.Location = new System.Drawing.Point(267, 51);
            this.reorderCheckBox.Name = "reorderCheckBox";
            this.reorderCheckBox.Size = new System.Drawing.Size(67, 19);
            this.reorderCheckBox.TabIndex = 2;
            this.reorderCheckBox.Text = "Reorder";
            this.reorderCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(-1, 22);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(350, 23);
            this.textBox.TabIndex = 1;
            // 
            // textLabel
            // 
            this.textLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLabel.Location = new System.Drawing.Point(-1, -1);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(350, 20);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "label1";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 574);
            this.Controls.Add(this.overPanel);
            this.Controls.Add(this.fillFormPanel);
            this.Controls.Add(this.listPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.overPanel.ResumeLayout(false);
            this.overPanel.PerformLayout();
            this.overOptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Panel fillFormPanel;
        private System.Windows.Forms.Panel overPanel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox numberPlacingCheckbox;
        private System.Windows.Forms.CheckBox reorderCheckBox;
        private System.Windows.Forms.Panel overOptionsPanel;
        private System.Windows.Forms.ListBox overOptionsListbox;
    }
}


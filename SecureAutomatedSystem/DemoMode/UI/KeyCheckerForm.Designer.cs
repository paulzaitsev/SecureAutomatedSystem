namespace SecureAutomatedSystem.DemoMode.UI {
    partial class KeyCheckerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.keyField = new System.Windows.Forms.TextBox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.demoModecb = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyField
            // 
            this.keyField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyField.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyField.Location = new System.Drawing.Point(3, 3);
            this.keyField.Name = "keyField";
            this.keyField.Size = new System.Drawing.Size(339, 22);
            this.keyField.TabIndex = 0;
            this.keyField.TabStop = false;
            this.keyField.Text = "Enter license key";
            this.keyField.TextChanged += new System.EventHandler(this.keyField_TextChanged);
            this.keyField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyField_MouseDown);
            // 
            // iconBox
            // 
            this.iconBox.Location = new System.Drawing.Point(348, 3);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(23, 21);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconBox.TabIndex = 4;
            this.iconBox.TabStop = false;
            this.iconBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconBox_MouseClick);
            // 
            // demoModecb
            // 
            this.demoModecb.AutoSize = true;
            this.demoModecb.Location = new System.Drawing.Point(3, 31);
            this.demoModecb.Name = "demoModecb";
            this.demoModecb.Size = new System.Drawing.Size(83, 17);
            this.demoModecb.TabIndex = 5;
            this.demoModecb.Text = "Demo mode";
            this.demoModecb.UseVisualStyleBackColor = true;
            this.demoModecb.CheckedChanged += new System.EventHandler(this.demoModecb_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.54494F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.45506F));
            this.tableLayoutPanel1.Controls.Add(this.keyField, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.demoModecb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.iconBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 82);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseClick_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(348, 55);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(267, 55);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // KeyCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 162);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyCheckerForm";
            this.Text = "License key";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KeyCheckerForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox keyField;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.CheckBox demoModecb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}
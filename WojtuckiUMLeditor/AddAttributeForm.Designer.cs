namespace WojtuckiUMLeditor
{
    partial class AddAttributeForm
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
            labelAttributeName = new Label();
            labelDataType = new Label();
            textBoxAttributeName = new TextBox();
            textBoxDataType = new TextBox();
            buttonAttributeOK = new Button();
            buttonAttributeCancel = new Button();
            SuspendLayout();
            // 
            // labelAttributeName
            // 
            labelAttributeName.AutoSize = true;
            labelAttributeName.Location = new Point(32, 18);
            labelAttributeName.Name = "labelAttributeName";
            labelAttributeName.Size = new Size(39, 15);
            labelAttributeName.TabIndex = 0;
            labelAttributeName.Text = "Name";
            // 
            // labelDataType
            // 
            labelDataType.AutoSize = true;
            labelDataType.Location = new Point(32, 41);
            labelDataType.Name = "labelDataType";
            labelDataType.Size = new Size(57, 15);
            labelDataType.TabIndex = 1;
            labelDataType.Text = "Data type";
            // 
            // textBoxAttributeName
            // 
            textBoxAttributeName.Location = new Point(109, 15);
            textBoxAttributeName.Name = "textBoxAttributeName";
            textBoxAttributeName.Size = new Size(100, 23);
            textBoxAttributeName.TabIndex = 2;
            // 
            // textBoxDataType
            // 
            textBoxDataType.Location = new Point(109, 41);
            textBoxDataType.Name = "textBoxDataType";
            textBoxDataType.Size = new Size(100, 23);
            textBoxDataType.TabIndex = 3;
            // 
            // buttonAttributeOK
            // 
            buttonAttributeOK.Location = new Point(29, 78);
            buttonAttributeOK.Name = "buttonAttributeOK";
            buttonAttributeOK.Size = new Size(75, 23);
            buttonAttributeOK.TabIndex = 4;
            buttonAttributeOK.Text = "OK";
            buttonAttributeOK.UseVisualStyleBackColor = true;
            buttonAttributeOK.Click += buttonAttributeOK_Click;
            // 
            // buttonAttributeCancel
            // 
            buttonAttributeCancel.Location = new Point(110, 78);
            buttonAttributeCancel.Name = "buttonAttributeCancel";
            buttonAttributeCancel.Size = new Size(75, 23);
            buttonAttributeCancel.TabIndex = 5;
            buttonAttributeCancel.Text = "Cancel";
            buttonAttributeCancel.UseVisualStyleBackColor = true;
            buttonAttributeCancel.Click += buttonAttributeCancel_Click;
            // 
            // AddAttributeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 116);
            Controls.Add(buttonAttributeCancel);
            Controls.Add(buttonAttributeOK);
            Controls.Add(textBoxDataType);
            Controls.Add(textBoxAttributeName);
            Controls.Add(labelDataType);
            Controls.Add(labelAttributeName);
            Name = "AddAttributeForm";
            Text = "AddAttributeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAttributeName;
        private Label labelDataType;
        private TextBox textBoxAttributeName;
        private TextBox textBoxDataType;
        private Button buttonAttributeOK;
        private Button buttonAttributeCancel;
    }
}
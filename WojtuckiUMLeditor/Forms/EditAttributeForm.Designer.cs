namespace WojtuckiUMLeditor
{
    partial class EditAttributeForm
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
            listBoxAttributes = new ListBox();
            textBoxAttributeName = new TextBox();
            textBoxAttributeDataType = new TextBox();
            buttonOK = new Button();
            buttonDelete = new Button();
            buttonClose = new Button();
            labelName = new Label();
            labelDataType = new Label();
            SuspendLayout();
            // 
            // listBoxAttributes
            // 
            listBoxAttributes.FormattingEnabled = true;
            listBoxAttributes.ItemHeight = 15;
            listBoxAttributes.Location = new Point(23, 23);
            listBoxAttributes.Name = "listBoxAttributes";
            listBoxAttributes.Size = new Size(120, 94);
            listBoxAttributes.TabIndex = 1;
            // 
            // textBoxAttributeName
            // 
            textBoxAttributeName.Location = new Point(169, 84);
            textBoxAttributeName.Name = "textBoxAttributeName";
            textBoxAttributeName.Size = new Size(100, 23);
            textBoxAttributeName.TabIndex = 2;
            // 
            // textBoxAttributeDataType
            // 
            textBoxAttributeDataType.Location = new Point(169, 33);
            textBoxAttributeDataType.Name = "textBoxAttributeDataType";
            textBoxAttributeDataType.Size = new Size(100, 23);
            textBoxAttributeDataType.TabIndex = 3;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(23, 137);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(100, 30);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(129, 137);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 30);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(23, 173);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(100, 30);
            buttonClose.TabIndex = 6;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(196, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 7;
            labelName.Text = "Name";
            // 
            // labelDataType
            // 
            labelDataType.AutoSize = true;
            labelDataType.Location = new Point(183, 66);
            labelDataType.Name = "labelDataType";
            labelDataType.Size = new Size(56, 15);
            labelDataType.TabIndex = 8;
            labelDataType.Text = "DataType";
            // 
            // EditAttributeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 223);
            Controls.Add(labelDataType);
            Controls.Add(labelName);
            Controls.Add(buttonClose);
            Controls.Add(buttonDelete);
            Controls.Add(buttonOK);
            Controls.Add(textBoxAttributeDataType);
            Controls.Add(textBoxAttributeName);
            Controls.Add(listBoxAttributes);
            Name = "EditAttributeForm";
            Text = "EditAttributeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxAttributes;
        private TextBox textBoxAttributeName;
        private TextBox textBoxAttributeDataType;
        private Button buttonOK;
        private Button buttonDelete;
        private Button buttonClose;
        private Label labelName;
        private Label labelDataType;
    }
}
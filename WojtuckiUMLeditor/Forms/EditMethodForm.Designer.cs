namespace WojtuckiUMLeditor.Forms
{
    partial class EditMethodForm
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
            listBoxMethods = new ListBox();
            buttonOK = new Button();
            buttonClose = new Button();
            buttonDelete = new Button();
            labelName = new Label();
            labelReturnType = new Label();
            textBoxName = new TextBox();
            textBoxReturnType = new TextBox();
            SuspendLayout();
            // 
            // listBoxMethods
            // 
            listBoxMethods.FormattingEnabled = true;
            listBoxMethods.ItemHeight = 15;
            listBoxMethods.Location = new Point(12, 12);
            listBoxMethods.Name = "listBoxMethods";
            listBoxMethods.Size = new Size(120, 94);
            listBoxMethods.TabIndex = 0;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(12, 125);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(100, 30);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 161);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(100, 30);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(118, 125);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 30);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(192, 11);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 4;
            labelName.Text = "Name";
            // 
            // labelReturnType
            // 
            labelReturnType.AutoSize = true;
            labelReturnType.Location = new Point(178, 64);
            labelReturnType.Name = "labelReturnType";
            labelReturnType.Size = new Size(68, 15);
            labelReturnType.TabIndex = 5;
            labelReturnType.Text = "Return type";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(160, 29);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 6;
            // 
            // textBoxReturnType
            // 
            textBoxReturnType.Location = new Point(160, 83);
            textBoxReturnType.Name = "textBoxReturnType";
            textBoxReturnType.Size = new Size(100, 23);
            textBoxReturnType.TabIndex = 7;
            // 
            // EditMethodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 201);
            Controls.Add(textBoxReturnType);
            Controls.Add(textBoxName);
            Controls.Add(labelReturnType);
            Controls.Add(labelName);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClose);
            Controls.Add(buttonOK);
            Controls.Add(listBoxMethods);
            Name = "EditMethodForm";
            Text = "EditMethodForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMethods;
        private Button buttonOK;
        private Button buttonClose;
        private Button buttonDelete;
        private Label labelName;
        private Label labelReturnType;
        private TextBox textBoxName;
        private TextBox textBoxReturnType;
    }
}
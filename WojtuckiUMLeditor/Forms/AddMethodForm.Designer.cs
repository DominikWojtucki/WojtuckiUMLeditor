namespace WojtuckiUMLeditor.Forms
{
    partial class AddMethodForm
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
            buttonOK = new Button();
            buttonCancel = new Button();
            labelName = new Label();
            labelReturnType = new Label();
            textBoxName = new TextBox();
            textBoxReturnType = new TextBox();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(21, 81);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(111, 81);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(29, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // labelReturnType
            // 
            labelReturnType.AutoSize = true;
            labelReturnType.Location = new Point(28, 42);
            labelReturnType.Name = "labelReturnType";
            labelReturnType.Size = new Size(68, 15);
            labelReturnType.TabIndex = 3;
            labelReturnType.Text = "Return type";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(111, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxReturnType
            // 
            textBoxReturnType.Location = new Point(111, 39);
            textBoxReturnType.Name = "textBoxReturnType";
            textBoxReturnType.Size = new Size(100, 23);
            textBoxReturnType.TabIndex = 5;
            // 
            // AddMethodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 118);
            Controls.Add(textBoxReturnType);
            Controls.Add(textBoxName);
            Controls.Add(labelReturnType);
            Controls.Add(labelName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Name = "AddMethodForm";
            Text = "AddMethodForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private Button buttonCancel;
        private Label labelName;
        private Label labelReturnType;
        private TextBox textBoxName;
        private TextBox textBoxReturnType;
    }
}
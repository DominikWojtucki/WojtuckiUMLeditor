namespace WojtuckiUMLeditor
{
    partial class EditClassNameForm
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
            textBoxClassName = new TextBox();
            labelClassName = new Label();
            buttonOK = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxClassName
            // 
            textBoxClassName.Location = new Point(44, 43);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Size = new Size(100, 23);
            textBoxClassName.TabIndex = 0;
            // 
            // labelClassName
            // 
            labelClassName.AutoSize = true;
            labelClassName.Location = new Point(34, 25);
            labelClassName.Name = "labelClassName";
            labelClassName.Size = new Size(120, 15);
            labelClassName.TabIndex = 1;
            labelClassName.Text = "Enter new class name";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(20, 82);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(101, 82);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // EditClassNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 125);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(labelClassName);
            Controls.Add(textBoxClassName);
            Name = "EditClassNameForm";
            Text = "EditClassNameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxClassName;
        private Label labelClassName;
        private Button buttonOK;
        private Button buttonCancel;
    }
}
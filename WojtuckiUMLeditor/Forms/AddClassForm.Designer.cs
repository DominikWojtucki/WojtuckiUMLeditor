namespace WojtuckiUMLeditor
{
    partial class AddClassForm
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
            labelClassName = new Label();
            textBoxClassName = new TextBox();
            buttonOkClassName = new Button();
            buttonCancelClassName = new Button();
            SuspendLayout();
            // 
            // labelClassName
            // 
            labelClassName.AutoSize = true;
            labelClassName.Location = new Point(65, 9);
            labelClassName.Name = "labelClassName";
            labelClassName.Size = new Size(95, 15);
            labelClassName.TabIndex = 0;
            labelClassName.Text = "Enter class name";
            // 
            // textBoxClassName
            // 
            textBoxClassName.Location = new Point(26, 40);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Size = new Size(173, 23);
            textBoxClassName.TabIndex = 1;
            // 
            // buttonOkClassName
            // 
            buttonOkClassName.Location = new Point(26, 80);
            buttonOkClassName.Name = "buttonOkClassName";
            buttonOkClassName.Size = new Size(90, 25);
            buttonOkClassName.TabIndex = 2;
            buttonOkClassName.Text = "OK";
            buttonOkClassName.UseVisualStyleBackColor = true;
            buttonOkClassName.Click += buttonOkClassName_Click;
            // 
            // buttonCancelClassName
            // 
            buttonCancelClassName.Location = new Point(121, 80);
            buttonCancelClassName.Name = "buttonCancelClassName";
            buttonCancelClassName.Size = new Size(90, 25);
            buttonCancelClassName.TabIndex = 3;
            buttonCancelClassName.Text = "Cancel";
            buttonCancelClassName.UseVisualStyleBackColor = true;
            buttonCancelClassName.Click += buttonCancelClassName_Click;
            // 
            // AddClassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 135);
            Controls.Add(buttonCancelClassName);
            Controls.Add(buttonOkClassName);
            Controls.Add(textBoxClassName);
            Controls.Add(labelClassName);
            Name = "AddClassForm";
            Text = "AddClassForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClassName;
        private TextBox textBoxClassName;
        private Button buttonOkClassName;
        private Button buttonCancelClassName;
    }
}
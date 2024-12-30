namespace WojtuckiUMLeditor
{
    partial class ClassEditorForm
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
            buttonEditClassName = new Button();
            buttonClose = new Button();
            buttonEditAttribute = new Button();
            buttonEditMethod = new Button();
            SuspendLayout();
            // 
            // buttonEditClassName
            // 
            buttonEditClassName.Location = new Point(12, 28);
            buttonEditClassName.Name = "buttonEditClassName";
            buttonEditClassName.Size = new Size(150, 50);
            buttonEditClassName.TabIndex = 0;
            buttonEditClassName.Text = "Edit Class Name";
            buttonEditClassName.UseVisualStyleBackColor = true;
            buttonEditClassName.Click += buttonEditClassName_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 196);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(150, 50);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonEditAttribute
            // 
            buttonEditAttribute.Location = new Point(12, 84);
            buttonEditAttribute.Name = "buttonEditAttribute";
            buttonEditAttribute.Size = new Size(150, 50);
            buttonEditAttribute.TabIndex = 5;
            buttonEditAttribute.Text = "Edit Attribute";
            buttonEditAttribute.UseVisualStyleBackColor = true;
            buttonEditAttribute.Click += buttonEditAttribute_Click;
            // 
            // buttonEditMethod
            // 
            buttonEditMethod.Location = new Point(12, 140);
            buttonEditMethod.Name = "buttonEditMethod";
            buttonEditMethod.Size = new Size(150, 50);
            buttonEditMethod.TabIndex = 6;
            buttonEditMethod.Text = "Edit Method";
            buttonEditMethod.UseVisualStyleBackColor = true;
            // 
            // ClassEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(185, 301);
            Controls.Add(buttonEditMethod);
            Controls.Add(buttonEditAttribute);
            Controls.Add(buttonClose);
            Controls.Add(buttonEditClassName);
            Name = "ClassEditorForm";
            Text = "ClassEditorForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEditClassName;
        private Button buttonClose;
        private Button buttonEditAttribute;
        private Button buttonEditMethod;
    }
}
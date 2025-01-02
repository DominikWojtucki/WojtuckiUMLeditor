namespace WojtuckiUMLeditor.Forms
{
    partial class RelationForm
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
            comboBoxRelationType = new ComboBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            comboBoxMultiplicity = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxRelationType
            // 
            comboBoxRelationType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRelationType.FormattingEnabled = true;
            comboBoxRelationType.Location = new Point(47, 27);
            comboBoxRelationType.Name = "comboBoxRelationType";
            comboBoxRelationType.Size = new Size(121, 23);
            comboBoxRelationType.TabIndex = 2;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(25, 113);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(106, 113);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxMultiplicity
            // 
            comboBoxMultiplicity.FormattingEnabled = true;
            comboBoxMultiplicity.Location = new Point(47, 84);
            comboBoxMultiplicity.Name = "comboBoxMultiplicity";
            comboBoxMultiplicity.Size = new Size(121, 23);
            comboBoxMultiplicity.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 6;
            label1.Text = "Select relation type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 66);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 7;
            label2.Text = "Select multiplicity";
            // 
            // RelationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 176);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMultiplicity);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(comboBoxRelationType);
            Name = "RelationForm";
            Text = "RelationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxRelationType;
        private Button buttonOK;
        private Button buttonCancel;
        private ComboBox comboBoxMultiplicity;
        private Label label1;
        private Label label2;
    }
}
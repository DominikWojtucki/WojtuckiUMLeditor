namespace WojtuckiUMLeditor
{
    partial class Form1
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
            pictureBoxCanvas = new PictureBox();
            buttonAddClass = new Button();
            buttonEditClass = new Button();
            buttonDeleteClass = new Button();
            buttonExit = new Button();
            buttonAddAttribute = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            pictureBoxCanvas.Dock = DockStyle.Fill;
            pictureBoxCanvas.Location = new Point(0, 0);
            pictureBoxCanvas.Name = "pictureBoxCanvas";
            pictureBoxCanvas.Size = new Size(800, 450);
            pictureBoxCanvas.TabIndex = 0;
            pictureBoxCanvas.TabStop = false;
            pictureBoxCanvas.Paint += pictureBoxCanvas_Paint;
            pictureBoxCanvas.MouseDown += pictureBoxCanvas_MouseDown;
            pictureBoxCanvas.MouseMove += pictureBoxCanvas_MouseMove;
            // 
            // buttonAddClass
            // 
            buttonAddClass.Location = new Point(649, 12);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(150, 50);
            buttonAddClass.TabIndex = 1;
            buttonAddClass.Text = "ADD CLASS";
            buttonAddClass.UseVisualStyleBackColor = true;
            buttonAddClass.Click += buttonAddClass_Click;
            // 
            // buttonEditClass
            // 
            buttonEditClass.Location = new Point(650, 124);
            buttonEditClass.Name = "buttonEditClass";
            buttonEditClass.Size = new Size(150, 50);
            buttonEditClass.TabIndex = 2;
            buttonEditClass.Text = "EDIT CLASS";
            buttonEditClass.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteClass
            // 
            buttonDeleteClass.Location = new Point(650, 180);
            buttonDeleteClass.Name = "buttonDeleteClass";
            buttonDeleteClass.Size = new Size(150, 50);
            buttonDeleteClass.TabIndex = 3;
            buttonDeleteClass.Text = "DELETE CLASS";
            buttonDeleteClass.UseVisualStyleBackColor = true;
            buttonDeleteClass.Click += buttonDeleteClass_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(650, 236);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(150, 50);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonAddAttribute
            // 
            buttonAddAttribute.Location = new Point(649, 68);
            buttonAddAttribute.Name = "buttonAddAttribute";
            buttonAddAttribute.Size = new Size(150, 50);
            buttonAddAttribute.TabIndex = 5;
            buttonAddAttribute.Text = "ADD ATTRIBUTE";
            buttonAddAttribute.UseVisualStyleBackColor = true;
            buttonAddAttribute.Click += buttonAddAttribute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddAttribute);
            Controls.Add(buttonExit);
            Controls.Add(buttonDeleteClass);
            Controls.Add(buttonEditClass);
            Controls.Add(buttonAddClass);
            Controls.Add(pictureBoxCanvas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxCanvas;
        private Button buttonAddClass;
        private Button buttonEditClass;
        private Button buttonDeleteClass;
        private Button buttonExit;
        private Button buttonAddAttribute;
    }
}

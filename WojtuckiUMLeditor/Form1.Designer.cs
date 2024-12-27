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
            pictureBoxCanvas.MouseClick += pictureBoxCanvas_MouseClick;
            pictureBoxCanvas.MouseDown += pictureBoxCanvas_MouseDown;
            pictureBoxCanvas.MouseMove += pictureBoxCanvas_MouseMove;
            pictureBoxCanvas.MouseUp += pictureBoxCanvas_MouseUp;
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
            buttonEditClass.Location = new Point(650, 68);
            buttonEditClass.Name = "buttonEditClass";
            buttonEditClass.Size = new Size(150, 50);
            buttonEditClass.TabIndex = 2;
            buttonEditClass.Text = "EDIT CLASS";
            buttonEditClass.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteClass
            // 
            buttonDeleteClass.Location = new Point(650, 124);
            buttonDeleteClass.Name = "buttonDeleteClass";
            buttonDeleteClass.Size = new Size(150, 50);
            buttonDeleteClass.TabIndex = 3;
            buttonDeleteClass.Text = "DELETE CLASS";
            buttonDeleteClass.UseVisualStyleBackColor = true;
            buttonDeleteClass.Click += buttonDeleteClass_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}

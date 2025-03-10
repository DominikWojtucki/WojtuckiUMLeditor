﻿namespace WojtuckiUMLeditor
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
            buttonAddMethod = new Button();
            buttonExportToPNG = new Button();
            buttonCreateRelation = new Button();
            buttonLoadDiagram = new Button();
            buttonSaveDiagram = new Button();
            buttonGenerateCode = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            pictureBoxCanvas.Dock = DockStyle.Fill;
            pictureBoxCanvas.Location = new Point(0, 0);
            pictureBoxCanvas.Name = "pictureBoxCanvas";
            pictureBoxCanvas.Size = new Size(800, 614);
            pictureBoxCanvas.TabIndex = 0;
            pictureBoxCanvas.TabStop = false;
            pictureBoxCanvas.Paint += pictureBoxCanvas_Paint;
            pictureBoxCanvas.MouseDown += pictureBoxCanvas_MouseDown;
            pictureBoxCanvas.MouseMove += pictureBoxCanvas_MouseMove;
            pictureBoxCanvas.MouseUp += pictureBoxCanvas_MouseUp;
            // 
            // buttonAddClass
            // 
            buttonAddClass.Location = new Point(649, 7);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(150, 50);
            buttonAddClass.TabIndex = 1;
            buttonAddClass.Text = "ADD CLASS";
            buttonAddClass.UseVisualStyleBackColor = true;
            buttonAddClass.Click += buttonAddClass_Click;
            // 
            // buttonEditClass
            // 
            buttonEditClass.Location = new Point(649, 175);
            buttonEditClass.Name = "buttonEditClass";
            buttonEditClass.Size = new Size(150, 50);
            buttonEditClass.TabIndex = 2;
            buttonEditClass.Text = "EDIT CLASS";
            buttonEditClass.UseVisualStyleBackColor = true;
            buttonEditClass.Click += buttonEditClass_Click;
            // 
            // buttonDeleteClass
            // 
            buttonDeleteClass.Location = new Point(650, 231);
            buttonDeleteClass.Name = "buttonDeleteClass";
            buttonDeleteClass.Size = new Size(150, 50);
            buttonDeleteClass.TabIndex = 3;
            buttonDeleteClass.Text = "DELETE CLASS";
            buttonDeleteClass.UseVisualStyleBackColor = true;
            buttonDeleteClass.Click += buttonDeleteClass_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(649, 564);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(150, 50);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonAddAttribute
            // 
            buttonAddAttribute.Location = new Point(650, 63);
            buttonAddAttribute.Name = "buttonAddAttribute";
            buttonAddAttribute.Size = new Size(150, 50);
            buttonAddAttribute.TabIndex = 5;
            buttonAddAttribute.Text = "ADD ATTRIBUTE";
            buttonAddAttribute.UseVisualStyleBackColor = true;
            buttonAddAttribute.Click += buttonAddAttribute_Click;
            // 
            // buttonAddMethod
            // 
            buttonAddMethod.Location = new Point(649, 119);
            buttonAddMethod.Name = "buttonAddMethod";
            buttonAddMethod.Size = new Size(150, 50);
            buttonAddMethod.TabIndex = 6;
            buttonAddMethod.Text = "ADD METHOD";
            buttonAddMethod.UseVisualStyleBackColor = true;
            buttonAddMethod.Click += buttonAddMethod_Click;
            // 
            // buttonExportToPNG
            // 
            buttonExportToPNG.Location = new Point(650, 287);
            buttonExportToPNG.Name = "buttonExportToPNG";
            buttonExportToPNG.Size = new Size(150, 50);
            buttonExportToPNG.TabIndex = 7;
            buttonExportToPNG.Text = "EXPORT TO PNG";
            buttonExportToPNG.UseVisualStyleBackColor = true;
            buttonExportToPNG.Click += buttonExportToPNG_Click;
            // 
            // buttonCreateRelation
            // 
            buttonCreateRelation.Location = new Point(650, 343);
            buttonCreateRelation.Name = "buttonCreateRelation";
            buttonCreateRelation.Size = new Size(150, 50);
            buttonCreateRelation.TabIndex = 8;
            buttonCreateRelation.Text = "CREATE RELATION";
            buttonCreateRelation.UseVisualStyleBackColor = true;
            buttonCreateRelation.Click += buttonCreateRelation_Click;
            // 
            // buttonLoadDiagram
            // 
            buttonLoadDiagram.Location = new Point(650, 453);
            buttonLoadDiagram.Name = "buttonLoadDiagram";
            buttonLoadDiagram.Size = new Size(150, 50);
            buttonLoadDiagram.TabIndex = 9;
            buttonLoadDiagram.Text = "LOAD DIAGRAM";
            buttonLoadDiagram.UseVisualStyleBackColor = true;
            buttonLoadDiagram.Click += buttonLoadDiagram_Click;
            // 
            // buttonSaveDiagram
            // 
            buttonSaveDiagram.Location = new Point(650, 399);
            buttonSaveDiagram.Name = "buttonSaveDiagram";
            buttonSaveDiagram.Size = new Size(150, 50);
            buttonSaveDiagram.TabIndex = 10;
            buttonSaveDiagram.Text = "SAVE DIAGRAM";
            buttonSaveDiagram.UseVisualStyleBackColor = true;
            buttonSaveDiagram.Click += buttonSaveDiagram_Click;
            // 
            // buttonGenerateCode
            // 
            buttonGenerateCode.Location = new Point(649, 508);
            buttonGenerateCode.Name = "buttonGenerateCode";
            buttonGenerateCode.Size = new Size(150, 50);
            buttonGenerateCode.TabIndex = 11;
            buttonGenerateCode.Text = "GENERATE CODE";
            buttonGenerateCode.UseVisualStyleBackColor = true;
            buttonGenerateCode.Click += buttonGenerateCode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(buttonGenerateCode);
            Controls.Add(buttonSaveDiagram);
            Controls.Add(buttonLoadDiagram);
            Controls.Add(buttonCreateRelation);
            Controls.Add(buttonExportToPNG);
            Controls.Add(buttonAddMethod);
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
        private Button buttonAddMethod;
        private Button buttonExportToPNG;
        private Button buttonCreateRelation;
        private Button buttonLoadDiagram;
        private Button buttonSaveDiagram;
        private Button buttonGenerateCode;
    }
}

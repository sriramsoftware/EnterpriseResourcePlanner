﻿namespace StudentModuleUI.AddStudent
{
    partial class AddStudentForm
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
            this.listBoxSystemSubjects = new System.Windows.Forms.ListBox();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelSubjectsToBeAdded = new System.Windows.Forms.Label();
            this.labelSystemSubjects = new System.Windows.Forms.Label();
            this.buttonRemoveSubjectFromStudent = new System.Windows.Forms.Button();
            this.buttonAddSubjectToStudent = new System.Windows.Forms.Button();
            this.listBoxStudentSubjects = new System.Windows.Forms.ListBox();
            this.labelAddStudentTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDocument = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxDocument = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelStudentNumber = new System.Windows.Forms.Label();
            this.textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.radioButtonYesPickUp = new System.Windows.Forms.RadioButton();
            this.radioButtonNoPickUp = new System.Windows.Forms.RadioButton();
            this.labelPickupService = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxLatitud = new System.Windows.Forms.TextBox();
            this.textBoxLongitud = new System.Windows.Forms.TextBox();
            this.labelLatitud = new System.Windows.Forms.Label();
            this.labelLongitud = new System.Windows.Forms.Label();
            this.groupBoxPickUpServiceRadioButtons = new System.Windows.Forms.GroupBox();
            this.labelFeeAmount = new System.Windows.Forms.Label();
            this.numericUpDownFeeAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBoxPickUpServiceRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSystemSubjects
            // 
            this.listBoxSystemSubjects.FormattingEnabled = true;
            this.listBoxSystemSubjects.ItemHeight = 31;
            this.listBoxSystemSubjects.Location = new System.Drawing.Point(163, 681);
            this.listBoxSystemSubjects.Name = "listBoxSystemSubjects";
            this.listBoxSystemSubjects.Size = new System.Drawing.Size(694, 252);
            this.listBoxSystemSubjects.TabIndex = 52;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSuccess.Location = new System.Drawing.Point(156, 1041);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(0, 39);
            this.labelSuccess.TabIndex = 51;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(160, 1069);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 39);
            this.labelError.TabIndex = 50;
            // 
            // labelSubjectsToBeAdded
            // 
            this.labelSubjectsToBeAdded.AutoSize = true;
            this.labelSubjectsToBeAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjectsToBeAdded.Location = new System.Drawing.Point(1070, 635);
            this.labelSubjectsToBeAdded.Name = "labelSubjectsToBeAdded";
            this.labelSubjectsToBeAdded.Size = new System.Drawing.Size(259, 36);
            this.labelSubjectsToBeAdded.TabIndex = 49;
            this.labelSubjectsToBeAdded.Text = "Subjects to study: ";
            // 
            // labelSystemSubjects
            // 
            this.labelSystemSubjects.AutoSize = true;
            this.labelSystemSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemSubjects.Location = new System.Drawing.Point(160, 635);
            this.labelSystemSubjects.Name = "labelSystemSubjects";
            this.labelSystemSubjects.Size = new System.Drawing.Size(271, 36);
            this.labelSystemSubjects.TabIndex = 48;
            this.labelSystemSubjects.Text = "Available subjects: ";
            // 
            // buttonRemoveSubjectFromStudent
            // 
            this.buttonRemoveSubjectFromStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSubjectFromStudent.Location = new System.Drawing.Point(917, 826);
            this.buttonRemoveSubjectFromStudent.Name = "buttonRemoveSubjectFromStudent";
            this.buttonRemoveSubjectFromStudent.Size = new System.Drawing.Size(100, 50);
            this.buttonRemoveSubjectFromStudent.TabIndex = 47;
            this.buttonRemoveSubjectFromStudent.Text = "<<";
            this.buttonRemoveSubjectFromStudent.UseVisualStyleBackColor = true;
            this.buttonRemoveSubjectFromStudent.Click += new System.EventHandler(this.buttonRemoveSubjectFromStudent_Click);
            // 
            // buttonAddSubjectToStudent
            // 
            this.buttonAddSubjectToStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubjectToStudent.Location = new System.Drawing.Point(917, 738);
            this.buttonAddSubjectToStudent.Name = "buttonAddSubjectToStudent";
            this.buttonAddSubjectToStudent.Size = new System.Drawing.Size(100, 50);
            this.buttonAddSubjectToStudent.TabIndex = 46;
            this.buttonAddSubjectToStudent.Text = ">>";
            this.buttonAddSubjectToStudent.UseVisualStyleBackColor = true;
            this.buttonAddSubjectToStudent.Click += new System.EventHandler(this.buttonAddSubjectToStudent_Click);
            // 
            // listBoxStudentSubjects
            // 
            this.listBoxStudentSubjects.FormattingEnabled = true;
            this.listBoxStudentSubjects.ItemHeight = 31;
            this.listBoxStudentSubjects.Location = new System.Drawing.Point(1067, 681);
            this.listBoxStudentSubjects.Name = "listBoxStudentSubjects";
            this.listBoxStudentSubjects.Size = new System.Drawing.Size(694, 252);
            this.listBoxStudentSubjects.TabIndex = 45;
            // 
            // labelAddStudentTitle
            // 
            this.labelAddStudentTitle.AutoSize = true;
            this.labelAddStudentTitle.Font = new System.Drawing.Font("Verdana", 14.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddStudentTitle.Location = new System.Drawing.Point(107, 84);
            this.labelAddStudentTitle.Name = "labelAddStudentTitle";
            this.labelAddStudentTitle.Size = new System.Drawing.Size(325, 59);
            this.labelAddStudentTitle.TabIndex = 36;
            this.labelAddStudentTitle.Text = "Add Student";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(324, 370);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 32);
            this.labelName.TabIndex = 37;
            this.labelName.Text = "Name: ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(263, 439);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(166, 32);
            this.labelLastName.TabIndex = 38;
            this.labelLastName.Text = "Last Name: ";
            // 
            // labelDocument
            // 
            this.labelDocument.AutoSize = true;
            this.labelDocument.Location = new System.Drawing.Point(270, 298);
            this.labelDocument.Name = "labelDocument";
            this.labelDocument.Size = new System.Drawing.Size(159, 32);
            this.labelDocument.TabIndex = 39;
            this.labelDocument.Text = "Document: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(477, 367);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(380, 38);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(477, 436);
            this.textBoxLastName.MaxLength = 50;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(380, 38);
            this.textBoxLastName.TabIndex = 4;
            this.textBoxLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            // 
            // textBoxDocument
            // 
            this.textBoxDocument.Location = new System.Drawing.Point(477, 295);
            this.textBoxDocument.MaxLength = 9;
            this.textBoxDocument.Name = "textBoxDocument";
            this.textBoxDocument.Size = new System.Drawing.Size(380, 38);
            this.textBoxDocument.TabIndex = 2;
            this.textBoxDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(1496, 1041);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(265, 60);
            this.buttonAddStudent.TabIndex = 9;
            this.buttonAddStudent.Text = "Add";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1146, 1041);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(265, 60);
            this.buttonCancel.TabIndex = 44;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelStudentNumber
            // 
            this.labelStudentNumber.AutoSize = true;
            this.labelStudentNumber.Location = new System.Drawing.Point(197, 224);
            this.labelStudentNumber.Name = "labelStudentNumber";
            this.labelStudentNumber.Size = new System.Drawing.Size(232, 32);
            this.labelStudentNumber.TabIndex = 53;
            this.labelStudentNumber.Text = "Student number: ";
            // 
            // textBoxStudentNumber
            // 
            this.textBoxStudentNumber.Enabled = false;
            this.textBoxStudentNumber.Location = new System.Drawing.Point(477, 224);
            this.textBoxStudentNumber.MaxLength = 50;
            this.textBoxStudentNumber.Name = "textBoxStudentNumber";
            this.textBoxStudentNumber.Size = new System.Drawing.Size(380, 38);
            this.textBoxStudentNumber.TabIndex = 1;
            // 
            // radioButtonYesPickUp
            // 
            this.radioButtonYesPickUp.AutoSize = true;
            this.radioButtonYesPickUp.Location = new System.Drawing.Point(45, 26);
            this.radioButtonYesPickUp.Name = "radioButtonYesPickUp";
            this.radioButtonYesPickUp.Size = new System.Drawing.Size(101, 36);
            this.radioButtonYesPickUp.TabIndex = 6;
            this.radioButtonYesPickUp.Text = "Yes";
            this.radioButtonYesPickUp.UseVisualStyleBackColor = true;
            this.radioButtonYesPickUp.CheckedChanged += new System.EventHandler(this.radioButtonPickUp_CheckedChanged);
            // 
            // radioButtonNoPickUp
            // 
            this.radioButtonNoPickUp.AutoSize = true;
            this.radioButtonNoPickUp.Checked = true;
            this.radioButtonNoPickUp.Location = new System.Drawing.Point(162, 27);
            this.radioButtonNoPickUp.Name = "radioButtonNoPickUp";
            this.radioButtonNoPickUp.Size = new System.Drawing.Size(88, 36);
            this.radioButtonNoPickUp.TabIndex = 56;
            this.radioButtonNoPickUp.TabStop = true;
            this.radioButtonNoPickUp.Text = "No";
            this.radioButtonNoPickUp.UseVisualStyleBackColor = true;
            this.radioButtonNoPickUp.CheckedChanged += new System.EventHandler(this.radioButtonPickUp_CheckedChanged);
            // 
            // labelPickupService
            // 
            this.labelPickupService.AutoSize = true;
            this.labelPickupService.Location = new System.Drawing.Point(1076, 223);
            this.labelPickupService.Name = "labelPickupService";
            this.labelPickupService.Size = new System.Drawing.Size(284, 32);
            this.labelPickupService.TabIndex = 57;
            this.labelPickupService.Text = "Have pickup service?";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(1076, 367);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(264, 32);
            this.labelLocation.TabIndex = 58;
            this.labelLocation.Text = "Pickup coordinates:";
            // 
            // textBoxLatitud
            // 
            this.textBoxLatitud.Enabled = false;
            this.textBoxLatitud.Location = new System.Drawing.Point(1276, 430);
            this.textBoxLatitud.MaxLength = 10;
            this.textBoxLatitud.Name = "textBoxLatitud";
            this.textBoxLatitud.Size = new System.Drawing.Size(253, 38);
            this.textBoxLatitud.TabIndex = 7;
            this.textBoxLatitud.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            // 
            // textBoxLongitud
            // 
            this.textBoxLongitud.Enabled = false;
            this.textBoxLongitud.Location = new System.Drawing.Point(1276, 494);
            this.textBoxLongitud.MaxLength = 11;
            this.textBoxLongitud.Name = "textBoxLongitud";
            this.textBoxLongitud.Size = new System.Drawing.Size(253, 38);
            this.textBoxLongitud.TabIndex = 8;
            this.textBoxLongitud.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            // 
            // labelLatitud
            // 
            this.labelLatitud.AutoSize = true;
            this.labelLatitud.Location = new System.Drawing.Point(1153, 436);
            this.labelLatitud.Name = "labelLatitud";
            this.labelLatitud.Size = new System.Drawing.Size(110, 32);
            this.labelLatitud.TabIndex = 61;
            this.labelLatitud.Text = "Latitud:";
            // 
            // labelLongitud
            // 
            this.labelLongitud.AutoSize = true;
            this.labelLongitud.Location = new System.Drawing.Point(1129, 500);
            this.labelLongitud.Name = "labelLongitud";
            this.labelLongitud.Size = new System.Drawing.Size(134, 32);
            this.labelLongitud.TabIndex = 62;
            this.labelLongitud.Text = "Longitud:";
            // 
            // groupBoxPickUpServiceRadioButtons
            // 
            this.groupBoxPickUpServiceRadioButtons.Controls.Add(this.radioButtonYesPickUp);
            this.groupBoxPickUpServiceRadioButtons.Controls.Add(this.radioButtonNoPickUp);
            this.groupBoxPickUpServiceRadioButtons.Location = new System.Drawing.Point(1135, 268);
            this.groupBoxPickUpServiceRadioButtons.Name = "groupBoxPickUpServiceRadioButtons";
            this.groupBoxPickUpServiceRadioButtons.Size = new System.Drawing.Size(325, 75);
            this.groupBoxPickUpServiceRadioButtons.TabIndex = 63;
            this.groupBoxPickUpServiceRadioButtons.TabStop = false;
            // 
            // labelFeeAmount
            // 
            this.labelFeeAmount.AutoSize = true;
            this.labelFeeAmount.Location = new System.Drawing.Point(245, 527);
            this.labelFeeAmount.Name = "labelFeeAmount";
            this.labelFeeAmount.Size = new System.Drawing.Size(184, 32);
            this.labelFeeAmount.TabIndex = 64;
            this.labelFeeAmount.Text = "Fee Amount: ";
            // 
            // numericUpDownFeeAmount
            // 
            this.numericUpDownFeeAmount.DecimalPlaces = 2;
            this.numericUpDownFeeAmount.Location = new System.Drawing.Point(477, 527);
            this.numericUpDownFeeAmount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownFeeAmount.Name = "numericUpDownFeeAmount";
            this.numericUpDownFeeAmount.Size = new System.Drawing.Size(380, 38);
            this.numericUpDownFeeAmount.TabIndex = 5;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 1192);
            this.Controls.Add(this.numericUpDownFeeAmount);
            this.Controls.Add(this.labelFeeAmount);
            this.Controls.Add(this.groupBoxPickUpServiceRadioButtons);
            this.Controls.Add(this.labelLongitud);
            this.Controls.Add(this.labelLatitud);
            this.Controls.Add(this.textBoxLongitud);
            this.Controls.Add(this.textBoxLatitud);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelPickupService);
            this.Controls.Add(this.textBoxStudentNumber);
            this.Controls.Add(this.labelStudentNumber);
            this.Controls.Add(this.listBoxSystemSubjects);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelSubjectsToBeAdded);
            this.Controls.Add(this.labelSystemSubjects);
            this.Controls.Add(this.buttonRemoveSubjectFromStudent);
            this.Controls.Add(this.buttonAddSubjectToStudent);
            this.Controls.Add(this.listBoxStudentSubjects);
            this.Controls.Add(this.labelAddStudentTitle);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelDocument);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxDocument);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.buttonCancel);
            this.Name = "AddStudentForm";
            this.Text = "Add Student";
            this.groupBoxPickUpServiceRadioButtons.ResumeLayout(false);
            this.groupBoxPickUpServiceRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeeAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSystemSubjects;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelSubjectsToBeAdded;
        private System.Windows.Forms.Label labelSystemSubjects;
        private System.Windows.Forms.Button buttonRemoveSubjectFromStudent;
        private System.Windows.Forms.Button buttonAddSubjectToStudent;
        private System.Windows.Forms.ListBox listBoxStudentSubjects;
        private System.Windows.Forms.Label labelAddStudentTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDocument;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxDocument;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelStudentNumber;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
        private System.Windows.Forms.RadioButton radioButtonYesPickUp;
        private System.Windows.Forms.RadioButton radioButtonNoPickUp;
        private System.Windows.Forms.Label labelPickupService;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxLatitud;
        private System.Windows.Forms.TextBox textBoxLongitud;
        private System.Windows.Forms.Label labelLatitud;
        private System.Windows.Forms.Label labelLongitud;
        private System.Windows.Forms.GroupBox groupBoxPickUpServiceRadioButtons;
        private System.Windows.Forms.Label labelFeeAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownFeeAmount;
    }
}
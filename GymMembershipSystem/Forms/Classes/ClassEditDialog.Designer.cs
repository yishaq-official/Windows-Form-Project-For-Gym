namespace GymMembershipSystem.Forms.Classes
{
    partial class ClassEditDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new System.Windows.Forms.Panel();
            lblDialogTitle = new System.Windows.Forms.Label();
            lblClassName = new System.Windows.Forms.Label();
            txtClassName = new System.Windows.Forms.TextBox();
            lblTrainer = new System.Windows.Forms.Label();
            cboTrainer = new System.Windows.Forms.ComboBox();
            lblDayOfWeek = new System.Windows.Forms.Label();
            cboDayOfWeek = new System.Windows.Forms.ComboBox();
            lblStartTime = new System.Windows.Forms.Label();
            dtpStartTime = new System.Windows.Forms.DateTimePicker();
            lblDuration = new System.Windows.Forms.Label();
            numDuration = new System.Windows.Forms.NumericUpDown();
            lblCapacity = new System.Windows.Forms.Label();
            numCapacity = new System.Windows.Forms.NumericUpDown();
            lblCapacityNotice = new System.Windows.Forms.Label();
            chkIsActive = new System.Windows.Forms.CheckBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblErrorMessage = new System.Windows.Forms.Label();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(lblDialogTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(460, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblDialogTitle
            // 
            lblDialogTitle.AutoSize = true;
            lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDialogTitle.ForeColor = System.Drawing.Color.White;
            lblDialogTitle.Location = new System.Drawing.Point(24, 18);
            lblDialogTitle.Name = "lblDialogTitle";
            lblDialogTitle.Size = new System.Drawing.Size(183, 25);
            lblDialogTitle.TabIndex = 0;
            lblDialogTitle.Text = "Group Fitness Class";
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblClassName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblClassName.Location = new System.Drawing.Point(28, 76);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new System.Drawing.Size(73, 15);
            lblClassName.TabIndex = 1;
            lblClassName.Text = "Class Name:";
            // 
            // txtClassName
            // 
            txtClassName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtClassName.Location = new System.Drawing.Point(31, 96);
            txtClassName.MaxLength = 100;
            txtClassName.Name = "txtClassName";
            txtClassName.PlaceholderText = "e.g., Sunrise Power Yoga";
            txtClassName.Size = new System.Drawing.Size(395, 24);
            txtClassName.TabIndex = 2;
            txtClassName.Validating += txtClassName_Validating;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTrainer.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblTrainer.Location = new System.Drawing.Point(28, 134);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new System.Drawing.Size(99, 15);
            lblTrainer.TabIndex = 3;
            lblTrainer.Text = "Assigned Trainer:";
            // 
            // cboTrainer
            // 
            cboTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTrainer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboTrainer.FormattingEnabled = true;
            cboTrainer.Location = new System.Drawing.Point(31, 154);
            cboTrainer.Name = "cboTrainer";
            cboTrainer.Size = new System.Drawing.Size(395, 24);
            cboTrainer.TabIndex = 4;
            cboTrainer.Validating += cboTrainer_Validating;
            // 
            // lblDayOfWeek
            // 
            lblDayOfWeek.AutoSize = true;
            lblDayOfWeek.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDayOfWeek.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblDayOfWeek.Location = new System.Drawing.Point(28, 192);
            lblDayOfWeek.Name = "lblDayOfWeek";
            lblDayOfWeek.Size = new System.Drawing.Size(78, 15);
            lblDayOfWeek.TabIndex = 5;
            lblDayOfWeek.Text = "Day of Week:";
            // 
            // cboDayOfWeek
            // 
            cboDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboDayOfWeek.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboDayOfWeek.FormattingEnabled = true;
            cboDayOfWeek.Location = new System.Drawing.Point(31, 212);
            cboDayOfWeek.Name = "cboDayOfWeek";
            cboDayOfWeek.Size = new System.Drawing.Size(185, 24);
            cboDayOfWeek.TabIndex = 6;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStartTime.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblStartTime.Location = new System.Drawing.Point(238, 192);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new System.Drawing.Size(64, 15);
            lblStartTime.TabIndex = 7;
            lblStartTime.Text = "Start Time:";
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpStartTime.Location = new System.Drawing.Point(241, 212);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new System.Drawing.Size(185, 24);
            dtpStartTime.TabIndex = 8;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDuration.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblDuration.Location = new System.Drawing.Point(28, 252);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new System.Drawing.Size(95, 15);
            lblDuration.TabIndex = 9;
            lblDuration.Text = "Duration (Mins):";
            // 
            // numDuration
            // 
            numDuration.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numDuration.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numDuration.Location = new System.Drawing.Point(31, 272);
            numDuration.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new System.Drawing.Size(185, 24);
            numDuration.TabIndex = 10;
            numDuration.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCapacity.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblCapacity.Location = new System.Drawing.Point(238, 252);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new System.Drawing.Size(117, 15);
            lblCapacity.TabIndex = 11;
            lblCapacity.Text = "Maximum Capacity:";
            // 
            // numCapacity
            // 
            numCapacity.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numCapacity.Location = new System.Drawing.Point(241, 272);
            numCapacity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new System.Drawing.Size(185, 24);
            numCapacity.TabIndex = 12;
            numCapacity.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numCapacity.Validating += numCapacity_Validating;
            // 
            // lblCapacityNotice
            // 
            lblCapacityNotice.AutoSize = true;
            lblCapacityNotice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblCapacityNotice.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblCapacityNotice.Location = new System.Drawing.Point(238, 301);
            lblCapacityNotice.Name = "lblCapacityNotice";
            lblCapacityNotice.Size = new System.Drawing.Size(187, 13);
            lblCapacityNotice.TabIndex = 13;
            lblCapacityNotice.Text = "Rule 6: Capacity >= active bookings";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIsActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chkIsActive.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            chkIsActive.Location = new System.Drawing.Point(31, 318);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new System.Drawing.Size(200, 19);
            chkIsActive.TabIndex = 14;
            chkIsActive.Text = "Class is Active and Open to Book";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(306, 365);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(120, 36);
            btnSave.TabIndex = 15;
            btnSave.Text = "💾 Save Class";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnCancel.Location = new System.Drawing.Point(198, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 36);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            lblErrorMessage.Location = new System.Drawing.Point(31, 338);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            lblErrorMessage.Size = new System.Drawing.Size(395, 22);
            lblErrorMessage.TabIndex = 17;
            lblErrorMessage.Text = "Validation error message";
            lblErrorMessage.Visible = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // ClassEditDialog
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(460, 420);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(lblCapacityNotice);
            Controls.Add(numCapacity);
            Controls.Add(lblCapacity);
            Controls.Add(numDuration);
            Controls.Add(lblDuration);
            Controls.Add(dtpStartTime);
            Controls.Add(lblStartTime);
            Controls.Add(cboDayOfWeek);
            Controls.Add(lblDayOfWeek);
            Controls.Add(cboTrainer);
            Controls.Add(lblTrainer);
            Controls.Add(txtClassName);
            Controls.Add(lblClassName);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClassEditDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Gym Class Details";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDialogTitle;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.ComboBox cboTrainer;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.ComboBox cboDayOfWeek;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Label lblCapacityNotice;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

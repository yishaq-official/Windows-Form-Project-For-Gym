namespace GymMembershipSystem.Forms.Classes
{
    partial class BookClassDialog
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
            pnlHeader = new System.Windows.Forms.Panel();
            lblDialogTitle = new System.Windows.Forms.Label();
            pnlClassInfo = new System.Windows.Forms.Panel();
            lblSpotsRemaining = new System.Windows.Forms.Label();
            lblClassSchedule = new System.Windows.Forms.Label();
            lblClassName = new System.Windows.Forms.Label();
            lblClassBadge = new System.Windows.Forms.Label();
            lblSelectMember = new System.Windows.Forms.Label();
            cboMember = new System.Windows.Forms.ComboBox();
            pnlMemberPreview = new System.Windows.Forms.Panel();
            lblValidationNotice = new System.Windows.Forms.Label();
            lblMemberPlanExpiry = new System.Windows.Forms.Label();
            lblMemberStatusBadge = new System.Windows.Forms.Label();
            lblMemberPhone = new System.Windows.Forms.Label();
            lblMemberName = new System.Windows.Forms.Label();
            btnConfirmBook = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblErrorMessage = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            pnlClassInfo.SuspendLayout();
            pnlMemberPreview.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(lblDialogTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(480, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblDialogTitle
            // 
            lblDialogTitle.AutoSize = true;
            lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDialogTitle.ForeColor = System.Drawing.Color.White;
            lblDialogTitle.Location = new System.Drawing.Point(24, 18);
            lblDialogTitle.Name = "lblDialogTitle";
            lblDialogTitle.Size = new System.Drawing.Size(188, 25);
            lblDialogTitle.TabIndex = 0;
            lblDialogTitle.Text = "Book Class Attendee";
            // 
            // pnlClassInfo
            // 
            pnlClassInfo.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            pnlClassInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlClassInfo.Controls.Add(lblSpotsRemaining);
            pnlClassInfo.Controls.Add(lblClassSchedule);
            pnlClassInfo.Controls.Add(lblClassName);
            pnlClassInfo.Controls.Add(lblClassBadge);
            pnlClassInfo.Location = new System.Drawing.Point(24, 76);
            pnlClassInfo.Name = "pnlClassInfo";
            pnlClassInfo.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            pnlClassInfo.Size = new System.Drawing.Size(432, 90);
            pnlClassInfo.TabIndex = 1;
            // 
            // lblSpotsRemaining
            // 
            lblSpotsRemaining.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblSpotsRemaining.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSpotsRemaining.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            lblSpotsRemaining.Location = new System.Drawing.Point(248, 12);
            lblSpotsRemaining.Name = "lblSpotsRemaining";
            lblSpotsRemaining.Size = new System.Drawing.Size(166, 23);
            lblSpotsRemaining.TabIndex = 3;
            lblSpotsRemaining.Text = "3 spots left";
            lblSpotsRemaining.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblClassSchedule
            // 
            lblClassSchedule.AutoSize = true;
            lblClassSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblClassSchedule.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblClassSchedule.Location = new System.Drawing.Point(14, 60);
            lblClassSchedule.Name = "lblClassSchedule";
            lblClassSchedule.Size = new System.Drawing.Size(217, 15);
            lblClassSchedule.TabIndex = 2;
            lblClassSchedule.Text = "Monday at 07:00 AM • Trainer: Sarah Lee";
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblClassName.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblClassName.Location = new System.Drawing.Point(14, 34);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new System.Drawing.Size(147, 20);
            lblClassName.TabIndex = 1;
            lblClassName.Text = "Sunrise Power Yoga";
            // 
            // lblClassBadge
            // 
            lblClassBadge.AutoSize = true;
            lblClassBadge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblClassBadge.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblClassBadge.Location = new System.Drawing.Point(14, 14);
            lblClassBadge.Name = "lblClassBadge";
            lblClassBadge.Size = new System.Drawing.Size(95, 13);
            lblClassBadge.TabIndex = 0;
            lblClassBadge.Text = "TARGET CLASS";
            // 
            // lblSelectMember
            // 
            lblSelectMember.AutoSize = true;
            lblSelectMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSelectMember.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblSelectMember.Location = new System.Drawing.Point(24, 182);
            lblSelectMember.Name = "lblSelectMember";
            lblSelectMember.Size = new System.Drawing.Size(102, 17);
            lblSelectMember.TabIndex = 2;
            lblSelectMember.Text = "Select Member:";
            // 
            // cboMember
            // 
            cboMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cboMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cboMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboMember.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboMember.FormattingEnabled = true;
            cboMember.Location = new System.Drawing.Point(24, 204);
            cboMember.Name = "cboMember";
            cboMember.Size = new System.Drawing.Size(432, 24);
            cboMember.TabIndex = 3;
            cboMember.SelectedIndexChanged += cboMember_SelectedIndexChanged;
            // 
            // pnlMemberPreview
            // 
            pnlMemberPreview.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlMemberPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMemberPreview.Controls.Add(lblValidationNotice);
            pnlMemberPreview.Controls.Add(lblMemberPlanExpiry);
            pnlMemberPreview.Controls.Add(lblMemberStatusBadge);
            pnlMemberPreview.Controls.Add(lblMemberPhone);
            pnlMemberPreview.Controls.Add(lblMemberName);
            pnlMemberPreview.Location = new System.Drawing.Point(24, 242);
            pnlMemberPreview.Name = "pnlMemberPreview";
            pnlMemberPreview.Padding = new System.Windows.Forms.Padding(14);
            pnlMemberPreview.Size = new System.Drawing.Size(432, 110);
            pnlMemberPreview.TabIndex = 4;
            // 
            // lblValidationNotice
            // 
            lblValidationNotice.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblValidationNotice.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            lblValidationNotice.Location = new System.Drawing.Point(14, 76);
            lblValidationNotice.Name = "lblValidationNotice";
            lblValidationNotice.Size = new System.Drawing.Size(400, 22);
            lblValidationNotice.TabIndex = 4;
            lblValidationNotice.Text = "✅ Ready to book";
            // 
            // lblMemberPlanExpiry
            // 
            lblMemberPlanExpiry.AutoSize = true;
            lblMemberPlanExpiry.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMemberPlanExpiry.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            lblMemberPlanExpiry.Location = new System.Drawing.Point(14, 54);
            lblMemberPlanExpiry.Name = "lblMemberPlanExpiry";
            lblMemberPlanExpiry.Size = new System.Drawing.Size(206, 15);
            lblMemberPlanExpiry.TabIndex = 3;
            lblMemberPlanExpiry.Text = "Plan: Premium Yearly • Expires: Dec 31";
            // 
            // lblMemberStatusBadge
            // 
            lblMemberStatusBadge.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblMemberStatusBadge.BackColor = System.Drawing.Color.FromArgb(209, 250, 229);
            lblMemberStatusBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMemberStatusBadge.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            lblMemberStatusBadge.Location = new System.Drawing.Point(336, 14);
            lblMemberStatusBadge.Name = "lblMemberStatusBadge";
            lblMemberStatusBadge.Size = new System.Drawing.Size(80, 22);
            lblMemberStatusBadge.TabIndex = 2;
            lblMemberStatusBadge.Text = "ACTIVE";
            lblMemberStatusBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberPhone
            // 
            lblMemberPhone.AutoSize = true;
            lblMemberPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMemberPhone.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblMemberPhone.Location = new System.Drawing.Point(14, 34);
            lblMemberPhone.Name = "lblMemberPhone";
            lblMemberPhone.Size = new System.Drawing.Size(121, 15);
            lblMemberPhone.TabIndex = 1;
            lblMemberPhone.Text = "Phone: (555) 019-2834";
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMemberName.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblMemberName.Location = new System.Drawing.Point(14, 12);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new System.Drawing.Size(107, 19);
            lblMemberName.TabIndex = 0;
            lblMemberName.Text = "Alexander Wright";
            // 
            // btnConfirmBook
            // 
            btnConfirmBook.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnConfirmBook.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConfirmBook.FlatAppearance.BorderSize = 0;
            btnConfirmBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirmBook.ForeColor = System.Drawing.Color.White;
            btnConfirmBook.Location = new System.Drawing.Point(312, 404);
            btnConfirmBook.Name = "btnConfirmBook";
            btnConfirmBook.Size = new System.Drawing.Size(144, 36);
            btnConfirmBook.TabIndex = 5;
            btnConfirmBook.Text = "🎟️ Confirm Booking";
            btnConfirmBook.UseVisualStyleBackColor = false;
            btnConfirmBook.Click += btnConfirmBook_Click;
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
            btnCancel.Location = new System.Drawing.Point(204, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 36);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            lblErrorMessage.Location = new System.Drawing.Point(24, 362);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            lblErrorMessage.Size = new System.Drawing.Size(432, 32);
            lblErrorMessage.TabIndex = 7;
            lblErrorMessage.Text = "Validation error message";
            lblErrorMessage.Visible = false;
            // 
            // BookClassDialog
            // 
            AcceptButton = btnConfirmBook;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(480, 456);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmBook);
            Controls.Add(pnlMemberPreview);
            Controls.Add(cboMember);
            Controls.Add(lblSelectMember);
            Controls.Add(pnlClassInfo);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookClassDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Book Class Attendee";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlClassInfo.ResumeLayout(false);
            pnlClassInfo.PerformLayout();
            pnlMemberPreview.ResumeLayout(false);
            pnlMemberPreview.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDialogTitle;
        private System.Windows.Forms.Panel pnlClassInfo;
        private System.Windows.Forms.Label lblSpotsRemaining;
        private System.Windows.Forms.Label lblClassSchedule;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblClassBadge;
        private System.Windows.Forms.Label lblSelectMember;
        private System.Windows.Forms.ComboBox cboMember;
        private System.Windows.Forms.Panel pnlMemberPreview;
        private System.Windows.Forms.Label lblValidationNotice;
        private System.Windows.Forms.Label lblMemberPlanExpiry;
        private System.Windows.Forms.Label lblMemberStatusBadge;
        private System.Windows.Forms.Label lblMemberPhone;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnConfirmBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

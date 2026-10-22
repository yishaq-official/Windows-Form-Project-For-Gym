namespace GymMembershipSystem.Forms.Payments
{
    partial class RecordPaymentDialog
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
            lblMember = new System.Windows.Forms.Label();
            cboMember = new System.Windows.Forms.ComboBox();
            pnlBalanceCard = new System.Windows.Forms.Panel();
            lblBalanceSubtitle = new System.Windows.Forms.Label();
            lblBalanceDisplay = new System.Windows.Forms.Label();
            lblAmount = new System.Windows.Forms.Label();
            numAmount = new System.Windows.Forms.NumericUpDown();
            lblPaymentMethod = new System.Windows.Forms.Label();
            cboPaymentMethod = new System.Windows.Forms.ComboBox();
            lblPaymentDate = new System.Windows.Forms.Label();
            dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblErrorMessage = new System.Windows.Forms.Label();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlBalanceCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
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
            lblDialogTitle.Size = new System.Drawing.Size(155, 25);
            lblDialogTitle.TabIndex = 0;
            lblDialogTitle.Text = "Record Payment";
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMember.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblMember.Location = new System.Drawing.Point(28, 76);
            lblMember.Name = "lblMember";
            lblMember.Size = new System.Drawing.Size(91, 15);
            lblMember.TabIndex = 1;
            lblMember.Text = "Select Member:";
            // 
            // cboMember
            // 
            cboMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cboMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cboMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboMember.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboMember.FormattingEnabled = true;
            cboMember.Location = new System.Drawing.Point(31, 96);
            cboMember.Name = "cboMember";
            cboMember.Size = new System.Drawing.Size(395, 24);
            cboMember.TabIndex = 2;
            cboMember.SelectedIndexChanged += cboMember_SelectedIndexChanged;
            cboMember.Validating += cboMember_Validating;
            // 
            // pnlBalanceCard
            // 
            pnlBalanceCard.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnlBalanceCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlBalanceCard.Controls.Add(lblBalanceSubtitle);
            pnlBalanceCard.Controls.Add(lblBalanceDisplay);
            pnlBalanceCard.Location = new System.Drawing.Point(31, 134);
            pnlBalanceCard.Name = "pnlBalanceCard";
            pnlBalanceCard.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            pnlBalanceCard.Size = new System.Drawing.Size(395, 60);
            pnlBalanceCard.TabIndex = 3;
            // 
            // lblBalanceSubtitle
            // 
            lblBalanceSubtitle.AutoSize = true;
            lblBalanceSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBalanceSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblBalanceSubtitle.Location = new System.Drawing.Point(12, 36);
            lblBalanceSubtitle.Name = "lblBalanceSubtitle";
            lblBalanceSubtitle.Size = new System.Drawing.Size(184, 13);
            lblBalanceSubtitle.TabIndex = 1;
            lblBalanceSubtitle.Text = "Calculated: Total Billed - Total Paid";
            // 
            // lblBalanceDisplay
            // 
            lblBalanceDisplay.AutoSize = true;
            lblBalanceDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBalanceDisplay.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblBalanceDisplay.Location = new System.Drawing.Point(11, 11);
            lblBalanceDisplay.Name = "lblBalanceDisplay";
            lblBalanceDisplay.Size = new System.Drawing.Size(200, 21);
            lblBalanceDisplay.TabIndex = 0;
            lblBalanceDisplay.Text = "Outstanding Balance: $0.00";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAmount.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblAmount.Location = new System.Drawing.Point(28, 208);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new System.Drawing.Size(117, 15);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Payment Amount ($):";
            // 
            // numAmount
            // 
            numAmount.DecimalPlaces = 2;
            numAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numAmount.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numAmount.Location = new System.Drawing.Point(31, 228);
            numAmount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numAmount.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numAmount.Name = "numAmount";
            numAmount.Size = new System.Drawing.Size(185, 25);
            numAmount.TabIndex = 5;
            numAmount.ThousandsSeparator = true;
            numAmount.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numAmount.Validating += numAmount_Validating;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblPaymentMethod.Location = new System.Drawing.Point(238, 208);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new System.Drawing.Size(103, 15);
            lblPaymentMethod.TabIndex = 6;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Location = new System.Drawing.Point(241, 228);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new System.Drawing.Size(185, 24);
            cboPaymentMethod.TabIndex = 7;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPaymentDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblPaymentDate.Location = new System.Drawing.Point(28, 268);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new System.Drawing.Size(84, 15);
            lblPaymentDate.TabIndex = 8;
            lblPaymentDate.Text = "Payment Date:";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new System.Drawing.Point(31, 288);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new System.Drawing.Size(185, 24);
            dtpPaymentDate.TabIndex = 9;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNotes.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblNotes.Location = new System.Drawing.Point(28, 326);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(139, 15);
            lblNotes.TabIndex = 10;
            lblNotes.Text = "Notes / Receipt Number:";
            // 
            // txtNotes
            // 
            txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNotes.Location = new System.Drawing.Point(31, 346);
            txtNotes.MaxLength = 200;
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "Optional transaction memo or check #...";
            txtNotes.Size = new System.Drawing.Size(395, 52);
            txtNotes.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(286, 440);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(140, 36);
            btnSave.TabIndex = 12;
            btnSave.Text = "💳 Record Payment";
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
            btnCancel.Location = new System.Drawing.Point(178, 440);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 36);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            lblErrorMessage.Location = new System.Drawing.Point(31, 404);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            lblErrorMessage.Size = new System.Drawing.Size(395, 24);
            lblErrorMessage.TabIndex = 14;
            lblErrorMessage.Text = "Validation error message";
            lblErrorMessage.Visible = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // RecordPaymentDialog
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(460, 492);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(dtpPaymentDate);
            Controls.Add(lblPaymentDate);
            Controls.Add(cboPaymentMethod);
            Controls.Add(lblPaymentMethod);
            Controls.Add(numAmount);
            Controls.Add(lblAmount);
            Controls.Add(pnlBalanceCard);
            Controls.Add(cboMember);
            Controls.Add(lblMember);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RecordPaymentDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Record Member Payment";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBalanceCard.ResumeLayout(false);
            pnlBalanceCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDialogTitle;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.ComboBox cboMember;
        private System.Windows.Forms.Panel pnlBalanceCard;
        private System.Windows.Forms.Label lblBalanceDisplay;
        private System.Windows.Forms.Label lblBalanceSubtitle;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

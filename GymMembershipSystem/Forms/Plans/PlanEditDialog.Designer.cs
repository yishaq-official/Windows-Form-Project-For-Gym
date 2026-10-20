namespace GymMembershipSystem.Forms.Plans
{
    partial class PlanEditDialog
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
            lblPlanName = new System.Windows.Forms.Label();
            txtPlanName = new System.Windows.Forms.TextBox();
            lblDuration = new System.Windows.Forms.Label();
            numDurationDays = new System.Windows.Forms.NumericUpDown();
            lblPrice = new System.Windows.Forms.Label();
            numPrice = new System.Windows.Forms.NumericUpDown();
            chkIsActive = new System.Windows.Forms.CheckBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblErrorMessage = new System.Windows.Forms.Label();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDurationDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
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
            pnlHeader.Size = new System.Drawing.Size(420, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblDialogTitle
            // 
            lblDialogTitle.AutoSize = true;
            lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDialogTitle.ForeColor = System.Drawing.Color.White;
            lblDialogTitle.Location = new System.Drawing.Point(24, 18);
            lblDialogTitle.Name = "lblDialogTitle";
            lblDialogTitle.Size = new System.Drawing.Size(169, 25);
            lblDialogTitle.TabIndex = 0;
            lblDialogTitle.Text = "Membership Plan";
            // 
            // lblPlanName
            // 
            lblPlanName.AutoSize = true;
            lblPlanName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPlanName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblPlanName.Location = new System.Drawing.Point(28, 80);
            lblPlanName.Name = "lblPlanName";
            lblPlanName.Size = new System.Drawing.Size(68, 15);
            lblPlanName.TabIndex = 1;
            lblPlanName.Text = "Plan Name:";
            // 
            // txtPlanName
            // 
            txtPlanName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPlanName.Location = new System.Drawing.Point(31, 100);
            txtPlanName.MaxLength = 50;
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new System.Drawing.Size(355, 24);
            txtPlanName.TabIndex = 2;
            txtPlanName.Validating += txtPlanName_Validating;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDuration.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblDuration.Location = new System.Drawing.Point(28, 140);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new System.Drawing.Size(94, 15);
            lblDuration.TabIndex = 3;
            lblDuration.Text = "Duration (Days):";
            // 
            // numDurationDays
            // 
            numDurationDays.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numDurationDays.Location = new System.Drawing.Point(31, 160);
            numDurationDays.Maximum = new decimal(new int[] { 730, 0, 0, 0 });
            numDurationDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDurationDays.Name = "numDurationDays";
            numDurationDays.Size = new System.Drawing.Size(165, 24);
            numDurationDays.TabIndex = 4;
            numDurationDays.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPrice.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lblPrice.Location = new System.Drawing.Point(218, 140);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(55, 15);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price ($):";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numPrice.Location = new System.Drawing.Point(221, 160);
            numPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrice.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numPrice.Name = "numPrice";
            numPrice.Size = new System.Drawing.Size(165, 24);
            numPrice.TabIndex = 6;
            numPrice.Value = new decimal(new int[] { 3000, 0, 0, 131072 });
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIsActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            chkIsActive.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            chkIsActive.Location = new System.Drawing.Point(31, 202);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new System.Drawing.Size(201, 19);
            chkIsActive.TabIndex = 7;
            chkIsActive.Text = "Active (available for subscription)";
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
            btnSave.Location = new System.Drawing.Point(171, 255);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(105, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Plan";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            btnCancel.Location = new System.Drawing.Point(282, 255);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(104, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            lblErrorMessage.Location = new System.Drawing.Point(31, 226);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new System.Drawing.Size(355, 23);
            lblErrorMessage.TabIndex = 10;
            lblErrorMessage.Visible = false;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // PlanEditDialog
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(420, 310);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(numPrice);
            Controls.Add(lblPrice);
            Controls.Add(numDurationDays);
            Controls.Add(lblDuration);
            Controls.Add(txtPlanName);
            Controls.Add(lblPlanName);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlanEditDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Configure Plan";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDurationDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDialogTitle;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDurationDays;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

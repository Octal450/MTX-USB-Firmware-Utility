
namespace MTX_USB_Firmware_Utility
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MtxWizard = new AeroWizard.WizardControl();
            this.SelPage = new AeroWizard.WizardPage();
            this.rbtnPostHex = new System.Windows.Forms.RadioButton();
            this.rbtn128Hex = new System.Windows.Forms.RadioButton();
            this.rbtn64aHex = new System.Windows.Forms.RadioButton();
            this.rbtnOgHex = new System.Windows.Forms.RadioButton();
            this.rbtnBackup = new System.Windows.Forms.RadioButton();
            this.BusyPage = new AeroWizard.WizardPage();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxProgressBar = new System.Windows.Forms.ProgressBar();
            this.FailedPage = new AeroWizard.WizardPage();
            this.failedReason = new System.Windows.Forms.Label();
            this.FinishPage = new AeroWizard.WizardPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsole2 = new System.Windows.Forms.TextBox();
            this.txtConsole1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MtxWizard)).BeginInit();
            this.SelPage.SuspendLayout();
            this.BusyPage.SuspendLayout();
            this.FailedPage.SuspendLayout();
            this.FinishPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MtxWizard
            // 
            this.MtxWizard.BackColor = System.Drawing.Color.White;
            this.MtxWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtxWizard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxWizard.Location = new System.Drawing.Point(0, 0);
            this.MtxWizard.Name = "MtxWizard";
            this.MtxWizard.Pages.Add(this.SelPage);
            this.MtxWizard.Pages.Add(this.BusyPage);
            this.MtxWizard.Pages.Add(this.FailedPage);
            this.MtxWizard.Pages.Add(this.FinishPage);
            this.MtxWizard.Size = new System.Drawing.Size(554, 401);
            this.MtxWizard.TabIndex = 0;
            this.MtxWizard.Text = "MTX USB Firmware Utility";
            this.MtxWizard.Title = "MTX USB Firmware Utility";
            this.MtxWizard.TitleIcon = ((System.Drawing.Icon)(resources.GetObject("MtxWizard.TitleIcon")));
            // 
            // SelPage
            // 
            this.SelPage.AllowBack = false;
            this.SelPage.Controls.Add(this.rbtnPostHex);
            this.SelPage.Controls.Add(this.rbtn128Hex);
            this.SelPage.Controls.Add(this.rbtn64aHex);
            this.SelPage.Controls.Add(this.rbtnOgHex);
            this.SelPage.Controls.Add(this.rbtnBackup);
            this.SelPage.Name = "SelPage";
            this.SelPage.Size = new System.Drawing.Size(507, 247);
            this.SelPage.TabIndex = 0;
            this.SelPage.Text = "Select Operation";
            // 
            // rbtnPostHex
            // 
            this.rbtnPostHex.AutoSize = true;
            this.rbtnPostHex.Location = new System.Drawing.Point(4, 104);
            this.rbtnPostHex.Name = "rbtnPostHex";
            this.rbtnPostHex.Size = new System.Drawing.Size(140, 19);
            this.rbtnPostHex.TabIndex = 4;
            this.rbtnPostHex.Text = "Flash Post Sniffer HEX";
            this.rbtnPostHex.UseVisualStyleBackColor = true;
            // 
            // rbtn128Hex
            // 
            this.rbtn128Hex.AutoSize = true;
            this.rbtn128Hex.Location = new System.Drawing.Point(4, 79);
            this.rbtn128Hex.Name = "rbtn128Hex";
            this.rbtn128Hex.Size = new System.Drawing.Size(213, 19);
            this.rbtn128Hex.TabIndex = 3;
            this.rbtn128Hex.Text = "Flash 128 XSVF HEX - X360ACE/DGX";
            this.rbtn128Hex.UseVisualStyleBackColor = true;
            // 
            // rbtn64aHex
            // 
            this.rbtn64aHex.AutoSize = true;
            this.rbtn64aHex.Location = new System.Drawing.Point(4, 54);
            this.rbtn64aHex.Name = "rbtn64aHex";
            this.rbtn64aHex.Size = new System.Drawing.Size(291, 19);
            this.rbtn64aHex.TabIndex = 2;
            this.rbtn64aHex.Text = "Flash 64a XSVF HEX - Matrix/Coolrunner/360Squirt";
            this.rbtn64aHex.UseVisualStyleBackColor = true;
            // 
            // rbtnOgHex
            // 
            this.rbtnOgHex.AutoSize = true;
            this.rbtnOgHex.Location = new System.Drawing.Point(4, 29);
            this.rbtnOgHex.Name = "rbtnOgHex";
            this.rbtnOgHex.Size = new System.Drawing.Size(122, 19);
            this.rbtnOgHex.TabIndex = 1;
            this.rbtnOgHex.Text = "Flash Original HEX";
            this.rbtnOgHex.UseVisualStyleBackColor = true;
            // 
            // rbtnBackup
            // 
            this.rbtnBackup.AutoSize = true;
            this.rbtnBackup.Checked = true;
            this.rbtnBackup.Location = new System.Drawing.Point(4, 4);
            this.rbtnBackup.Name = "rbtnBackup";
            this.rbtnBackup.Size = new System.Drawing.Size(132, 19);
            this.rbtnBackup.TabIndex = 0;
            this.rbtnBackup.TabStop = true;
            this.rbtnBackup.Text = "Backup Current HEX";
            this.rbtnBackup.UseVisualStyleBackColor = true;
            // 
            // BusyPage
            // 
            this.BusyPage.AllowBack = false;
            this.BusyPage.AllowNext = false;
            this.BusyPage.Controls.Add(this.label2);
            this.BusyPage.Controls.Add(this.mtxProgressBar);
            this.BusyPage.Name = "BusyPage";
            this.BusyPage.ShowNext = false;
            this.BusyPage.Size = new System.Drawing.Size(507, 247);
            this.BusyPage.TabIndex = 1;
            this.BusyPage.Text = "Please Wait...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "This may take a few moments...";
            // 
            // mtxProgressBar
            // 
            this.mtxProgressBar.Location = new System.Drawing.Point(4, 24);
            this.mtxProgressBar.MarqueeAnimationSpeed = 50;
            this.mtxProgressBar.Name = "mtxProgressBar";
            this.mtxProgressBar.Size = new System.Drawing.Size(470, 23);
            this.mtxProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mtxProgressBar.TabIndex = 4;
            // 
            // FailedPage
            // 
            this.FailedPage.AllowBack = false;
            this.FailedPage.AllowCancel = false;
            this.FailedPage.Controls.Add(this.txtConsole1);
            this.FailedPage.Controls.Add(this.failedReason);
            this.FailedPage.IsFinishPage = true;
            this.FailedPage.Name = "FailedPage";
            this.FailedPage.Size = new System.Drawing.Size(507, 247);
            this.FailedPage.TabIndex = 3;
            this.FailedPage.Text = "Firmware Operation Failed";
            // 
            // failedReason
            // 
            this.failedReason.AutoSize = true;
            this.failedReason.Location = new System.Drawing.Point(4, 4);
            this.failedReason.Name = "failedReason";
            this.failedReason.Size = new System.Drawing.Size(76, 15);
            this.failedReason.TabIndex = 0;
            this.failedReason.Text = "FailedReason";
            // 
            // FinishPage
            // 
            this.FinishPage.AllowBack = false;
            this.FinishPage.AllowCancel = false;
            this.FinishPage.Controls.Add(this.txtConsole2);
            this.FinishPage.Controls.Add(this.label1);
            this.FinishPage.IsFinishPage = true;
            this.FinishPage.Name = "FinishPage";
            this.FinishPage.ShowCancel = false;
            this.FinishPage.Size = new System.Drawing.Size(507, 247);
            this.FinishPage.TabIndex = 2;
            this.FinishPage.Text = "Firmware Operation Completed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Successfully completed the operation! Click Finish to exit";
            // 
            // txtConsole2
            // 
            this.txtConsole2.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtConsole2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtConsole2.Location = new System.Drawing.Point(4, 46);
            this.txtConsole2.Multiline = true;
            this.txtConsole2.Name = "txtConsole2";
            this.txtConsole2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole2.Size = new System.Drawing.Size(470, 198);
            this.txtConsole2.TabIndex = 8;
            // 
            // txtConsole1
            // 
            this.txtConsole1.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtConsole1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtConsole1.Location = new System.Drawing.Point(4, 46);
            this.txtConsole1.Multiline = true;
            this.txtConsole1.Name = "txtConsole1";
            this.txtConsole1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole1.Size = new System.Drawing.Size(470, 198);
            this.txtConsole1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 401);
            this.Controls.Add(this.MtxWizard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MtxWizard)).EndInit();
            this.SelPage.ResumeLayout(false);
            this.SelPage.PerformLayout();
            this.BusyPage.ResumeLayout(false);
            this.BusyPage.PerformLayout();
            this.FailedPage.ResumeLayout(false);
            this.FailedPage.PerformLayout();
            this.FinishPage.ResumeLayout(false);
            this.FinishPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl MtxWizard;
        private AeroWizard.WizardPage SelPage;
        private System.Windows.Forms.RadioButton rbtnPostHex;
        private System.Windows.Forms.RadioButton rbtn128Hex;
        private System.Windows.Forms.RadioButton rbtn64aHex;
        private System.Windows.Forms.RadioButton rbtnOgHex;
        private System.Windows.Forms.RadioButton rbtnBackup;
        private AeroWizard.WizardPage BusyPage;
        private AeroWizard.WizardPage FinishPage;
        private AeroWizard.WizardPage FailedPage;
        private System.Windows.Forms.Label failedReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar mtxProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsole2;
        private System.Windows.Forms.TextBox txtConsole1;
    }
}
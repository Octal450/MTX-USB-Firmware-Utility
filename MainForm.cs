using PICUSB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MTX_USB_Firmware_Utility
{
    public partial class MainForm : Form
    {
        Bootloader_Interface bli;
        usb_interface usbi;
        string log = "";

        public MainForm()
        {
            InitializeComponent();
            MtxWizard.Cancelling += WizardCancelled;
            MtxWizard.Finished += WizardFinished;
            BusyPage.Initialize += BusyInit;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bli = new Bootloader_Interface();
            bli.DataChanged += new Bootloader_Interface.DataChangedEventHandler(onBLIDataChanged);
        }

        private void onBLIDataChanged(object sender, string comment)
        {
            log += comment;
            log += bli.DisplayData();
            txtConsole1.Text = log;
            txtConsole2.Text = log;
            if (log.Contains("ReadComplete") || log.Contains("Read Complete") || log.Contains("WriteComplete") || log.Contains("Write Complete")) MtxWizard.NextPage(FinishPage);
        }

        private void WizardCancelled(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void WizardFinished(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BusyInit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            startOperation();
        }

        public void startOperation()
        {
            usbi = new usb_interface();
            log = "";
            txtConsole1.Clear();
            txtConsole2.Clear();

            if (usbi.GetDeviceCount(usbi.vid_pid_boot) > 0U)
            {
                if (rbtnBackup.Checked)
                {
                    bli.ReadPIC();
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "HEX files (*.hex)|*.hex|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save HEX File";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        bli.SaveHEX(saveFileDialog.FileName);
                    }
                }
                else if (rbtnOgHex.Checked)
                {
                    bli.LoadHEX("matrix_orig.hex");
                    bli.WritePIC(false, false, false);
                }
                else if (rbtn64aHex.Checked)
                {
                    bli.LoadHEX("matrix_64a.hex");
                    bli.WritePIC(false, false, false);
                }
                else if (rbtn128Hex.Checked)
                {
                    bli.LoadHEX("matrix_128.hex");
                    bli.WritePIC(false, false, false);
                }
                else if (rbtnPostHex.Checked)
                {
                    bli.LoadHEX("matrix_post.hex");
                    bli.WritePIC(false, false, false);
                }
                else
                {
                    failedReason.Text = "Operation failed, but we don't know why";
                    MtxWizard.NextPage(FailedPage);
                }
            }
            else
            {
                failedReason.Text = "Could not find MTX USB in Bootloader Mode";
                MtxWizard.NextPage(FailedPage);
            }
        }
    }
}

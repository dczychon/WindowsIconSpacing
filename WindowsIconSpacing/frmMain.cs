using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using Microsoft.Win32;

namespace WindowsIconSpacing
{
    public partial class frmMain : Form
    {
        private int HorizontalValue, VerticalValue;
        private bool RequireRestart = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            Text = string.Format("{0} - v.{1}", fvi.ProductName, fvi.ProductVersion.ToString());

            LoadFromRegistry();
            RefreshUI();
        }

        private void LoadFromRegistry()
        {
            HorizontalValue = Convert.ToInt32(Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\WindowMetrics", "IconSpacing", "0"));
            VerticalValue = Convert.ToInt32(Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\WindowMetrics", "IconVerticalSpacing", "0"));
        }

        private void btnLoadFromRegistry_Click(object sender, EventArgs e)
        {
            LoadFromRegistry();
            RefreshUI();
        }

        private void RefreshUI()
        {
            nudVertical.Value = VerticalValue;
            tbVertical.Value = VerticalValue;

            nudHorizontal.Value = HorizontalValue;
            tbHorizontal.Value = HorizontalValue;
        }

        private void ApplyConfiguration()
        {
            try
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\WindowMetrics", "IconSpacing", HorizontalValue.ToString());
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\WindowMetrics", "IconVerticalSpacing", VerticalValue.ToString());
                RequireRestart = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Fehler!");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult MsgResult = MessageBox.Show(this, "Apply changes to registry?", "Apply?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (MsgResult == DialogResult.Yes)
            {
                VerticalValue = tbVertical.Value;
                HorizontalValue = tbHorizontal.Value;
                ApplyConfiguration();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RequireRestart == true)
            {
                DialogResult MsgResult = MessageBox.Show(this, "A restart is required to load the new values. Restart now?", "Restart required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (MsgResult == DialogResult.Yes)
                {
                    ProcessStartInfo ShutdownCommand = new ProcessStartInfo();
                    ShutdownCommand.FileName = "shutdown";
                    ShutdownCommand.Arguments = "/r /t 0";

                    Process.Start(ShutdownCommand);
                }
            }
        }

        #region Interactive Refresh
        private void tbHorizontal_ValueChanged(object sender, EventArgs e)
        {
            nudHorizontal.Value = tbHorizontal.Value;
        }

        private void tbVertical_ValueChanged(object sender, EventArgs e)
        {
            nudVertical.Value = tbVertical.Value;
        }

        private void nudHorizontal_ValueChanged(object sender, EventArgs e)
        {
            tbHorizontal.Value = Convert.ToInt32(nudHorizontal.Value);
        }

        private void nudVertical_ValueChanged(object sender, EventArgs e)
        {
            tbVertical.Value = Convert.ToInt32(nudVertical.Value);
        }
        #endregion

    }
}

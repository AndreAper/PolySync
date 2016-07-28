using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolySync
{
    public partial class frmSyncTaskDialog : Form
    {
        private SyncTask _task;

        public SyncTask SyncTask { get { return _task; } }

        public frmSyncTaskDialog()
        {
            InitializeComponent();
            _task = new SyncTask();
        }

        public frmSyncTaskDialog(SyncTask task)
        {
            InitializeComponent();
            _task = task;
            this.Text = "Edit Sync Task";

            _tbxName.Text = _task.Name;
            _tbxSrc.Text = _task.Source;
            _tbxDest.Text = _task.Destination;
            _tbxInterval.Text = _task.Interval.ToString();
            _dtpTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, _task.Time.Hours, _task.Time.Minutes, _task.Time.Seconds);
        }

        private void _tbxName_TextChanged(object sender, EventArgs e)
        {
            _task.Name = _tbxName.Text;
        }

        private void _tbxSrc_TextChanged(object sender, EventArgs e)
        {
            _task.Source = _tbxSrc.Text;
        }

        private void _tbxDest_TextChanged(object sender, EventArgs e)
        {
            _task.Destination = _tbxDest.Text;
        }

        private void _tbxInterval_TextChanged(object sender, EventArgs e)
        {
            _task.Interval = Convert.ToInt32(_tbxInterval.Text);
        }

        private void _dtpTime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(_dtpTime.Value.Hour, _dtpTime.Value.Minute, _dtpTime.Value.Second);
            _task.Time = ts;
        }

        private void _btnSelectSrc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select source directory.";
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                _task.Source = fbd.SelectedPath;
                _tbxSrc.Text = _task.Source;
            }
        }

        private void _btnSelectDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select destination directory.";
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                _task.Destination = fbd.SelectedPath;
                _tbxDest.Text = _task.Destination;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace PolySync
{
    public partial class frmMain : Form
    {
        List<SyncTask> _taskList;

        private void Copy() { }

        private void Copy(int taskIndex) { }

        public void Serialize()
        {
            if (_taskList != null)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<SyncTask>));
                    using (TextWriter writer = new StreamWriter(@"tasklist.xml"))
                    {
                        serializer.Serialize(writer, _taskList);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<SyncTask> Deserialize()
        {
            if (File.Exists(@"tasklist.xml"))
            {
                try
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<SyncTask>));
                    TextReader reader = new StreamReader(@"tasklist.xml");
                    object obj = deserializer.Deserialize(reader);
                    List<SyncTask> lst = (List<SyncTask>)obj;
                    reader.Close();

                    return lst;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return new List<SyncTask>();
            }
        }

        private void UpdateTaskList()
        {
            _dgvSyncTasks.Rows.Clear();

            for (int i = 0; i < _taskList.Count; i++)
            {
                _dgvSyncTasks.Rows.Add(_taskList[i].Name, _taskList[i].Source, _taskList[i].Destination, _taskList[i].Interval, _taskList[i].Time.ToString(), "Copy", "", "Edit");
                DataGridViewButtonCell btn = _dgvSyncTasks.Rows[i].Cells[6] as DataGridViewButtonCell;

                if (_taskList[i].Enabled)
                {
                    btn.Style.BackColor = Color.GreenYellow;
                    btn.Value = "Enabled";
                }
                else
                {
                    btn.Style.BackColor = Color.Crimson;
                    btn.Value = "Disabled";
                }

                _dgvSyncTasks.Rows[i].Height = 30;
            }

            Serialize();
        }

        public frmMain()
        {
            InitializeComponent();
            _taskList = new List<SyncTask>();
            _taskList = Deserialize();

            if (_taskList != null && _taskList.Count > 0)
            {
                UpdateTaskList();
            }

        }

        private void _btnAddTask_Click(object sender, EventArgs e)
        {
            frmSyncTaskDialog dlg = new frmSyncTaskDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _taskList.Add(dlg.SyncTask);
                UpdateTaskList();
            }
        }

        private void _btnRemoveTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_dgvSyncTasks.CurrentCell.RowIndex.ToString());
        }

        private void _dgvSyncTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                Process.Start("explorer.exe", _dgvSyncTasks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()); 
            }

            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("Copy started for task " + _dgvSyncTasks.Rows[e.RowIndex].ToString());
            }

            if (e.ColumnIndex == 6)
            {
                _taskList[e.RowIndex].Enabled = !(_taskList[e.RowIndex].Enabled);
                UpdateTaskList();
            }

            if (e.ColumnIndex == 7)
            {
                frmSyncTaskDialog frm = new frmSyncTaskDialog(_taskList[e.RowIndex]);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _taskList[e.RowIndex] = frm.SyncTask;
                    UpdateTaskList();
                }
            }
        }
    }
}

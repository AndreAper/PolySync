namespace PolySync
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this._dgvSyncTasks = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnAddTask = new System.Windows.Forms.Button();
            this._btnRemoveTask = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrcDir = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DestDir = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForceCopy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Enabled = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this._tlpBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvSyncTasks)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tlpBody
            // 
            this._tlpBody.ColumnCount = 1;
            this._tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpBody.Controls.Add(this._dgvSyncTasks, 0, 1);
            this._tlpBody.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this._tlpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpBody.Location = new System.Drawing.Point(0, 0);
            this._tlpBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._tlpBody.Name = "_tlpBody";
            this._tlpBody.RowCount = 2;
            this._tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this._tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpBody.Size = new System.Drawing.Size(1254, 641);
            this._tlpBody.TabIndex = 0;
            // 
            // _dgvSyncTasks
            // 
            this._dgvSyncTasks.AllowUserToAddRows = false;
            this._dgvSyncTasks.AllowUserToDeleteRows = false;
            this._dgvSyncTasks.AllowUserToResizeColumns = false;
            this._dgvSyncTasks.AllowUserToResizeRows = false;
            this._dgvSyncTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvSyncTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvSyncTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvSyncTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.SrcDir,
            this.DestDir,
            this.Interval,
            this.Time,
            this.ForceCopy,
            this.Enabled,
            this.Edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvSyncTasks.DefaultCellStyle = dataGridViewCellStyle2;
            this._dgvSyncTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvSyncTasks.Location = new System.Drawing.Point(0, 37);
            this._dgvSyncTasks.Margin = new System.Windows.Forms.Padding(0);
            this._dgvSyncTasks.MultiSelect = false;
            this._dgvSyncTasks.Name = "_dgvSyncTasks";
            this._dgvSyncTasks.ReadOnly = true;
            this._dgvSyncTasks.Size = new System.Drawing.Size(1254, 604);
            this._dgvSyncTasks.TabIndex = 0;
            this._dgvSyncTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvSyncTasks_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Controls.Add(this._btnAddTask);
            this.flowLayoutPanel1.Controls.Add(this._btnRemoveTask);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1254, 37);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // _btnAddTask
            // 
            this._btnAddTask.BackColor = System.Drawing.Color.DimGray;
            this._btnAddTask.FlatAppearance.BorderSize = 0;
            this._btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this._btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAddTask.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._btnAddTask.Location = new System.Drawing.Point(3, 3);
            this._btnAddTask.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this._btnAddTask.Name = "_btnAddTask";
            this._btnAddTask.Size = new System.Drawing.Size(117, 31);
            this._btnAddTask.TabIndex = 0;
            this._btnAddTask.Text = "Add Task";
            this._btnAddTask.UseVisualStyleBackColor = false;
            this._btnAddTask.Click += new System.EventHandler(this._btnAddTask_Click);
            // 
            // _btnRemoveTask
            // 
            this._btnRemoveTask.BackColor = System.Drawing.Color.DimGray;
            this._btnRemoveTask.FlatAppearance.BorderSize = 0;
            this._btnRemoveTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this._btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRemoveTask.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._btnRemoveTask.Location = new System.Drawing.Point(123, 3);
            this._btnRemoveTask.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this._btnRemoveTask.Name = "_btnRemoveTask";
            this._btnRemoveTask.Size = new System.Drawing.Size(117, 31);
            this._btnRemoveTask.TabIndex = 0;
            this._btnRemoveTask.Text = "Remove Task";
            this._btnRemoveTask.UseVisualStyleBackColor = false;
            this._btnRemoveTask.Click += new System.EventHandler(this._btnRemoveTask_Click);
            // 
            // TaskName
            // 
            this.TaskName.FillWeight = 87.05584F;
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // SrcDir
            // 
            this.SrcDir.FillWeight = 87.05584F;
            this.SrcDir.HeaderText = "Source";
            this.SrcDir.Name = "SrcDir";
            this.SrcDir.ReadOnly = true;
            this.SrcDir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SrcDir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SrcDir.ToolTipText = "Click to open folder.";
            // 
            // DestDir
            // 
            this.DestDir.FillWeight = 87.05584F;
            this.DestDir.HeaderText = "Destination";
            this.DestDir.Name = "DestDir";
            this.DestDir.ReadOnly = true;
            this.DestDir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DestDir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DestDir.ToolTipText = "Click to open folder.";
            // 
            // Interval
            // 
            this.Interval.FillWeight = 87.05584F;
            this.Interval.HeaderText = "Interval";
            this.Interval.Name = "Interval";
            this.Interval.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.FillWeight = 87.05584F;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // ForceCopy
            // 
            this.ForceCopy.FillWeight = 40F;
            this.ForceCopy.HeaderText = "Force Copy";
            this.ForceCopy.Name = "ForceCopy";
            this.ForceCopy.ReadOnly = true;
            // 
            // Enabled
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GreenYellow;
            this.Enabled.DefaultCellStyle = dataGridViewCellStyle1;
            this.Enabled.FillWeight = 40F;
            this.Enabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enabled.HeaderText = "Enabled";
            this.Enabled.Name = "Enabled";
            this.Enabled.ReadOnly = true;
            this.Enabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 40F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 641);
            this.Controls.Add(this._tlpBody);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "PolySync";
            this._tlpBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvSyncTasks)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tlpBody;
        private System.Windows.Forms.DataGridView _dgvSyncTasks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _btnAddTask;
        private System.Windows.Forms.Button _btnRemoveTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewLinkColumn SrcDir;
        private System.Windows.Forms.DataGridViewLinkColumn DestDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewButtonColumn ForceCopy;
        private System.Windows.Forms.DataGridViewButtonColumn Enabled;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}


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
            this._tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this._dgvSyncTasks = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrcDir = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DestDir = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this._tlpBody.Size = new System.Drawing.Size(1276, 832);
            this._tlpBody.TabIndex = 0;
            // 
            // _dgvSyncTasks
            // 
            this._dgvSyncTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvSyncTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvSyncTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.SrcDir,
            this.DestDir,
            this.Interval,
            this.Time,
            this.Copy,
            this.Edit});
            this._dgvSyncTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvSyncTasks.Location = new System.Drawing.Point(0, 37);
            this._dgvSyncTasks.Margin = new System.Windows.Forms.Padding(0);
            this._dgvSyncTasks.Name = "_dgvSyncTasks";
            this._dgvSyncTasks.Size = new System.Drawing.Size(1276, 795);
            this._dgvSyncTasks.TabIndex = 0;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.Name = "TaskName";
            // 
            // SrcDir
            // 
            this.SrcDir.HeaderText = "Source";
            this.SrcDir.Name = "SrcDir";
            this.SrcDir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SrcDir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DestDir
            // 
            this.DestDir.HeaderText = "Destination";
            this.DestDir.Name = "DestDir";
            this.DestDir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DestDir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Interval
            // 
            this.Interval.HeaderText = "Interval";
            this.Interval.Name = "Interval";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Copy
            // 
            this.Copy.HeaderText = "Copy";
            this.Copy.Name = "Copy";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1276, 37);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Task";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(123, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "Remove Task";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 832);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewLinkColumn SrcDir;
        private System.Windows.Forms.DataGridViewLinkColumn DestDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewButtonColumn Copy;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


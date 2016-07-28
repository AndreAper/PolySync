namespace PolySync
{
    partial class frmSyncTaskDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this._tbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbxSrc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbxDest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._tbxInterval = new System.Windows.Forms.TextBox();
            this._dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this._btnSelectSrc = new System.Windows.Forms.Button();
            this._btnSelectDest = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _tbxName
            // 
            this._tbxName.Location = new System.Drawing.Point(105, 21);
            this._tbxName.Name = "_tbxName";
            this._tbxName.Size = new System.Drawing.Size(260, 25);
            this._tbxName.TabIndex = 10;
            this._tbxName.TextChanged += new System.EventHandler(this._tbxName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Source";
            // 
            // _tbxSrc
            // 
            this._tbxSrc.Location = new System.Drawing.Point(105, 52);
            this._tbxSrc.Name = "_tbxSrc";
            this._tbxSrc.Size = new System.Drawing.Size(260, 25);
            this._tbxSrc.TabIndex = 20;
            this._tbxSrc.TextChanged += new System.EventHandler(this._tbxSrc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination";
            // 
            // _tbxDest
            // 
            this._tbxDest.Location = new System.Drawing.Point(105, 83);
            this._tbxDest.Name = "_tbxDest";
            this._tbxDest.Size = new System.Drawing.Size(260, 25);
            this._tbxDest.TabIndex = 30;
            this._tbxDest.TextChanged += new System.EventHandler(this._tbxDest_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Interval (ms)";
            // 
            // _tbxInterval
            // 
            this._tbxInterval.Location = new System.Drawing.Point(105, 114);
            this._tbxInterval.Name = "_tbxInterval";
            this._tbxInterval.Size = new System.Drawing.Size(260, 25);
            this._tbxInterval.TabIndex = 40;
            this._tbxInterval.TextChanged += new System.EventHandler(this._tbxInterval_TextChanged);
            // 
            // _dtpTime
            // 
            this._dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._dtpTime.Location = new System.Drawing.Point(105, 145);
            this._dtpTime.Name = "_dtpTime";
            this._dtpTime.ShowUpDown = true;
            this._dtpTime.Size = new System.Drawing.Size(260, 25);
            this._dtpTime.TabIndex = 50;
            this._dtpTime.ValueChanged += new System.EventHandler(this._dtpTime_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Time";
            // 
            // _btnSelectSrc
            // 
            this._btnSelectSrc.Location = new System.Drawing.Point(371, 52);
            this._btnSelectSrc.Name = "_btnSelectSrc";
            this._btnSelectSrc.Size = new System.Drawing.Size(44, 25);
            this._btnSelectSrc.TabIndex = 25;
            this._btnSelectSrc.Text = "...";
            this._btnSelectSrc.UseVisualStyleBackColor = true;
            this._btnSelectSrc.Click += new System.EventHandler(this._btnSelectSrc_Click);
            // 
            // _btnSelectDest
            // 
            this._btnSelectDest.Location = new System.Drawing.Point(371, 83);
            this._btnSelectDest.Name = "_btnSelectDest";
            this._btnSelectDest.Size = new System.Drawing.Size(44, 25);
            this._btnSelectDest.TabIndex = 35;
            this._btnSelectDest.Text = "...";
            this._btnSelectDest.UseVisualStyleBackColor = true;
            this._btnSelectDest.Click += new System.EventHandler(this._btnSelectDest_Click);
            // 
            // _btnSave
            // 
            this._btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSave.Location = new System.Drawing.Point(12, 186);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(103, 26);
            this._btnSave.TabIndex = 604;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // _btnClose
            // 
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnClose.Location = new System.Drawing.Point(334, 186);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(103, 26);
            this._btnClose.TabIndex = 70;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            // 
            // frmSyncTaskDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 221);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnSelectDest);
            this.Controls.Add(this._btnSelectSrc);
            this.Controls.Add(this._dtpTime);
            this.Controls.Add(this._tbxInterval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._tbxDest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._tbxSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._tbxName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSyncTaskDialog";
            this.Text = "Add Sync Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbxSrc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbxDest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tbxInterval;
        private System.Windows.Forms.DateTimePicker _dtpTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _btnSelectSrc;
        private System.Windows.Forms.Button _btnSelectDest;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnClose;
    }
}
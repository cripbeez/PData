namespace PData.GUI
{
    partial class Overview
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.leftMenu = new System.Windows.Forms.Panel();
            this.leftMenuBottomPanel = new System.Windows.Forms.Panel();
            this.leftMenuTopPanel = new System.Windows.Forms.Panel();
            this.leftMenuTopLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.searchBoxPanel = new System.Windows.Forms.Panel();
            this.searchBoxTxt = new System.Windows.Forms.TextBox();
            this.bottomMenuPanel = new System.Windows.Forms.Panel();
            this.bottomMenuControlsPanel = new System.Windows.Forms.Panel();
            this.btnAssigned = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.statusBtnContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.assignedBtnContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.leftMenu.SuspendLayout();
            this.leftMenuTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.searchBoxPanel.SuspendLayout();
            this.bottomMenuPanel.SuspendLayout();
            this.bottomMenuControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftMenu
            // 
            this.leftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.leftMenu.Controls.Add(this.leftMenuBottomPanel);
            this.leftMenu.Controls.Add(this.leftMenuTopPanel);
            this.leftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenu.Location = new System.Drawing.Point(0, 0);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.Size = new System.Drawing.Size(0, 490);
            this.leftMenu.TabIndex = 0;
            // 
            // leftMenuBottomPanel
            // 
            this.leftMenuBottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.leftMenuBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftMenuBottomPanel.Location = new System.Drawing.Point(0, 433);
            this.leftMenuBottomPanel.Name = "leftMenuBottomPanel";
            this.leftMenuBottomPanel.Size = new System.Drawing.Size(0, 57);
            this.leftMenuBottomPanel.TabIndex = 0;
            // 
            // leftMenuTopPanel
            // 
            this.leftMenuTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.leftMenuTopPanel.Controls.Add(this.leftMenuTopLabel);
            this.leftMenuTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftMenuTopPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMenuTopPanel.Name = "leftMenuTopPanel";
            this.leftMenuTopPanel.Size = new System.Drawing.Size(0, 60);
            this.leftMenuTopPanel.TabIndex = 1;
            // 
            // leftMenuTopLabel
            // 
            this.leftMenuTopLabel.AutoEllipsis = true;
            this.leftMenuTopLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.leftMenuTopLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftMenuTopLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMenuTopLabel.ForeColor = System.Drawing.Color.White;
            this.leftMenuTopLabel.Location = new System.Drawing.Point(0, 0);
            this.leftMenuTopLabel.Name = "leftMenuTopLabel";
            this.leftMenuTopLabel.Size = new System.Drawing.Size(0, 60);
            this.leftMenuTopLabel.TabIndex = 0;
            this.leftMenuTopLabel.Text = "Overview";
            this.leftMenuTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 60;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(875, 490);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.searchBoxPanel);
            this.containerPanel.Controls.Add(this.bottomMenuPanel);
            this.containerPanel.Controls.Add(this.leftMenu);
            this.containerPanel.Controls.Add(this.dataGridView1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(875, 490);
            this.containerPanel.TabIndex = 1;
            // 
            // searchBoxPanel
            // 
            this.searchBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.searchBoxPanel.Controls.Add(this.searchBoxTxt);
            this.searchBoxPanel.Location = new System.Drawing.Point(12, 12);
            this.searchBoxPanel.Name = "searchBoxPanel";
            this.searchBoxPanel.Padding = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.searchBoxPanel.Size = new System.Drawing.Size(325, 63);
            this.searchBoxPanel.TabIndex = 2;
            this.searchBoxPanel.Visible = false;
            // 
            // searchBoxTxt
            // 
            this.searchBoxTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBoxTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.searchBoxTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBoxTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchBoxTxt.ForeColor = System.Drawing.Color.White;
            this.searchBoxTxt.Location = new System.Drawing.Point(21, 23);
            this.searchBoxTxt.Name = "searchBoxTxt";
            this.searchBoxTxt.Size = new System.Drawing.Size(281, 18);
            this.searchBoxTxt.TabIndex = 0;
            this.searchBoxTxt.TextChanged += new System.EventHandler(this.searchBoxTxt_TextChanged);
            this.searchBoxTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBoxTxt_KeyDown);
            // 
            // bottomMenuPanel
            // 
            this.bottomMenuPanel.Controls.Add(this.bottomMenuControlsPanel);
            this.bottomMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomMenuPanel.Location = new System.Drawing.Point(0, 227);
            this.bottomMenuPanel.Name = "bottomMenuPanel";
            this.bottomMenuPanel.Padding = new System.Windows.Forms.Padding(5);
            this.bottomMenuPanel.Size = new System.Drawing.Size(875, 263);
            this.bottomMenuPanel.TabIndex = 1;
            this.bottomMenuPanel.Visible = false;
            // 
            // bottomMenuControlsPanel
            // 
            this.bottomMenuControlsPanel.Controls.Add(this.btnAssigned);
            this.bottomMenuControlsPanel.Controls.Add(this.btnStatus);
            this.bottomMenuControlsPanel.Location = new System.Drawing.Point(269, 74);
            this.bottomMenuControlsPanel.Name = "bottomMenuControlsPanel";
            this.bottomMenuControlsPanel.Size = new System.Drawing.Size(304, 116);
            this.bottomMenuControlsPanel.TabIndex = 1;
            // 
            // btnAssigned
            // 
            this.btnAssigned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAssigned.ContextMenuStrip = this.assignedBtnContextMenu;
            this.btnAssigned.FlatAppearance.BorderSize = 0;
            this.btnAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssigned.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAssigned.ForeColor = System.Drawing.Color.White;
            this.btnAssigned.Location = new System.Drawing.Point(155, 17);
            this.btnAssigned.Name = "btnAssigned";
            this.btnAssigned.Size = new System.Drawing.Size(128, 83);
            this.btnAssigned.TabIndex = 1;
            this.btnAssigned.Text = "Byt ansvarig";
            this.btnAssigned.UseVisualStyleBackColor = false;
            this.btnAssigned.Click += new System.EventHandler(this.btnAssigned_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnStatus.ContextMenuStrip = this.statusBtnContextMenu;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(21, 17);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(128, 83);
            this.btnStatus.TabIndex = 0;
            this.btnStatus.Text = "Byt projektstatus";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // statusBtnContextMenu
            // 
            this.statusBtnContextMenu.Name = "statusBtnContextMenu";
            this.statusBtnContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // assignedBtnContextMenu
            // 
            this.assignedBtnContextMenu.Name = "statusBtnContextMenu";
            this.assignedBtnContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(875, 490);
            this.ControlBox = false;
            this.Controls.Add(this.containerPanel);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Overview";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.Load += new System.EventHandler(this.Overview_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Overview_KeyDown);
            this.leftMenu.ResumeLayout(false);
            this.leftMenuTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.searchBoxPanel.ResumeLayout(false);
            this.searchBoxPanel.PerformLayout();
            this.bottomMenuPanel.ResumeLayout(false);
            this.bottomMenuControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftMenu;
        private System.Windows.Forms.Panel leftMenuTopPanel;
        private System.Windows.Forms.Panel leftMenuBottomPanel;
        private System.Windows.Forms.Label leftMenuTopLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel bottomMenuPanel;
        private System.Windows.Forms.TextBox searchBoxTxt;
        private System.Windows.Forms.Panel searchBoxPanel;
        private System.Windows.Forms.Panel bottomMenuControlsPanel;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnAssigned;
        private System.Windows.Forms.ContextMenuStrip statusBtnContextMenu;
        private System.Windows.Forms.ContextMenuStrip assignedBtnContextMenu;
    }
}
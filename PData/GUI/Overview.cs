using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PData.GUI
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }
        public new void Show()
        {
            base.ShowDialog();
        }

        #region "Methods"
        public void ShowLeftMenu()
        {
            if (leftMenu.Width > 0)
                return;

            Timer showTimer = new Timer();
            showTimer.Interval = 10;
            showTimer.Tick += (sender, e) =>
            {
                if (sender is Timer timer)
                {
                    if (leftMenu.Width < 230)
                    {
                        leftMenu.Width += 10;
                    }
                    else
                    {
                        timer.Stop();
                    }
                }
            };
            showTimer.Start();
        }
        public void HideLeftMenu()
        {
            if (leftMenu.Width < 230)
                return;

            Timer showTimer = new Timer();
            showTimer.Interval = 10;
            showTimer.Tick += (sender, e) =>
            {
                if (sender is Timer timer)
                {
                    if (leftMenu.Width > 0)
                    {
                        leftMenu.Width -= 10;
                    }
                    else
                    {
                        timer.Stop();
                    }
                }
            };
            showTimer.Start();
        }
        public void ToggleLeftMenu()
        {
            if (leftMenu.Width == 230)
                HideLeftMenu();

            if (leftMenu.Width == 0)
                ShowLeftMenu();

            return;
        }

        public void ShowBottomMenu()
        {
            if (bottomMenuPanel.Visible)
                return;

            dataGridView1.Enabled = false;
            bottomMenuPanel.Show();
        }
        public void HideBottomMenu()
        {
            if (!bottomMenuPanel.Visible)
                return;

            dataGridView1.Enabled = true;
            bottomMenuPanel.Hide();
        }
        public void AlignBottomMenuControls()
        {
            Point pt = new Point();
            pt.X = bottomMenuPanel.Width - bottomMenuControlsPanel.Width / 2;
            pt.Y = bottomMenuPanel.Height / 2 - bottomMenuControlsPanel.Height;
            bottomMenuControlsPanel.Location = pt;
        }
        
        public void SetupStatusButtonContextMenu()
        {
            statusBtnContextMenu.Items.Clear();

            foreach (string status in Data.Manager.Statuses)
                statusBtnContextMenu.Items.Add(status);

            foreach (ToolStripItem item in statusBtnContextMenu.Items)
                item.Click += (sender, e) =>
                {
                    if(dataGridView1.SelectedRows.Count == 1)
                    {
                        DataGridViewRow row = dataGridView1.SelectedRows[0];
                        DataGridViewColumn col = dataGridView1.Columns["Status"];
                        DataGridViewCell cell = dataGridView1[col.Index, row.Index];

                        cell.Value = item.Text.ToString();
                    }
                };
        }
        public void SetupAssignedButtonContextMenu()
        {
            assignedBtnContextMenu.Items.Clear();

            foreach (string signature in Data.Manager.Signatures)
                assignedBtnContextMenu.Items.Add(signature);

            foreach (ToolStripItem item in assignedBtnContextMenu.Items)
                item.Click += (sender, e) =>
                {
                    if (dataGridView1.SelectedRows.Count == 1)
                    {
                        DataGridViewRow row = dataGridView1.SelectedRows[0];
                        DataGridViewColumn col = dataGridView1.Columns["Ansvarig"];
                        DataGridViewCell cell = dataGridView1[col.Index, row.Index];

                        cell.Value = item.Text.ToString();
                    }
                };
        }

        public void ShowSearchMenu()
        {
            Point loc = new Point();
            loc.X = this.Width - searchBoxPanel.Width - 5;
            loc.Y = 5;

            searchBoxPanel.Location = loc;
            dataGridView1.Enabled = false;
            this.KeyPreview = false;
            searchBoxPanel.Show();
            searchBoxTxt.Focus();
        }
        public void HideSearchMenu()
        {
            dataGridView1.Enabled = true;
            dataGridView1.Focus();
            this.KeyPreview = true;
            searchBoxPanel.Hide();
        }
        
        private int CurrentColumn = 0;
        private void MoveColumnLeft()
        {
            int next = CurrentColumn - 1;

            if (next >= 0)
            {
                CurrentColumn = next;
                SortColumnAsc();
            }
        }
        private void MoveColumnRight()
        {
            int next = CurrentColumn + 1;

            if (next < dataGridView1.Columns.Count)
            {
                CurrentColumn = next;
                SortColumnAsc();
            }
        }
        private void SortColumnAsc()
        {
            dataGridView1.Sort(dataGridView1.Columns[CurrentColumn], ListSortDirection.Ascending);
        }
        private void SortColumnDesc()
        {
            dataGridView1.Sort(dataGridView1.Columns[CurrentColumn], ListSortDirection.Descending);
        }
        #endregion

        #region "Events"
        private void Overview_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            Cursor.Hide();

            Data.Manager.Setup();
            this.dataGridView1.DataSource = Data.Manager.TestTable;

            SetupAssignedButtonContextMenu();
            SetupStatusButtonContextMenu();
            AlignBottomMenuControls();
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                foreach (DataGridViewColumn col in dataGridView.Columns)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                CurrentColumn = 0;
                SortColumnAsc();
            }
        }
        private void Overview_KeyDown(object sender, KeyEventArgs e)
        {
            bool handled = false;

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ShowBottomMenu();
                    handled = true;
                    break;

                case Keys.Back:
                    HideBottomMenu();
                    dataGridView1.Focus();
                    handled = true;
                    break;

                case Keys.M:
                    ToggleLeftMenu();
                    handled = true;
                    break;

                case Keys.F:
                    ShowSearchMenu();
                    break;

                case Keys.Escape:
                    this.Close();
                    break;
            }

            /* column sorting */
            switch (e.KeyCode)
            {
                case Keys.NumPad4:
                    MoveColumnLeft();
                    handled = true;
                    break;

                case Keys.NumPad6:
                    MoveColumnRight();
                    handled = true;
                    break;

                case Keys.NumPad8:
                    SortColumnAsc();
                    handled = true;
                    break;

                case Keys.NumPad2:
                    SortColumnDesc();
                    handled = true;
                    break;

            }

            if (handled)
                e.SuppressKeyPress = true;

            e.Handled = handled;
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is DataGridView view)
                if (e.KeyCode == Keys.Enter)
                    e.SuppressKeyPress = true;
        }
        private void searchBoxTxt_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBoxTxt.Text;

            if(searchText == "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }

            StringBuilder filter = new StringBuilder();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (filter.ToString() == "")
                {
                    filter.Append("[" + column.Name + "] like '%" + searchText + "%'");
                }
                else
                {
                    filter.Append(" OR ");
                    filter.Append("[" + column.Name + "] like '%" + searchText + "%'");
                }
            }

            try { (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filter.ToString(); }
            catch { }
        }
        private void searchBoxTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox box)
                if (e.KeyCode == Keys.Enter)
                    HideSearchMenu();
        }
        #endregion

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                Point pt = new Point(btn.Width - 10, btn.Height - 10);
                pt = btn.PointToScreen(pt);
                btn.ContextMenuStrip.Show(pt);
            }
        }
        private void btnAssigned_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                Point pt = new Point(btn.Width - 10, btn.Height - 10);
                pt = btn.PointToScreen(pt);
                btn.ContextMenuStrip.Show(pt);
            }
        }
    }
}

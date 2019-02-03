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

        private void Overview_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            Cursor.Hide();

            Data.Manager.Setup();
            this.dataGridView1.DataSource = Data.Manager.TestTable;
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                foreach (DataGridViewColumn col in dataGridView.Columns)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filter.ToString();
        }
        private void searchBoxTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox box)
                if (e.KeyCode == Keys.Enter)
                    HideSearchMenu();
        }
    }
}

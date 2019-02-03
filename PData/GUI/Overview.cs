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
            // do stuff here later
        }
        private void Overview_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            Data.Manager.Setup();
            this.dataGridView1.DataSource = Data.Manager.TestTable;

            foreach (Control control in this.Controls)
                control.KeyPress += (ks, ke) =>
                {
                    if (ke.KeyChar == (char)Keys.Escape)
                        this.Close();
                };

            dataGridView1.KeyPress += (ks, ke) =>
            {
                if (ks is DataGridView dgv)
                {
                    bool handled = false;

                    switch ((Keys)ke.KeyChar)
                    {
                        case Keys.Enter:
                            menuPanel.Show();
                            handled = true;
                            break;

                        case Keys.Back:
                            menuPanel.Hide();
                            handled = false;
                            break;
                    }

                    ke.Handled = handled;
                }
            };
        }

        public new void Show()
        {
            base.ShowDialog();
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
    }
}

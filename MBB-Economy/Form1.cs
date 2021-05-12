using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBB_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            recalculateRDTable();
        }

        private void recalculateRDTable()
        {
            var queryAvgBuy =
                from transaction in dataGridView1.Rows.Cast<DataGridViewRow>()
                select transaction;

            dataGridView2.Rows.Clear();
            foreach (DataGridViewRow row in queryAvgBuy)
            {
                if(row.Cells[0].Value != "")
                {
                    dataGridView2.Rows.Add(row.Cells[0].Value);
                }
            }
        }
    }
}

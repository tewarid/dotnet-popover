using System;
using System.Drawing;
using System.Windows.Forms;

namespace Popup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                listView1.Items.Add("Test Item " + i);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            Popup p = new Popup();
            ListViewItem item = listView1.SelectedItems[0];
            p.Text = item.Text;
            Form.ShowPopup(p, listView1.PointToScreen(new Point(item.Bounds.X, item.Bounds.Y)), listView1);
        }
    }
}

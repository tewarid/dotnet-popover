using System;
using System.Drawing;
using System.Windows.Forms;

namespace Popover
{
    public partial class MainForm : Form
    {
        private PopoverForm popoverForm;

        public MainForm()
        {
            InitializeComponent();
        }

        public void ShowPopover(PopoverForm popup, Point location)
        {
            HidePopup();
            popoverForm = popup;
            popoverForm.Show(this);
            popoverForm.Location = location;
        }

        public void HidePopup()
        {
            popoverForm?.Hide();
            popoverForm?.Dispose();
            popoverForm = null;
        }

        protected override void OnMove(EventArgs e)
        {
            HidePopup();
            base.OnMove(e);
        }
    }
}

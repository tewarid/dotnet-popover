using System;
using System.Windows.Forms;

namespace Popup
{
    public partial class ListView : System.Windows.Forms.ListView
    {
        private const uint WM_HSCROLL = 0x114;
        private const uint WM_VSCROLL = 0x115;
        private const uint WM_MOUSEWHEEL = 0x020A;

        public event ScrollEventHandler Scroll;

        public ListView()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HSCROLL | m.Msg == WM_VSCROLL | m.Msg == WM_MOUSEWHEEL)
            {
                Form.HidePopup();
            }
            base.WndProc(ref m);
        }

        protected override void OnLeave(EventArgs e)
        {
            Form.HidePopup();
            base.OnLeave(e);
        }
    }
}

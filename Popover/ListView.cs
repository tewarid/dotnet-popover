using System;
using System.Windows.Forms;

namespace Popover
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
                ((MainForm)FindForm()).HidePopup();
                Scroll?.Invoke(this, new ScrollEventArgs(ScrollEventType.EndScroll, 0));
            }
            base.WndProc(ref m);
        }

        protected override void OnLeave(EventArgs e)
        {
            ((MainForm)FindForm()).HidePopup();
            base.OnLeave(e);
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Popup
{
    public partial class Form : System.Windows.Forms.Form
    {
        private static Popup popupForm;

        public Form()
        {
            InitializeComponent();
        }

        public static void ShowPopup(Popup popup, Point location, Control parent)
        {
            HidePopup();
            popupForm = popup;
            popupForm.Show(parent);
            popupForm.Location = location;
        }

        public static void HidePopup()
        {
            popupForm?.Hide();
            popupForm?.Dispose();
            popupForm = null;
        }

        protected override void OnMove(EventArgs e)
        {
            HidePopup();
            base.OnMove(e);
        }
    }
}

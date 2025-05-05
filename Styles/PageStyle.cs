using System.Runtime.InteropServices;

namespace ProductExport.Styles
{
    public static class PageStyle
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCAPTION = 0x2;
        private const int HTCLIENT = 0x1;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;

        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }

        public static bool AeroEnabled
        {
            get
            {
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    int enabled = 0;
                    _ = DwmIsCompositionEnabled(ref enabled);
                    return (enabled == 1);
                }
                return false;
            }
        }

        public static CreateParams ApplyDropShadow(CreateParams cp)
        {
            if (!AeroEnabled)
            {
                cp.ClassStyle |= CS_DROPSHADOW;
            }
            return cp;
        }

        public static void HandleWndProc(Form form, ref Message m)
        {
            if (m.Msg == WM_NCPAINT && AeroEnabled)
            {
                var v = 2;
                _ = DwmSetWindowAttribute(form.Handle, 2, ref v, 4);

                MARGINS margins = new MARGINS()
                {
                    cxLeftWidth = 0,
                    cxRightWidth = 0,
                    cyTopHeight = 0,
                    cyBottomHeight = 1
                };

                _ = DwmExtendFrameIntoClientArea(form.Handle, ref margins);
            }

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
            {
                m.Result = (IntPtr)HTCAPTION;
            }
        }

        public static void ApplyRoundedRegion(Form form, int radius) 
            => form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, radius, radius));
    }
}

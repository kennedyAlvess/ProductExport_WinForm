using ProductExport.Styles;

namespace ProductExport
{
    public partial class MainForms : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                return PageStyle.ApplyDropShadow(cp);
            }
        }

        protected override void WndProc(ref Message m)
        {
            PageStyle.HandleWndProc(this, ref m);
            base.WndProc(ref m);
        }

        public MainForms()
        {
            InitializeComponent();
            PageStyle.ApplyRoundedRegion(this, 10);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.ApplicationExitCall)
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Exit",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

using Infrastructure;

namespace ProductExport.Forms
{
    public partial class HomeForms : Form
    {
        public HomeForms()
        {
            InitializeComponent();
        }

        private void HomeForms_Load(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            productBindingSource.DataSource = context.Products.ToList();
            this.ControlBox = false;
        }

    }
}

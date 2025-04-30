using ProductExport.CustomComponents;

namespace ProductExport
{
    partial class MainForms
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForms));
            sideBar_Gradient1 = new SideBar_Gradient();
            btnExit = new Button();
            btnHelp = new Button();
            btnExport = new Button();
            btnHome = new Button();
            sideBar_Gradient1.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar_Gradient1
            // 
            sideBar_Gradient1.Controls.Add(btnExit);
            sideBar_Gradient1.Controls.Add(btnHelp);
            sideBar_Gradient1.Controls.Add(btnExport);
            sideBar_Gradient1.Controls.Add(btnHome);
            sideBar_Gradient1.Dock = DockStyle.Left;
            sideBar_Gradient1.GradientBottom = Color.FromArgb(179, 36, 130);
            sideBar_Gradient1.GradientTop = Color.FromArgb(243, 112, 35);
            sideBar_Gradient1.Location = new Point(0, 0);
            sideBar_Gradient1.Name = "sideBar_Gradient1";
            sideBar_Gradient1.Size = new Size(92, 500);
            sideBar_Gradient1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.TopCenter;
            btnExit.Location = new Point(-5, 446);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(59, 34);
            btnExit.TabIndex = 3;
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // btnHelp
            // 
            btnHelp.Cursor = Cursors.Hand;
            btnHelp.Image = (Image)resources.GetObject("btnHelp.Image");
            btnHelp.ImageAlign = ContentAlignment.TopCenter;
            btnHelp.Location = new Point(-5, 188);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(94, 51);
            btnHelp.TabIndex = 2;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.BottomCenter;
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Cursor = Cursors.Hand;
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.ImageAlign = ContentAlignment.TopCenter;
            btnExport.Location = new Point(-5, 131);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 51);
            btnExport.TabIndex = 1;
            btnExport.Text = "Export";
            btnExport.TextAlign = ContentAlignment.BottomCenter;
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.Cursor = Cursors.Hand;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.TopCenter;
            btnHome.Location = new Point(-5, 74);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 51);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.BottomCenter;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // MainForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 500);
            Controls.Add(sideBar_Gradient1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductExport";
            sideBar_Gradient1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private SideBar_Gradient sideBar_Gradient1;
        private Button btnHome;
        private Button btnHelp;
        private Button btnExport;
        private Button btnExit;
    }
}

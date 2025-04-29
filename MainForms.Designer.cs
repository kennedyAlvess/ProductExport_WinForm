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
            panel1 = new Panel();
            sideBar_Gradient1 = new SideBar_Gradient();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // sideBar_Gradient1
            // 
            sideBar_Gradient1.Dock = DockStyle.Left;
            sideBar_Gradient1.gradientBottom = Color.IndianRed;
            sideBar_Gradient1.gradientTop = Color.DarkSlateBlue;
            sideBar_Gradient1.Location = new Point(0, 0);
            sideBar_Gradient1.Name = "sideBar_Gradient1";
            sideBar_Gradient1.Size = new Size(170, 500);
            sideBar_Gradient1.TabIndex = 1;
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
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SideBar_Gradient sideBar_Gradient1;
    }
}

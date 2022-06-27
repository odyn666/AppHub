namespace MusicPlayerTut
{
    public partial class AppHub : Form
    {

        public AppHub()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void Time_tick()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CustomizeDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistManageSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;

            if (panelPlaylistManageSubMenu.Visible == true)
                panelPlaylistManageSubMenu.Visible = false;

            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMediaSubMenu);
        }

        private void BtnPlaylistManage_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPlaylistManageSubMenu);
        }

        private void BtnTools_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelToolsSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private Form? activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DrawFrom());
        }
    }
}
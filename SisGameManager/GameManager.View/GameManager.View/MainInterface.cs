namespace GameManager.View
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LblDescription.Visible = false;
            TxtText.Visible = false;
            BtnOption1.Visible = true;
            BtnOption1.Text = "Weapon";
            BtnOption2.Visible = true;
            BtnOption2.Text = "Potion";
            BtnOption3.Visible = true;
            BtnOption3.Text = "Armor";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            LblDescription.Visible = true;
            TxtText.Visible = true;
            LblDescription.Text = "Enter with ID:";
            BtnOption1.Visible = false;
            BtnOption2.Visible = false;
            BtnOption3.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LblDescription.Visible = true;
            TxtText.Visible = true;
            LblDescription.Text = "Enter with name:";
            BtnOption1.Visible = false;
            BtnOption2.Visible = false;
            BtnOption3.Visible = false;
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            LblDescription.Visible = false;
            TxtText.Visible = false;
            BtnOption1.Visible = false;
            BtnOption2.Visible = false;
            BtnOption3.Visible = false;
        }
    }
}

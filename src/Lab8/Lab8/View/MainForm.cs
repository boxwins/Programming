namespace Lab8
{
    /// <summary>
    /// Главная форма.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            songListPanel.LoadData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            songListPanel.SaveData();
        }
    }
}

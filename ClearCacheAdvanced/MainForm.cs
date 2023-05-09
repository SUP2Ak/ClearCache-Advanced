using ClearCacheAdvanced.Interface;
using System.Windows.Forms;
namespace ClearCacheAdvanced
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainMenuStrip menuStrip = new MainMenuStrip();
            Controls.Add(menuStrip);
        }
    }
}
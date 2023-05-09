using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClearCacheAdvanced.Interface
{
    class MainMenuStrip : MenuStrip
    {
        public MainMenuStrip()
        {
            Name = "MainMenuStrip";
            Dock = DockStyle.Top;

            // Add Component
            MainDropDown();
        }

        public void MainDropDown()
        {
            // Main
            var mainDropDownMenu = new ToolStripMenuItem("Files");

            // Main.Items
            var quitMenu = new ToolStripMenuItem("Quit", null, null, Keys.Alt | Keys.F4); // Quittez l'application ( Alt + F4 )

            mainDropDownMenu.DropDownItems.Add(quitMenu);
            //mainDropDownMenu.DropDownItems.AddRange(new ToolStripMenuItem[] { quitMenu }); // Pour ajoutez plusieurs éviter des répéter les Add

            Items.Add(mainDropDownMenu);
        }
    }
}

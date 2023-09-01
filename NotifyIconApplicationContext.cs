using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidCreator
{
    class NotifyIconApplicationContext : ApplicationContext
    {
        public NotifyIconApplicationContext()
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem createGuidMenuItem = contextMenu.MenuItems.Add("Create Guid");
            createGuidMenuItem.Click += CreateGuidMenuItem_Click;
            MenuItem exitMenuItem = contextMenu.MenuItems.Add("Exit");
            exitMenuItem.Click += ExitMenuItem_Click;
            NotifyIcon icon = new NotifyIcon
            {
                Text = "Guid",
                Icon = Properties.Resources.Guid,
                ContextMenu = contextMenu
            };
            icon.Visible = true;
        }

        private void CreateGuidMenuItem_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            Clipboard.SetText(guid.ToString());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

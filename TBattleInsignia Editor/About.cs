using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBattleInsignia_Editor
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void MyGitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link.");
            }
        }

        private void VisitLink()
        {
            MyGitHubLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/SlayerHasher");
        }
    }
}

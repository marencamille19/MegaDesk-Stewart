using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stewart
{
    public partial class AddQuote : Form
    {
// a comment from Harmony
        MainMenu mainMenu;
        public AddQuote(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mainMenu.Show();
            this.Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenu.Show();
        }
    }
}

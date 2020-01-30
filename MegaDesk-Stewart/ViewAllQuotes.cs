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
    public partial class ViewAllQuotes : Form
    {
        MainMenu mainMenu;
        public ViewAllQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenu.Show();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            this.mainMenu.Show();
            this.Close();
        }
    }
}
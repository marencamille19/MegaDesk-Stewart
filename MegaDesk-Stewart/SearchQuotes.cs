using Newtonsoft;
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
    public partial class SearchQuotes : Form
    {
        MainMenu mainMenu;
        public SearchQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;

        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenu.Show();
        }

        //Method for when a surface material is selected in the combo box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void close_ButtonClicked(object sender, EventArgs e)
        {
            this.mainMenu.Show();
            this.Close();
        }
    }
}
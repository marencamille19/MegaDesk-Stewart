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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnAddNewForm_Click(object sender, EventArgs e)
        {
            var addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Show();
            Hide();
        }
    }
}

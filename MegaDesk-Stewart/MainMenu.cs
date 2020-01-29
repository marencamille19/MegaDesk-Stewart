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
            var addNewQuoteForm = new AddQuote(this);
            addNewQuoteForm.Show();
            Hide();
        }

        private void BtnViewQuotes_Click(object sender, EventArgs e)
        {
            var viewQuotesForm = new ViewAllQuotes(this);
            viewQuotesForm.Show();
            Hide();
        }

        private void BtnSearchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuotesForm = new SearchQuotes(this);
            searchQuotesForm.Show();
            Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

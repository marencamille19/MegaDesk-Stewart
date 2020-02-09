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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote display)
        {
            InitializeComponent();

            customerName.Text = display.CustomerName;
            displayWidth.Text = display.Desk.Width.ToString();
            displayDepth.Text = display.Desk.Depth.ToString();
            displayDrawers.Text = display.Desk.NumDrawers.ToString();
            displayMaterials.Text = display.Desk.Material.ToString();
            displayRushOrder.Text = display.RushDays.ToString();
            displayTotal.Text = display.FinalPrice.ToString("C");

        }

        private void exitDisplayQuote_Click(object sender, EventArgs e)
        {
            var addQuoteView = (AddQuote)Tag;
            addQuoteView.Close();
            Close();
        }
    }
}

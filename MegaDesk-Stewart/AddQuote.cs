using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            List<Desk.DesktopMaterial> materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk.DesktopMaterial>()
                .ToList();

            desktopMaterial.DataSource = materials;
            desktopMaterial.SelectedIndex = -1;

            List<DeskQuote.RushOrder> delivery = Enum.GetValues(typeof(DeskQuote.RushOrder))
                .Cast<DeskQuote.RushOrder>()
                .ToList();

            shipping.DataSource = delivery;
            shipping.SelectedIndex = -1;
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

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            Desk userDesk = new Desk();
            userDesk.Width = (int)(width.Value);
            userDesk.Depth = (int)(depth.Value);
            userDesk.NumDrawers = (int)(numDrawers.Value);
            userDesk.Material = (Desk.DesktopMaterial)desktopMaterial.SelectedIndex;
            DeskQuote userQuote = new DeskQuote();
            userQuote.CustomerName = customerName.Text;
            userQuote.Shipping = (DeskQuote.RushOrder)shipping.SelectedValue;
            userQuote.Desk = userDesk;
            userQuote.GetRushOrder();
            userQuote.Total();
            quotePrice.Text = "Quote: $" + userQuote.FinalPrice.ToString();
            var total = userQuote.FinalPrice;

            //Write code to add a quote to the quotes.json file
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                var list = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                list.Add(new DeskQuote());
                var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            //string quotes = reader.ReadToEnd();
            //List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
            //deskQuotes.Add(new DeskQuote());
            //var convertedJson = JsonConvert.SerializeObject(deskQuotes, Formatting.Indented);
            }
        }
    }
}

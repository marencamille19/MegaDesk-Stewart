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
    public partial class ViewAllQuotes : Form
    {
        MainMenu mainMenu;
        public ViewAllQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;

            loadGrid();
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

        public void loadGrid()
        {
            using (StreamReader reader = new StreamReader(@"quotes.json"))
            {
                string json = reader.ReadToEnd();
                List<DeskQuote> quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

                dataGridView1.DataSource = quotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.NumDrawers,
                    SurfaceMaterial = d.Desk.Material,
                    DeliveryType = d.Shipping,
                    QuoteAmount = d.FinalPrice.ToString("C")
                })
                    .ToList();
            }
        }
    }
}
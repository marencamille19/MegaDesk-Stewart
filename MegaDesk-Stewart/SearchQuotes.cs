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
    public partial class SearchQuotes : Form
    {
        MainMenu mainMenu;
        public SearchQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            List<Desk.DesktopMaterial> materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk.DesktopMaterial>()
                .ToList();

            comboBox1.DataSource = materials;
            comboBox1.SelectedIndex = -1;
            loadGrid();

        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainMenu.Show();
        }

        //Method for when a surface material is selected in the combo box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if(combo.SelectedIndex < 0)
            {
                loadGrid();
            }
            else
            {
                loadGrid((Desk.DesktopMaterial)combo.SelectedValue);
            }
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                searchDataGridView.DataSource = deskQuotes.Select(d => new 
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.NumDrawers,
                    SurfaceMaterial = d.Desk.Material,
                    DeliveryType = d.RushDays,
                    QuoteAmount = d.FinalPrice.ToString("c")
                }).ToList();
            }
        }

        private void loadGrid(Desk.DesktopMaterial desktopMaterial)
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                searchDataGridView.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.NumDrawers,
                    SurfaceMaterial = d.Desk.Material,
                    DeliveryType = d.RushDays,
                    FinalPrice = d.FinalPrice
                })
                .Where(q => q.SurfaceMaterial == desktopMaterial)
                .ToList();
            }
        }

        private void close_ButtonClicked(object sender, EventArgs e)
        {
            this.mainMenu.Show();
            this.Close();
        }
    }
}
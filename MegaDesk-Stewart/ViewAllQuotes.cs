using Newtonsoft.Json;
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

        public class fillDataGridView
        {
            public string CustomerName { get; set; }
            public DateTime QuoteDate { get; set; }
            public Desk.DesktopMaterial Material { get; set; }
            public int RushDays { get; set; }
            public int Total { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Need to figure out how to make input = the quotes.json file I created
            //var input = ;
            //var result = JsonConvert.DeserializeObject<List<fillDataGridView>>(input);
            //dataGridView1.DataSource = result;
        }
    }
}
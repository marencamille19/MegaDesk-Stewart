using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stewart
{
    public class DeskQuoteLDesk
    {
        public DateTime QuoteDate;
        public string CustomerName { get; set; }
        public Desk Desk = new Desk();
        public int Total;
        public int RushDays;

        public decimal GetQuotePrice(string customerName, DateTime quoteDate, int width, int depth, int drawers, Desk.DesktopMaterial material, int rushOrder)
        {
            //TODO: calculate the quote price
            CustomerName = customerName;
            QuoteDate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumDrawers = drawers;
            RushDays = rushOrder;
            
            int Area = Desk.Width * Desk.Depth;
            return Total;
        }
    }
}

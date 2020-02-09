using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stewart
{
    public class DeskQuote
    {
        public DeskQuote()
        {
            this.RushDays = GetRushOrder();
        }
        public Desk Desk = new Desk();

        static decimal total_price = 200M;
        const decimal DRAWER_PRICE = 50M;

        const decimal OAK = 200M;
        const decimal LAMINATE = 100M;
        const decimal PINE = 50M;
        const decimal ROSEWOOD = 300M;
        const decimal VENEER = 125M;

        public RushOrder Shipping { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public int[,] RushDays { get; set; }
        public decimal FinalPrice { get; set; }

        public int[,] GetRushOrder()
        {
            string[] rushOrder = File.ReadAllLines("rushOrderPrices.txt");

            int[,] rushDays = new int[3, 3];

            int count = 0;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    rushDays[col, row] = int.Parse(rushOrder[count]);
                    count++;
                }
            }
            return rushDays;
        }

        public enum RushOrder
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Day
        }

        public decimal Total()
        {
            total_price = 200M;

            int area = Desk.Width * Desk.Depth;

            switch (Desk.Material)
            {
                case Desk.DesktopMaterial.Oak:
                    total_price += OAK;
                    break;
                case Desk.DesktopMaterial.Laminate:
                    total_price += LAMINATE;
                    break;
                case Desk.DesktopMaterial.Pine:
                    total_price += PINE;
                    break;
                case Desk.DesktopMaterial.Rosewood:
                    total_price += ROSEWOOD;
                    break;
                case Desk.DesktopMaterial.Veneer:
                    total_price += VENEER;
                    break;
            }

            switch (Shipping)
            {
                case RushOrder.Rush3Days:
                    if (area < 1000)
                    {
                        total_price += this.RushDays[0, 0];
                    }
                    else if (area >= 1000 && area < 2000)
                    {
                        total_price += this.RushDays[1, 0];
                    }
                    else
                        total_price += this.RushDays[2, 0];
                    break;
                case RushOrder.Rush5Days:
                    if (area < 1000)
                    {
                        total_price += this.RushDays[0, 1];
                    }
                    else if (area >= 1000 && area < 2000)
                    {
                        total_price += this.RushDays[1, 1];
                    }
                    else
                        total_price += this.RushDays[2, 1];
                    break;
                case RushOrder.Rush7Days:
                    if (area < 1000)
                    {
                        total_price += this.RushDays[0, 2];
                    }
                    else if (area >= 1000 && area < 2000)
                    {
                        total_price += this.RushDays[1, 2];
                    }
                    else
                        total_price += this.RushDays[2, 2];
                    break;
            }

            if (area > 1000)
            {
                int fee = ((this.Desk.Width * this.Desk.Depth) - 1000) * 1;
                total_price += fee;
            }

            decimal total = total_price + (this.Desk.NumDrawers * DRAWER_PRICE);
            this.FinalPrice = total;
            return total;
        }

        public static implicit operator DeskQuote(DisplayQuote v)
        {
            throw new NotImplementedException();
        }
    }
}
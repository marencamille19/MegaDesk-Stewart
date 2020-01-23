using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stewart
{
    public class Desk
    {
        public enum DesktopMaterial
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }

        //prop + tab + tab creates a property like below
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public string Shipping { get; set; }
        public DesktopMaterial Material { get; set; }
    }
}

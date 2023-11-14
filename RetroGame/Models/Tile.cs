using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroGame.Models
{
    public class Tile
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int Action { get; set; }
    }
}

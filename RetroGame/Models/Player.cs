using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroGame.Models
{
    public class Player
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int Position { get; set; } = 1;
        public bool Finished { get; set; }
    }
}

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DickGame
{
    class Character
    {
       public Vector2 pos { get; set; } 
       public int hp { get; set; }

        public Character(Vector2 pos, int hp)
        {
            this.pos = pos;
            this.hp = hp;
        }
    }
}

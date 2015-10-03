﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermiInTheAir.GameObjects
{
    public class DestroyObject : GameObject
    {
        const int DestroyObjectHeight = 1; //Fix me: set back to 2;
        const int DestroyObjectWidth = 1; //Fix me: set back to 2;
        const char DestroyObjectSymbol = '#';
        private Random rnd = new Random();

        public DestroyObject(Point pos)
            : base(DestroyObjectHeight, DestroyObjectWidth, pos, DestroyObjectSymbol)
        {

        }
       
    }

}


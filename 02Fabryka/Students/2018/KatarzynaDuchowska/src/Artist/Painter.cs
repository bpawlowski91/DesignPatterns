﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Artist
{
    public class Painter : IArtist
    {
        public void DoArt()
        {
            Console.WriteLine("I am a painter");
        }
    }
}

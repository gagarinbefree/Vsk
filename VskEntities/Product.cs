﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities
{
    public class Product : Unit
    {
        public override int CalcPrice()
        {
            return Price;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
  class PruitYFilter : MatrixFilter
  {
    public PruitYFilter()
    {
      kernel = new float[,] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
    }
  }
}

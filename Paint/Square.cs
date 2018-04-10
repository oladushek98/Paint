﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Square : Figure
    {
        public override void Draw(Graphics graphics, Pen pen, Point StartPoint, Point FinishPoint)
        {
            int width = FinishPoint.X - StartPoint.X;
            graphics.DrawRectangle(pen, StartPoint.X, StartPoint.Y, width, width);
        }
    }
}
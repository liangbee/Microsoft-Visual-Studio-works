using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Lab4
{
    public class Block // otherwise form1 won't be able to access it
    {
        public int Column;
        public int Row;
        public Point Coordinate;
        public bool Queen = false; // 0 not queen, 1 queen
        public bool Safe = true; // 0 a new queen can be placed here, 1 no
        public Brush Bbrush;
        public Block(int col, int row, Point cord)
        {
            Column = col;
            Row = row;
            Coordinate = cord;
            if (Safe != true) Bbrush = Brushes.Red;
            else if (Column % 2 == Row % 2) Bbrush = Brushes.White;
            else if (Column % 2 != Row % 2) Bbrush = Brushes.Black;

        }

    }
}
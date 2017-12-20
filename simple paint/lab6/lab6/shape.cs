using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab6
{
    public class shape
    {
        public int width; // "thickness" of the shape.
        public int Type; // type = 0 is line, 1 is rectangle and 2 is eclipse.
        public Point point1, point2; // stores the 2 mouse clicks.
        public Color brush = Color.Black; // color by default is black
        public Color fillbrush; // might have fill; might not.
        public bool fill; // true: has fill, false: no fill.
        public shape(Point m1, Point m2, bool f, Color lineb, Color fillb, int w)
        {
            width = w;
            point1 = m1;
            point2 = m2;
            fill = f;
            brush = lineb;
        }
        public virtual void Drawshape(Graphics g)
        {
            return; // do nothing since actions are taken in polymorphism
        }
    }
    class Line : shape
    {
        public Point point1;
        public Point point2;
        public Pen Linepen;
        // maybe I can do all of these without creating new public variables, but for the sake of less bugs i did it this way.
        public Line(Point m1, Point m2, bool f, Color lineb, Color fillb, int w) : base(m1, m2, f, lineb, fillb, w)
        {
            point1 = m1;
            point2 = m2;
            Linepen = new Pen(lineb, w);
        }
        public override void Drawshape(Graphics g)
        {
            g.DrawLine(Linepen, point1, point2);
        }
    }
    class shapeRectangle : shape
    {
        public Point point1;
        public Point point2;
        public Pen Recpen;
        public Brush Fillrecpen;
        public int x;
        public int y;
        public int wid;
        public bool filltrue;
        public int hei; // the width and height of the rectangle, not to be confused with the pen-width of the shape.
        // maybe I can do all of these without creating new public variables, but for the sake of less bugs i did it this way.
        public shapeRectangle(Point m1, Point m2, bool f, Color lineb, Color fillb, int w) : base(m1, m2, f, lineb, fillb, w)
        {
            point1 = m1;
            point2 = m2;
            Recpen = new Pen(lineb, w);
            if (f == true)
            {
                filltrue = true;
                Fillrecpen = new SolidBrush(fillb);
            }
        }
        public override void Drawshape(Graphics g)
        {
            wid = Math.Abs(point1.X - point2.X);
            hei = Math.Abs(point1.Y - point2.Y);
            if (point1.X <= point2.X)
            {
                x = point1.X;
            }
            else
            {
                x = point2.X;
            }
            if (point1.Y <= point2.Y)
            {
                y = point1.Y;
            }
            else
            {
                y = point2.Y;
            }
            // there really isn't a better way to draw a rectangle than this so these messy variables have to be created
            g.DrawRectangle(Recpen, x, y, wid, hei);
            if (filltrue)
            {
                g.FillRectangle(Fillrecpen, new Rectangle(x, y, wid, hei));
            }
        }

    }
    class shapeEllipse : shape
    {
        public Point point1;
        public Point point2;
        public Pen Ellpen;
        public Brush Fillellpen;
        public int x;
        public int y;
        public int wid;
        public bool filltrue;
        public int hei; // the width and height of the eclipse, not to be confused with the pen-width of the shape.
        // maybe I can do all of these without creating new public variables, but for the sake of less bugs i did it this way.
        public shapeEllipse(Point m1, Point m2, bool f, Color lineb, Color fillb, int w) : base(m1, m2, f, lineb, fillb, w)
        {
            point1 = m1;
            point2 = m2;
            Ellpen = new Pen(lineb, w);
            if (f == true)
            {
                filltrue = true;
                Fillellpen = new SolidBrush(fillb);
            }
        }
        public override void Drawshape(Graphics g)
        {
            wid = Math.Abs(point1.X - point2.X);
            hei = Math.Abs(point1.Y - point2.Y);
            if (point1.X <= point2.X)
            {
                x = point1.X;
            }
            else
            {
                x = point2.X;
            }
            if (point1.Y <= point2.Y)
            {
                y = point1.Y;
            }
            else
            {
                y = point2.Y;
            }
            // there really isn't a better way to draw an ellipse than this so these messy variables have to be created
            // Also I might have spelled ellipse as eclipse somewhere in the code sorry about that
            g.DrawEllipse(Ellpen, x, y, wid, hei);
            if (filltrue)
            {
                g.FillEllipse(Fillellpen, new Rectangle(x, y, wid, hei));
            }
        }
    }
}


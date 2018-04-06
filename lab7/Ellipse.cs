using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeVisualization
{
    public class Ellipse : IShape
    {
        PointF focus1;
        PointF focus2;
        double semiMajorAxis;
        double semiMinorAxis;
        
        public Ellipse(PointF focus1,PointF focus2, double semiMajorAxis)
        {
            this.focus1 = focus1;
            this.focus2 = focus2;
            this.semiMajorAxis = semiMajorAxis;
            double c = getLen(focus1, focus2)/2;
            this.semiMinorAxis = 2 * (float)Math.Round(Math.Sqrt((this.semiMajorAxis / 2 * this.semiMajorAxis / 2) - (c * c)), 3);
        }

        private double getLen(PointF a, PointF b)
        {
            double x, y;
            x = Math.Abs(b.X - a.X);
            y = Math.Abs(b.Y - a.Y);
            return (float)Math.Sqrt(x * x + y * y);
        }

        public void Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            graph.DrawEllipse(Pens.Black, (float)(bmp.Width / 2 - this.semiMajorAxis),
                                          (float)(bmp.Height / 2 - this.semiMinorAxis),
                                          (float)(this.semiMajorAxis), (float)(this.semiMinorAxis));
        }

        public BoundingBox GetBoundingBox()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeVisualization
{
    public class Circle : IShape
    {
        private PointF center;
        private double radius;
        public Circle(PointF center,double radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public void Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            graph.DrawEllipse(Pens.Black, (float)(bmp.Width / 2 + this.center.X - this.radius),
                                          (float)(bmp.Height / 2 + this.center.Y - this.radius),
                                          (float)(this.radius * 2), (float)(this.radius * 2));
            
        }

        public BoundingBox GetBoundingBox()
        {
            throw new NotImplementedException();
        }
    }
}

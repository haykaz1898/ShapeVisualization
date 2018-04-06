using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeVisualization
{
    public class Polygon : IShape
    {
        int size;
        PointF[] points;
        public Polygon(int size,PointF[] points)
        {
            this.size = size;
            this.points = points;
        }
        public void Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Normalize(bmp);
            graph.DrawPolygon(Pens.Black, points);
        }
        private void Normalize(Bitmap bmp)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = points[i].X + bmp.Width / 2;
                points[i].Y = points[i].Y + bmp.Height / 2;
            }
        }
        public BoundingBox GetBoundingBox()
        {
            throw new NotImplementedException();
        }
    }
}

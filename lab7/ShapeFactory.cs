using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ShapeVisualization
{
    public class ShapeFactory 
    {
        public static IShape CreateShape(CreateContext context)
        {
            if(context.ShapeType == ShapeType.Circle)
            {
                if (context.Values.Count != 3)
                {
                    throw new Exception();
                }
                return new Circle(new PointF(context.Values[0], context.Values[1]), context.Values[2]);
            }
            else if (context.ShapeType == ShapeType.Ellipse)
            {
                if (context.Values.Count != 5)
                {
                    throw new Exception();
                }
                return new Ellipse(new PointF(context.Values[0],context.Values[1]),new PointF(context.Values[2],context.Values[3]),context.Values[4]);
            }
            else if (context.ShapeType == ShapeType.Polygon)
            {
                if (context.Values.Count-1 != context.Values[0]*2)
                {
                    throw new Exception();
                }
                PointF[] pnts = new PointF[(int)context.Values[0]];
                for (int i = 1; i < context.Values.Count; i+=2)
                {
                    var tmp = new PointF(context.Values[i], context.Values[i + 1]);
                    pnts[i / 2] = tmp;                    
                }
                return new  Polygon((int)context.Values[0],pnts);
            }
            return null;
        }
    }
}

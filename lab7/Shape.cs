using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeVisualization
{
    public interface IShape : IDrawable
    {
        BoundingBox GetBoundingBox();      
    }
}

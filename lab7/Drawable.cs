using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ShapeVisualization
{
    public interface IDrawable
    {
        void Draw(Bitmap bmp);
    }
}

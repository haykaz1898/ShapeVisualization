using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeVisualization
{
    public class CreateContext
    {
        public ShapeType ShapeType { get; set; }
        public List<float> Values { get; set; }
        public CreateContext(ShapeType shapeType,List<float> values)
        {
            ShapeType = shapeType;
            Values = values;
        }
    }
}

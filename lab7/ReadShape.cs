using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ShapeVisualization
{
    class ReadShape
    {
        StreamReader reader = null;
        public List<CreateContext> shapeRead(string path)
        {
            List<CreateContext> res = new List<CreateContext>();
            reader = new StreamReader(path);
            List<float> values = new List<float>();
            ShapeType type = ShapeType.Circle;
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                s = s.Trim().Replace(" ", string.Empty);
                if (s[0] == 'C' || s[0] == 'c')
                {
                    type = ShapeType.Circle;
                }
                else if (s[0] == 'E' || s[0] == 'e')
                {
                    type = ShapeType.Ellipse;
                }
                else if (s[0] == 'P' || s[0] == 'p')
                {
                    type = ShapeType.Polygon;
                }
                else
                {
                    new Exception("Not supported shape");
                }
                string tmpVal = "";
                float tmpValF = 0;
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] != ',' )
                    {
                        tmpVal += s[i];
                    }
                    else if (s[i] == ',')
                    {
                        float.TryParse(tmpVal, out tmpValF);
                        values.Add(tmpValF);
                        tmpValF = 0;
                        tmpVal = "";
                    }
                }
                if (tmpVal != "")
                {
                    float.TryParse(tmpVal, out tmpValF);
                    values.Add(tmpValF);
                    tmpValF = 0;
                    tmpVal = "";
                }
                List<float> newVal = new List<float>(values);
                CreateContext cc = new CreateContext(type, newVal);
                res.Add(cc);
                values.Clear();
            }
            return res;
        }

    }
}

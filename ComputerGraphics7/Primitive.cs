using System.Collections.Generic;
using System.Drawing;

namespace ComputerGraphics7
{
    interface Primitive
    {
        List<XYZPoint> Points { get; set; }

        List<Verge> Verges { get; set; }

        void Draw(Graphics g, Transform projection, int width, int height);

        void Apply(Transform t);

        string ToString();
    }
}

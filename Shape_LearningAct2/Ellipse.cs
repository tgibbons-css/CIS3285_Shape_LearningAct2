using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_LearningAct2
{
    public class Ellipse : Shape
    {
        
    public override void calculateArea()
    {
        area = Math.PI * (height / 2) * (width / 2);
    }
}
}

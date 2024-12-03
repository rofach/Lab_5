using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Circle : Figure
    {
        private int radius;
        public Circle(int centerX, int centerY, int size)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = size;
            status = true;
        }
        public override void DrawBlack(Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Black, GetCurrPoints());

        }

        public override void HideDrawingBackGround(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), GetCurrPoints());
        }

        private Rectangle GetCurrPoints()
        {
           return new Rectangle(centerX - radius, centerY - radius, radius*2, radius*2);
        }

        
    }
}

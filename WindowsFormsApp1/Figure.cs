using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Figure
    {
        protected int centerX;
        protected int centerY;
        protected static bool status = false;
        protected static bool rightDirection = true;
        public abstract void DrawBlack(Graphics graphics);
        public abstract void HideDrawingBackGround(Graphics graphics);

        public void MoveRight(Graphics graphics)
        {
            for (int i = 0; i < 100; i++)
            {
                DrawBlack(graphics);
                System.Threading.Thread.Sleep(50);
                HideDrawingBackGround(graphics);
                centerX++;
            }
            status = false;
        }

        public static bool isCreated()
        {
            return status;
        }
    }
}

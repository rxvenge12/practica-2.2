using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2._2
{
    public class oke
    {
        public static bool IsInside(Point point, Rectangle rectangle)
        {
            return point.X >= rectangle.BottomLeft.X && point.X <= rectangle.TopRight.X &&
                   point.Y >= rectangle.BottomLeft.Y && point.Y <= rectangle.TopRight.Y;
        }

        public static string CheckPoint(Point point, params Rectangle[] rectangles)
        {
            List<string> messages = new List<string>();

            foreach (var rectangle in rectangles)
            {
                if (IsInside(point, rectangle))
                {
                    if (point.X == rectangle.BottomLeft.X || point.X == rectangle.TopRight.X ||
                        point.Y == rectangle.BottomLeft.Y || point.Y == rectangle.TopRight.Y)
                    {
                        messages.Add($"Точка принадлежит границе прямоугольника Q{Array.IndexOf(rectangles, rectangle) + 1}");
                    }
                    else
                    {
                        messages.Add($"Точка принадлежит прямоугольнику Q{Array.IndexOf(rectangles, rectangle) + 1}");
                    }
                }
            }

            if (messages.Count == 0)
            {
                return "Точка не принадлежит ни одному из прямоугольников.";
            }
            else if (messages.Count == 1)
            {
                return messages[0];
            }
            else
            {
                return string.Join(" ", messages);
            }
        }
    }

}

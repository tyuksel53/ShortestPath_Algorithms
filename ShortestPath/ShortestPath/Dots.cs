using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class Dots
    {
        public int DotNum;
        public int DotChar;
        public int DotX;
        public int DotY;
        public Color DotColor;
        public int[][] TriangleCoordinatesBegin;
        public int[][] TriangleCoordinatesEnd;

        public Dots(int dotnum,int dotChar,int dotX,int dotY)
        {
            DotNum = dotnum;
            DotChar = dotChar;
            DotX = dotX;
            DotY = dotY;
            SetColor();
            SetTriangleCoordinate();
        }

        private void SetColor()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            int c = rnd.Next(0, 255);
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(a, b, c);
            DotColor  = myRgbColor;
        }
        private void SetTriangleCoordinate()
        {
            TriangleCoordinatesBegin = new int[12][];
            TriangleCoordinatesEnd = new int[12][];
            for (int i=0;i<12;i++)
            {
                TriangleCoordinatesBegin[i] = new int[2];
                TriangleCoordinatesEnd[i] = new int[2];
            }

            int x = DotX + 4;
            int y = DotY + 4;
            TriangleCoordinatesBegin[0][0] = x - 18;
            TriangleCoordinatesBegin[0][1] = y - 21;

            TriangleCoordinatesEnd[0][0] = x - 8;
            TriangleCoordinatesEnd[0][1] = y - 31;

            TriangleCoordinatesBegin[1][0] = x - 8;
            TriangleCoordinatesBegin[1][1] = y - 31;

            TriangleCoordinatesEnd[1][0] = x + 2;
            TriangleCoordinatesEnd[1][1] = y - 21;

            TriangleCoordinatesBegin[2][0] = x - 18;
            TriangleCoordinatesBegin[2][1] = y - 21;

            TriangleCoordinatesEnd[2][0] = x + 2;
            TriangleCoordinatesEnd[2][1] = y - 21;
            // end of the first triangle

            TriangleCoordinatesBegin[3][0] = x - 18;
            TriangleCoordinatesBegin[3][1] = y + 6;

            TriangleCoordinatesEnd[3][0] = x + 5 - 13;
            TriangleCoordinatesEnd[3][1] = y + 16;

            TriangleCoordinatesBegin[4][0] = x + 5 - 13;
            TriangleCoordinatesBegin[4][1] = y + 16;

            TriangleCoordinatesEnd[4][0] = x + 15 - 13;
            TriangleCoordinatesEnd[4][1] = y + 6;

            TriangleCoordinatesBegin[5][0] = x - 18;
            TriangleCoordinatesBegin[5][1] = y + 6;

            TriangleCoordinatesEnd[5][0] = x + 15 - 13;
            TriangleCoordinatesEnd[5][1] = y + 6;
            // end of the second tringle

            TriangleCoordinatesBegin[6][0] = x - 27 - 5;
            TriangleCoordinatesBegin[6][1] = y - 8;

            TriangleCoordinatesEnd[6][0] = x - 22;
            TriangleCoordinatesEnd[6][1] = y - 13 - 5;

            TriangleCoordinatesBegin[7][0] = x - 27 - 5;
            TriangleCoordinatesBegin[7][1] = y - 8;

            TriangleCoordinatesEnd[7][0] = x - 22;
            TriangleCoordinatesEnd[7][1] = y - 3 + 5;

            TriangleCoordinatesBegin[8][0] = x - 22;
            TriangleCoordinatesBegin[8][1] = y - 3 + 5;

            TriangleCoordinatesEnd[8][0] = x - 22;
            TriangleCoordinatesEnd[8][1] = y - 13 - 5;
            // end of third triengle

            TriangleCoordinatesBegin[9][0] = x + 11 + 5;
            TriangleCoordinatesBegin[9][1] =  y - 8;

            TriangleCoordinatesEnd[9][0] = x + 6;
            TriangleCoordinatesEnd[9][1] = y - 13 - 5;

            TriangleCoordinatesBegin[10][0] = x + 11 + 5;
            TriangleCoordinatesBegin[10][1] = y - 8;

            TriangleCoordinatesEnd[10][0] = x + 6;
            TriangleCoordinatesEnd[10][1] = y - 3 + 5;

            TriangleCoordinatesBegin[11][0] = x + 6;
            TriangleCoordinatesBegin[11][1] = y - 3 + 5;

            TriangleCoordinatesEnd[11][0] = x + 6;
            TriangleCoordinatesEnd[11][1] = y - 13 - 5;
            // end of fourth triengle

        }
        /*private void DrawTriangle(int x, int y, Color DotColor,Graphics g)
        {
            Pen drawingPen = new Pen(DotColor, 1);
            x = x + 4;
            y = y + 4;
            g.DrawLine(drawingPen, new Point(x - 18, y - 21), new Point(x - 8, y - 31));
            g.DrawLine(drawingPen, new Point(x - 8, y - 31), new Point(x + 2, y - 21));
            g.DrawLine(drawingPen, new Point(x - 18, y - 21), new Point(x + 2, y - 21));

            g.DrawLine(drawingPen, new Point(x - 18, y + 6), new Point(x + 5 - 13, y + 16));
            g.DrawLine(drawingPen, new Point(x + 5 - 13, y + 16), new Point(x + 15 - 13, y + 6));
            g.DrawLine(drawingPen, new Point(x - 18, y + 6), new Point(x + 15 - 13, y + 6));

            g.DrawLine(drawingPen, new Point(x - 27 - 5, y - 8), new Point(x - 22, y - 13 - 5));
            g.DrawLine(drawingPen, new Point(x - 27 - 5, y - 8), new Point(x - 22, y - 3 + 5));
            g.DrawLine(drawingPen, new Point(x - 22, y - 3 + 5), new Point(x - 22, y - 13 - 5));

            g.DrawLine(drawingPen, new Point(x + 11 + 5, y - 8), new Point(x + 6, y - 13 - 5));
            g.DrawLine(drawingPen, new Point(x + 11 + 5, y - 8), new Point(x + 6, y - 3 + 5));
            g.DrawLine(drawingPen, new Point(x + 6, y - 3 + 5), new Point(x + 6, y - 13 - 5));
        }*/
    }

}

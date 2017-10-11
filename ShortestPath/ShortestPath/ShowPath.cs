using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPath
{
    public partial class ShowPath : Form
    {
        public static int AreaHeight = 0;
        public static int AreaWidth = 0;
        public static int DotNum = 1;
        public static int DotChar = 65;
        public static int DotsCount = 0;
        private static bool  mouseIsDown;
        private static int tempX;
        private static int tempY;
        private static ConnectionDot connectDot = new ConnectionDot();
        private static string Mode = "None";
        public static List<Dots> dots = new List<Dots>();

        public ShowPath(string type)
        {
            InitializeComponent();
            AlgorithmName.Text = type;
            DotList.Text = "";
            CurrentMode.Text = Mode;
        }
        private void DrawArea()
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, 300, 25, AreaWidth, AreaHeight);
        }
        private void DrawEllipse(int x,int y,Color DotColor,int dotChar,Color DotNameColor)
        {
            Graphics g = this.CreateGraphics();
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(DotColor);
            g.FillEllipse(myBrush, x, y, 25, 25);
            Font drawFont = new Font("Arial Bold", 8);
            SolidBrush drawBrush = new SolidBrush(DotNameColor);
            char character = (char)dotChar;
            g.DrawString(character.ToString(), drawFont, drawBrush, x+7, y+6);
        }
        private void DrawTriangle(int x, int y, Color DotColor,int dotNumber)
        {
            Graphics g = this.CreateGraphics();
            Pen drawingPen = new Pen(DotColor, 1);

            for (int i=0; i<12;i++)
            {
                int beginX =16 + dots.ElementAt(dotNumber).TriangleCoordinatesBegin[i][0];
                int beginY = 16 + dots.ElementAt(dotNumber).TriangleCoordinatesBegin[i][1];

                int endX = 16 +dots.ElementAt(dotNumber).TriangleCoordinatesEnd[i][0];
                int endY =16+ dots.ElementAt(dotNumber).TriangleCoordinatesEnd[i][1];

                g.DrawLine(drawingPen, new Point(beginX, beginY), new Point(endX, endY));
            }
        }
        private void ShowPath_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            AreaHeight = control.Height - 70;
            AreaWidth  = control.Width - 323;
            DrawArea();
        }
        private void ShowPath_MouseClick(object sender, MouseEventArgs e)
        {
            var x = e.Location.X;
            var y = e.Location.Y;
            if( 305 < x && x < (AreaWidth + 288) )
            {
                if(35 < y && y <  AreaHeight + 13 )
                {
                    if(Mode.Equals("Add Dot Mode"))
                    {
                        dots.Add(new Dots(DotNum,DotChar,x,y));
                        DrawEllipse(x, y, dots.ElementAt(DotsCount).DotColor, DotChar, Color.Black);
                        DotsCount++;
                        char character = (char)DotChar;
                        DotList.Text = DotList.Text + DotNum + ". | Name: " + character.ToString() + " | X: " + x + " | Y: " + y + Environment.NewLine;
                        DotNum++;
                        DotChar++;
                    }
                    if(Mode.Equals("Connect Dot Mode"))
                    {
                        if(connectDot.ConnectDot1 == false)
                        {
                            connectDot.ConnectDot1 = true;
                            connectDot.ConnectDot1X = x;
                            connectDot.ConnectDot1Y = y;

                            connectDot.RemoveDot1X = x;
                            connectDot.RemoveDot1Y = y;

                            tempX = x;
                            tempY = y;
                        }
                        else
                        {
                            connectDot.ConnectDot2 = true;
                        }
                    }
                }
            }
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
        private void UndoButton_Click(object sender, EventArgs e)
        {
            DotNum = DotNum - 1;
            DotChar = DotChar -1;
            DotsCount = DotsCount - 1;
            var kundi = DotList.Lines.ElementAt(DotNum-1);
            DotList.Text = DotList.Text.Replace(kundi, "");
            DotList.Text = DotList.Text.Replace("\r\n\r\n", "\r\n");
            if(DotList.Text.Equals("\r\n"))
            {
                DotList.Text = "";
            }
            DrawEllipse(dots.ElementAt(DotNum-1).DotX, dots.ElementAt(DotNum-1).DotY, this.BackColor, dots.ElementAt(DotNum-1).DotChar, this.BackColor);
            dots.RemoveAt(DotNum - 1);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            DotNum = 1;
            DotChar = 65;
            DotList.Text = "  ";
            DotsCount = 0;
            for (int i = 0; i< dots.Count; i++)
            {
                DrawEllipse(dots.ElementAt(i).DotX, dots.ElementAt(i).DotY, this.BackColor,dots.ElementAt(i).DotChar,this.BackColor);
            }
            dots.Clear();
            Graphics g = this.CreateGraphics();
            SolidBrush blueBrush = new SolidBrush(this.BackColor);
            Rectangle rect = new Rectangle(300+2, 25+2, AreaWidth-2, AreaHeight-2);
            g.FillRectangle(blueBrush, rect);

        }
        private void ShowPath_MouseMove(object sender, MouseEventArgs e)
        {
            bool control = false;
            var relativePoint = this.PointToClient(Cursor.Position);
            var x = relativePoint.X -8;
            var y = relativePoint.Y -8;
            if (305 < x && x < (AreaWidth + 288))
            {
                if (35 < y && y < AreaHeight + 13)
                {
                    for (int i = 0; i < dots.Count; i++)
                    {
                        var uzunlukX = Math.Abs(x - dots.ElementAt(i).DotX);
                        uzunlukX = uzunlukX * uzunlukX;
                        var uzunlukY = Math.Abs(y - dots.ElementAt(i).DotY);
                        uzunlukY = uzunlukY * uzunlukY;
                        var toplam = Math.Sqrt(uzunlukX + uzunlukY);
                        if (toplam <= 26)
                        {
                            control = true;
                            DrawTriangle(dots.ElementAt(i).DotX + 16, dots.ElementAt(i).DotY + 16, Color.Black,i);
                        }
                    }
                    if (control == false)
                    {
                        for (int i = 0; i < dots.Count; i++)
                        {
                            DrawTriangle(dots.ElementAt(i).DotX + 16, dots.ElementAt(i).DotY + 16, this.BackColor,i);
                        }
                    }
                    if(Mode.Equals("Connect Dot Mode"))
                    {
                        if(mouseIsDown)
                        {
                            if (connectDot.ConnectDot1)
                            {
                                DrawConnectDot(connectDot.ConnectDot1X, connectDot.ConnectDot1Y, tempX,tempY,this.BackColor);
                                Point point = PointToClient(Cursor.Position);
                                DrawConnectDot(connectDot.ConnectDot1X, connectDot.ConnectDot1Y, (point.X), (point.Y), Color.Black);
                                tempX = point.X;
                                tempY = point.Y;
                            }
                        }
                       
                    }

                }
            }
        }
        private void DrawConnectDot(int BeginX, int BeginY,int EndX,int EndY,Color c)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(c);
            g.DrawLine(pen, BeginX, BeginY, EndX, EndY);
        }
        private void AddDotButton_Click(object sender, EventArgs e)
        {
            Mode = "Add Dot Mode";
            CurrentMode.Text = Mode;
            CurrentMode.ForeColor = Color.Red;
        }

        private void ConnectDotButton_Click(object sender, EventArgs e)
        {
            Mode = "Connect Dot Mode";
            CurrentMode.Text = Mode;
            CurrentMode.ForeColor = Color.Red;
        }

        private void ShowPath_MouseDown(object sender, MouseEventArgs e)
        {
            if(Mode.Equals("Connect Dot Mode"))
            {
                mouseIsDown = true;
            }
            
            //MessageBox.Show("Maouse basılı");

        }

        private void ShowPath_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
            //MessageBox.Show("Mouse ı bıraktın");
        }
    }
}

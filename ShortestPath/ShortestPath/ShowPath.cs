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
        public static List<Dots> dots = new List<Dots>();

        public ShowPath(string type)
        {
            InitializeComponent();
            AlgorithmName.Text = type;
            DotList.Text = "";
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
            g.FillEllipse(myBrush, x, y, 16, 16);
            Font drawFont = new Font("Arial Bold", 8);
            SolidBrush drawBrush = new SolidBrush(DotNameColor);
            char character = (char)dotChar;
            g.DrawString(character.ToString(), drawFont, drawBrush, x+3, y+2);
        }
        private void ShowPath_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            AreaHeight = control.Height - 70;
            AreaWidth  = control.Width - 323;
            DrawArea();
        }
        private Color FromRgbExample()
        {
            Random rnd = new Random();
            int a = rnd.Next(0,255);  // 1 <= month < 13
            int b = rnd.Next(0,255);    // 1 <= dice < 7
            int c = rnd.Next(0,255);
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(a, b, c);
            return myRgbColor;
        }
        private void ShowPath_MouseClick(object sender, MouseEventArgs e)
        {
            var x = e.Location.X;
            var y = e.Location.Y;
            if( 305 < x && x < (AreaWidth + 288) )
            {
                if(35 < y && y <  AreaHeight + 13 )
                {
                    DrawEllipse(x, y, FromRgbExample(),DotChar,Color.Black);
                    dots.Add(new Dots { DotX = x ,DotY = y, DotNum = DotNum,DotChar = DotChar});
                    char character = (char) DotChar;
                    DotList.Text = DotList.Text + DotNum + ". | Name: " + character.ToString() +" | X: " +x + " | Y: " + y+ Environment.NewLine;
                    DotNum++;
                    DotChar++;
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
            for(int i = 0; i< dots.Count; i++)
            {
                DrawEllipse(dots.ElementAt(i).DotX, dots.ElementAt(i).DotY, this.BackColor,dots.ElementAt(i).DotChar,this.BackColor);
            }
            dots.Clear();
        }
    }
}

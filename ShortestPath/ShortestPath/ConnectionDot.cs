using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class ConnectionDot
    {
        public bool ConnectDot1 = false;
        public bool ConnectDot2 = false;

        public int ConnectDot1X;
        public int ConnectDot1Y;

        public int RemoveDot1X;
        public int RemoveDot1Y;

        public int tempRemove1X;
        public int tempRemove1Y;

        public int ConnectDot2X;
        public int ConnectDot2Y;
        

        public void initializeConnectionDot1(int X,int Y)
        {
            ConnectDot1X = X;
            ConnectDot1Y = Y;
        }
        public void initializeConnectionDot2(int X, int Y)
        {
            ConnectDot2X = X;
            ConnectDot2Y = Y;
        }
        public void SetConnection1(bool set)
        {
            ConnectDot1 = set;
        }
        public void SetConnection2(bool set)
        {
            ConnectDot2 = set;
        }
    }
}

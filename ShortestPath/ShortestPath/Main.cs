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
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
        }

        private void DjikstraD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked Djikstra");
            Form yeni = new ShowPath("Djikstra's Algorithm");
            yeni.Show();
        }

        private void PrimB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked Prim");
            Form yeni = new ShowPath("Prim's Algorithm");
            yeni.Show();
        }

        private void KruskalB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked Kruskal");
            Form yeni = new ShowPath("Kruskal's Algorithm");
            yeni.Show();
        }
    }
}

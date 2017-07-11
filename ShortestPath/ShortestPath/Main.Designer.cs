namespace ShortestPath
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DjikstraD = new System.Windows.Forms.Button();
            this.PrimB = new System.Windows.Forms.Button();
            this.KruskalB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DjikstraD
            // 
            this.DjikstraD.Location = new System.Drawing.Point(79, 40);
            this.DjikstraD.Name = "DjikstraD";
            this.DjikstraD.Size = new System.Drawing.Size(75, 23);
            this.DjikstraD.TabIndex = 0;
            this.DjikstraD.Text = "Dijkstra";
            this.DjikstraD.UseVisualStyleBackColor = true;
            this.DjikstraD.Click += new System.EventHandler(this.DjikstraD_Click);
            // 
            // PrimB
            // 
            this.PrimB.Location = new System.Drawing.Point(79, 85);
            this.PrimB.Name = "PrimB";
            this.PrimB.Size = new System.Drawing.Size(75, 23);
            this.PrimB.TabIndex = 1;
            this.PrimB.Text = "Prim";
            this.PrimB.UseVisualStyleBackColor = true;
            this.PrimB.Click += new System.EventHandler(this.PrimB_Click);
            // 
            // KruskalB
            // 
            this.KruskalB.Location = new System.Drawing.Point(79, 137);
            this.KruskalB.Name = "KruskalB";
            this.KruskalB.Size = new System.Drawing.Size(75, 23);
            this.KruskalB.TabIndex = 2;
            this.KruskalB.Text = "Kruskal";
            this.KruskalB.UseVisualStyleBackColor = true;
            this.KruskalB.Click += new System.EventHandler(this.KruskalB_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(228, 228);
            this.Controls.Add(this.KruskalB);
            this.Controls.Add(this.PrimB);
            this.Controls.Add(this.DjikstraD);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DjikstraD;
        private System.Windows.Forms.Button PrimB;
        private System.Windows.Forms.Button KruskalB;
    }
}


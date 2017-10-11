namespace ShortestPath
{
    partial class ShowPath
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
            this.AlgorithmName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DotList = new System.Windows.Forms.TextBox();
            this.AddDotButton = new System.Windows.Forms.Button();
            this.ConnectDotButton = new System.Windows.Forms.Button();
            this.ModeName = new System.Windows.Forms.Label();
            this.CurrentMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlgorithmName
            // 
            this.AlgorithmName.AutoSize = true;
            this.AlgorithmName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgorithmName.Location = new System.Drawing.Point(34, 26);
            this.AlgorithmName.Name = "AlgorithmName";
            this.AlgorithmName.Size = new System.Drawing.Size(112, 15);
            this.AlgorithmName.TabIndex = 0;
            this.AlgorithmName.Text = "Algorithm Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Just click the below area to make dots and press the Calculate button";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(208, 261);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(208, 300);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(0);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 23);
            this.UndoButton.TabIndex = 4;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(208, 346);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DotList
            // 
            this.DotList.BackColor = System.Drawing.SystemColors.Menu;
            this.DotList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DotList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DotList.Location = new System.Drawing.Point(12, 61);
            this.DotList.Multiline = true;
            this.DotList.Name = "DotList";
            this.DotList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DotList.Size = new System.Drawing.Size(187, 308);
            this.DotList.TabIndex = 6;
            this.DotList.Text = "Dots";
            // 
            // AddDotButton
            // 
            this.AddDotButton.Location = new System.Drawing.Point(208, 179);
            this.AddDotButton.Name = "AddDotButton";
            this.AddDotButton.Size = new System.Drawing.Size(75, 23);
            this.AddDotButton.TabIndex = 7;
            this.AddDotButton.Text = "Add Dot";
            this.AddDotButton.UseVisualStyleBackColor = true;
            this.AddDotButton.Click += new System.EventHandler(this.AddDotButton_Click);
            // 
            // ConnectDotButton
            // 
            this.ConnectDotButton.Location = new System.Drawing.Point(208, 220);
            this.ConnectDotButton.Name = "ConnectDotButton";
            this.ConnectDotButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectDotButton.TabIndex = 8;
            this.ConnectDotButton.Text = "Connect Dot";
            this.ConnectDotButton.UseVisualStyleBackColor = true;
            this.ConnectDotButton.Click += new System.EventHandler(this.ConnectDotButton_Click);
            // 
            // ModeName
            // 
            this.ModeName.AutoSize = true;
            this.ModeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ModeName.Location = new System.Drawing.Point(186, 26);
            this.ModeName.Name = "ModeName";
            this.ModeName.Size = new System.Drawing.Size(85, 15);
            this.ModeName.TabIndex = 9;
            this.ModeName.Text = "Current Mode:";
            // 
            // CurrentMode
            // 
            this.CurrentMode.AutoSize = true;
            this.CurrentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CurrentMode.Location = new System.Drawing.Point(186, 61);
            this.CurrentMode.Name = "CurrentMode";
            this.CurrentMode.Size = new System.Drawing.Size(74, 13);
            this.CurrentMode.TabIndex = 10;
            this.CurrentMode.Text = "Mode Name";
            // 
            // ShowPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 439);
            this.Controls.Add(this.CurrentMode);
            this.Controls.Add(this.ModeName);
            this.Controls.Add(this.ConnectDotButton);
            this.Controls.Add(this.AddDotButton);
            this.Controls.Add(this.DotList);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlgorithmName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowPath";
            this.Text = "ShowPath";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowPath_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowPath_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPath_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowPath_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPath_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlgorithmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox DotList;
        private System.Windows.Forms.Button AddDotButton;
        private System.Windows.Forms.Button ConnectDotButton;
        private System.Windows.Forms.Label ModeName;
        private System.Windows.Forms.Label CurrentMode;
    }
}
namespace PDFgraph
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelNoOfGraph = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelGraphSize = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.inputPositionX = new System.Windows.Forms.TextBox();
            this.inputPositionY = new System.Windows.Forms.TextBox();
            this.inputWidth = new System.Windows.Forms.TextBox();
            this.inputHeight = new System.Windows.Forms.TextBox();
            this.inputNoOfGraph = new System.Windows.Forms.TextBox();
            this.labelAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(70, 45);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(16, 16);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(70, 75);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 16);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y";
            // 
            // labelNoOfGraph
            // 
            this.labelNoOfGraph.AutoSize = true;
            this.labelNoOfGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfGraph.Location = new System.Drawing.Point(23, 127);
            this.labelNoOfGraph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoOfGraph.Name = "labelNoOfGraph";
            this.labelNoOfGraph.Size = new System.Drawing.Size(99, 16);
            this.labelNoOfGraph.TabIndex = 5;
            this.labelNoOfGraph.Text = "No of Graphs";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(23, 20);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(64, 16);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Position";
            // 
            // labelGraphSize
            // 
            this.labelGraphSize.AutoSize = true;
            this.labelGraphSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraphSize.Location = new System.Drawing.Point(193, 20);
            this.labelGraphSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGraphSize.Name = "labelGraphSize";
            this.labelGraphSize.Size = new System.Drawing.Size(84, 16);
            this.labelGraphSize.TabIndex = 7;
            this.labelGraphSize.Text = "Graph Size";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(215, 46);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(42, 16);
            this.labelWidth.TabIndex = 8;
            this.labelWidth.Text = "Width";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(215, 73);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(47, 16);
            this.labelHeight.TabIndex = 9;
            this.labelHeight.Text = "Height";
            // 
            // inputPositionX
            // 
            this.inputPositionX.Location = new System.Drawing.Point(95, 42);
            this.inputPositionX.Margin = new System.Windows.Forms.Padding(4);
            this.inputPositionX.MaxLength = 4;
            this.inputPositionX.Name = "inputPositionX";
            this.inputPositionX.Size = new System.Drawing.Size(75, 22);
            this.inputPositionX.TabIndex = 10;
            this.inputPositionX.Text = "40";
            // 
            // inputPositionY
            // 
            this.inputPositionY.Location = new System.Drawing.Point(95, 69);
            this.inputPositionY.Margin = new System.Windows.Forms.Padding(4);
            this.inputPositionY.MaxLength = 4;
            this.inputPositionY.Name = "inputPositionY";
            this.inputPositionY.Size = new System.Drawing.Size(75, 22);
            this.inputPositionY.TabIndex = 11;
            this.inputPositionY.Text = "200";
            // 
            // inputWidth
            // 
            this.inputWidth.Location = new System.Drawing.Point(265, 40);
            this.inputWidth.Margin = new System.Windows.Forms.Padding(4);
            this.inputWidth.MaxLength = 4;
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(75, 22);
            this.inputWidth.TabIndex = 12;
            this.inputWidth.Text = "300";
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(265, 70);
            this.inputHeight.Margin = new System.Windows.Forms.Padding(4);
            this.inputHeight.MaxLength = 4;
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(75, 22);
            this.inputHeight.TabIndex = 13;
            this.inputHeight.Text = "300";
            // 
            // inputNoOfGraph
            // 
            this.inputNoOfGraph.Location = new System.Drawing.Point(95, 147);
            this.inputNoOfGraph.MaxLength = 4;
            this.inputNoOfGraph.Name = "inputNoOfGraph";
            this.inputNoOfGraph.Size = new System.Drawing.Size(75, 22);
            this.inputNoOfGraph.TabIndex = 14;
            this.inputNoOfGraph.Text = "6";
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.ForeColor = System.Drawing.Color.Red;
            this.labelAlert.Location = new System.Drawing.Point(205, 195);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(0, 16);
            this.labelAlert.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 247);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.inputNoOfGraph);
            this.Controls.Add(this.inputHeight);
            this.Controls.Add(this.inputWidth);
            this.Controls.Add(this.inputPositionY);
            this.Controls.Add(this.inputPositionX);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelGraphSize);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelNoOfGraph);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PDF Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelNoOfGraph;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelGraphSize;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox inputPositionX;
        private System.Windows.Forms.TextBox inputPositionY;
        private System.Windows.Forms.TextBox inputWidth;
        private System.Windows.Forms.TextBox inputHeight;
        private System.Windows.Forms.TextBox inputNoOfGraph;
        private System.Windows.Forms.Label labelAlert;
    }
}


namespace ICA9_StackyListDraw
{
    partial class ICA9_StackyListDraw
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
            this.components = new System.ComponentModel.Container();
            this.B_UndoLine = new System.Windows.Forms.Button();
            this.B_UndoSeg = new System.Windows.Forms.Button();
            this.B_ReduceComplex = new System.Windows.Forms.Button();
            this.B_Color = new System.Windows.Forms.Button();
            this.TrB_LineThick = new System.Windows.Forms.TrackBar();
            this.TB_StackListData = new System.Windows.Forms.TextBox();
            this.MouseTimer = new System.Windows.Forms.Timer(this.components);
            this.PickColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TrB_LineThick)).BeginInit();
            this.SuspendLayout();
            // 
            // B_UndoLine
            // 
            this.B_UndoLine.Enabled = false;
            this.B_UndoLine.Location = new System.Drawing.Point(13, 42);
            this.B_UndoLine.Name = "B_UndoLine";
            this.B_UndoLine.Size = new System.Drawing.Size(259, 23);
            this.B_UndoLine.TabIndex = 1;
            this.B_UndoLine.Text = "Undo Line";
            this.B_UndoLine.UseVisualStyleBackColor = true;
            this.B_UndoLine.Click += new System.EventHandler(this.B_UndoLine_Click);
            // 
            // B_UndoSeg
            // 
            this.B_UndoSeg.Enabled = false;
            this.B_UndoSeg.Location = new System.Drawing.Point(13, 71);
            this.B_UndoSeg.Name = "B_UndoSeg";
            this.B_UndoSeg.Size = new System.Drawing.Size(259, 23);
            this.B_UndoSeg.TabIndex = 2;
            this.B_UndoSeg.Text = "Undo Segment";
            this.B_UndoSeg.UseVisualStyleBackColor = true;
            this.B_UndoSeg.Click += new System.EventHandler(this.B_UndoSeg_Click);
            // 
            // B_ReduceComplex
            // 
            this.B_ReduceComplex.Enabled = false;
            this.B_ReduceComplex.Location = new System.Drawing.Point(13, 100);
            this.B_ReduceComplex.Name = "B_ReduceComplex";
            this.B_ReduceComplex.Size = new System.Drawing.Size(259, 23);
            this.B_ReduceComplex.TabIndex = 3;
            this.B_ReduceComplex.Text = "Reduce Complexity";
            this.B_ReduceComplex.UseVisualStyleBackColor = true;
            this.B_ReduceComplex.Click += new System.EventHandler(this.B_ReduceComplex_Click);
            // 
            // B_Color
            // 
            this.B_Color.Location = new System.Drawing.Point(13, 129);
            this.B_Color.Name = "B_Color";
            this.B_Color.Size = new System.Drawing.Size(259, 23);
            this.B_Color.TabIndex = 4;
            this.B_Color.Text = "Color";
            this.B_Color.UseVisualStyleBackColor = true;
            this.B_Color.Click += new System.EventHandler(this.B_Color_Click);
            // 
            // TrB_LineThick
            // 
            this.TrB_LineThick.Location = new System.Drawing.Point(13, 159);
            this.TrB_LineThick.Minimum = 1;
            this.TrB_LineThick.Name = "TrB_LineThick";
            this.TrB_LineThick.Size = new System.Drawing.Size(259, 45);
            this.TrB_LineThick.TabIndex = 5;
            this.TrB_LineThick.Value = 1;
            // 
            // TB_StackListData
            // 
            this.TB_StackListData.Enabled = false;
            this.TB_StackListData.Location = new System.Drawing.Point(13, 13);
            this.TB_StackListData.Name = "TB_StackListData";
            this.TB_StackListData.Size = new System.Drawing.Size(259, 20);
            this.TB_StackListData.TabIndex = 6;
            this.TB_StackListData.Text = "0 lines, 0 total lines";
            this.TB_StackListData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MouseTimer
            // 
            this.MouseTimer.Enabled = true;
            this.MouseTimer.Interval = 10;
            this.MouseTimer.Tick += new System.EventHandler(this.MouseTimer_Tick);
            // 
            // ICA9_StackyListDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.TB_StackListData);
            this.Controls.Add(this.TrB_LineThick);
            this.Controls.Add(this.B_Color);
            this.Controls.Add(this.B_ReduceComplex);
            this.Controls.Add(this.B_UndoSeg);
            this.Controls.Add(this.B_UndoLine);
            this.Name = "ICA9_StackyListDraw";
            this.Text = "StackListDraw";
            ((System.ComponentModel.ISupportInitialize)(this.TrB_LineThick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_UndoLine;
        private System.Windows.Forms.Button B_UndoSeg;
        private System.Windows.Forms.Button B_ReduceComplex;
        private System.Windows.Forms.Button B_Color;
        private System.Windows.Forms.TrackBar TrB_LineThick;
        private System.Windows.Forms.TextBox TB_StackListData;
        private System.Windows.Forms.Timer MouseTimer;
        private System.Windows.Forms.ColorDialog PickColor;
    }
}


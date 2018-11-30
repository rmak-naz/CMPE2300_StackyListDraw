using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA9_StackyListDraw
{
    public partial class ICA9_StackyListDraw : Form
    {
        private Stack<LinkedList<LineSeg>> _lineStack = new Stack<LinkedList<LineSeg>>();
        private CDrawer _canvas = new CDrawer(1024, 768);
        private bool _drawFlag = false;
        private Point lastMousePos;
        private Color _color = Color.Black;
        private int totalLines = 0;

        public ICA9_StackyListDraw()
        {
            InitializeComponent();
            _canvas.BBColour = Color.White;
        }

        private void B_UndoLine_Click(object sender, EventArgs e)
        {
            _drawFlag = false;
            if (_lineStack.Count > 0)
                totalLines -= _lineStack.Peek().Count;
                _lineStack.Pop();                

            Render();
        }

        private void B_UndoSeg_Click(object sender, EventArgs e)
        {
            _drawFlag = false;
            if (_lineStack.Count > 0 && _lineStack.Peek().Count > 0 )
            {
                _lineStack.Peek().RemoveLast();                
            }                

            if (_lineStack.Peek().Count == 0)
            {
                _lineStack.Pop();
            }

            totalLines -= 1;
            Render();
        }

        private void B_ReduceComplex_Click(object sender, EventArgs e)
        {
            LinkedListNode<LineSeg> scan = _lineStack.Peek().First;
            LineSeg fusedLine;

            if (_lineStack.Peek().Count >= 2)
            {
                while (scan != null && scan.Next != null)
                {                                       
                    fusedLine = new LineSeg(scan.Value.GetStart, scan.Next.Value.GetEnd, scan.Value.GetThickness, scan.Value.GetColor);
                    scan.Value = fusedLine;
                    _lineStack.Peek().Remove(scan.Next);
                    scan = scan.Next;
                    totalLines -= 1;
                }
            }

            Render();
        }

        private void B_Color_Click(object sender, EventArgs e)
        {
            DialogResult result = PickColor.ShowDialog();

            if (result == DialogResult.OK)
            {
                _color = PickColor.Color;
            }
        }

        private void MouseTimer_Tick(object sender, EventArgs e)
        {
            Point curPos;

            if (_canvas.GetLastMouseLeftClick(out curPos) && _drawFlag == false)
            {
                _drawFlag = true;
                _lineStack.Push(new LinkedList<LineSeg>());
                lastMousePos = curPos;
            }

            if (_canvas.GetLastMousePosition(out curPos) && _drawFlag == true)
            {
                LineSeg line = new LineSeg(lastMousePos, curPos, TrB_LineThick.Value, _color);
                totalLines += 1;
                _lineStack.Peek().AddLast(line);
                lastMousePos = curPos;

                line.Render(_canvas);
            }

            if (_canvas.GetLastMouseRightClick(out curPos) && _drawFlag == true)
            {
                _drawFlag = false;
            }

            UpdateInfo();
        }

        private void Render()
        {
            _canvas.Clear();
            foreach (LinkedList<LineSeg> lineSeg in _lineStack)
            {
                foreach (LineSeg line in lineSeg)
                {
                    line.Render(_canvas);
                }
            }

            UpdateInfo();
        }

        private void UpdateInfo()
        {
            TB_StackListData.Text = _lineStack.Count.ToString() + " lines; " + totalLines + " line segments";
            if (_lineStack.Count <= 0)
            {
                B_UndoLine.Enabled = false;
                B_UndoSeg.Enabled = false;
                B_ReduceComplex.Enabled = false;
            }
            else
            {
                B_UndoLine.Enabled = true;
                B_UndoSeg.Enabled = true;
                if (_lineStack.Peek().Count > 1)
                    B_ReduceComplex.Enabled = true;
                else
                    B_ReduceComplex.Enabled = false;

            }
        }
    }
}

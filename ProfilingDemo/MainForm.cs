using System;
using System.Windows.Forms;

namespace ProfilingDemo
{
    public partial class MainForm : Form
    {
        private GameOfLifeEngine _engine;
        private Painter _painter;
        private bool[,] board;
        private int _golWidth = 100;
        private int _golHeight = 50;

        public MainForm()
        {
            InitializeComponent();
            _engine = new GameOfLifeEngine(_golWidth, _golHeight);
            board = new bool[_golWidth, _golHeight];
            _painter = new Painter(BoardPictureBox.Width, BoardPictureBox.Height);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            board = _engine.GenerateBoard();
            BoardPictureBox.Image = _painter.DrawBoard(board);
        }
    }
}

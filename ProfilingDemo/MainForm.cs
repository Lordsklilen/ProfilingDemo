using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfilingDemo
{
    public partial class MainForm : Form
    {
        CancellationTokenSource source = new CancellationTokenSource();
        private GameOfLifeEngine _engine;
        private Painter _painter;
        private bool[,] board;
        private int _golWidth = 160;
        private int _golHeight = 80;

        public MainForm()
        {
            InitializeComponent();
            _engine = new GameOfLifeEngine(_golWidth, _golHeight);
            _painter = new Painter(BoardPictureBox.Width, BoardPictureBox.Height);
            GenerateButton_Click(null, null);
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            source = new CancellationTokenSource();
            var token = source.Token;
            while (!token.IsCancellationRequested)
            {
                BoardPictureBox.Image = await Task.Run(() =>
                {

                    board = _engine.RunIteration(board);
                    return _painter.DrawBoard(board);
                }, token);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            source.Cancel();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            board = _engine.GenerateBoard();
            BoardPictureBox.Image = _painter.DrawBoard(board);
        }
    }
}

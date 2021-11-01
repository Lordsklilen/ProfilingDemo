using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfilingDemo
{
    public partial class MainForm : Form
    {
        CancellationTokenSource source = new();
        private GameOfLifeEngine _engine;
        private Painter _painter;
        private bool[,] board;
        private readonly int _golWidth = 160;
        private readonly int _golHeight = 80;

        public MainForm()
        {
            InitializeComponent();
            _engine = new GameOfLifeEngine(_golWidth, _golHeight);
            _painter = new Painter(BoardPictureBox.Width, BoardPictureBox.Height);
            GenerateButton_Click(null, null);
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            source.Cancel();
            source = new CancellationTokenSource();
            while (!source.Token.IsCancellationRequested)
            {
                board = await Task.Run(() =>
                {
                    return _engine.RunIteration(board);
                }, source.Token);
                BoardPictureBox.Image = await Task.Run(() =>
                {
                    return _painter.DrawBoard(board);
                }, source.Token);
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

        private async void Run100IterationsButton_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            source.Cancel();
            source = new CancellationTokenSource();
            var counter = 0;
            sw.Start();
            while (!source.Token.IsCancellationRequested && counter < 100)
            {
                board = await Task.Run(() =>
                {
                    return _engine.RunIteration(board);
                }, source.Token);
                BoardPictureBox.Image = await Task.Run(() =>
                {
                    return _painter.DrawBoard(board);
                }, source.Token);
                counter++;
            }
            sw.Stop();
            TimeLabel.Text = $"Time of 100 iterations: {sw.ElapsedMilliseconds} ms";
        }

        private void BoardPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            var posX = (int)((double)e.X / BoardPictureBox.Width * _golWidth);
            var posY = (int)((double)e.Y / BoardPictureBox.Height * _golHeight);
            board[posX, posY] = !board[posX, posY];
            BoardPictureBox.Image = _painter.DrawBoard(board);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            board = new bool[_golWidth, _golHeight];
            BoardPictureBox.Image = _painter.DrawBoard(board);
        }

        private void BoardPictureBox_SizeChanged(object sender, EventArgs e)
        {
            _engine = new GameOfLifeEngine(_golWidth, _golHeight);
            _painter = new Painter(BoardPictureBox.Width, BoardPictureBox.Height);
            BoardPictureBox.Image = _painter.DrawBoard(board);
        }
    }
}

using System;
using System.Windows.Forms;

namespace ProfilingDemo
{
    public partial class MainForm : Form
    {
        private GameOfLifeEngine _engine;
        private bool[,] board;
        private int _golWidth = 50;
        private int _golHeight = 50;

        public MainForm()
        {
            InitializeComponent();
            _engine = new GameOfLifeEngine(_golWidth, _golHeight);
            board = new bool[_golWidth, _golHeight];
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {

        }
    }
}

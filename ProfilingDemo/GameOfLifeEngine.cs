using System;

namespace ProfilingDemo
{
    public class GameOfLifeEngine
    {

        private int _width;
        private int _height;
        private Random _rand;
        public GameOfLifeEngine(int width, int height)
        {
            _height = height;
            _width = width;
        }

        public bool[,] GenerateBoard()
        {
            var board = new bool[_width, _height];
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    _rand = new Random();
                    board[i, j] = _rand.NextDouble() > 0.5;
                }
            }
            return board;
        }

        int CountLiveNeighbours(int x, int y, bool[,] board)
        {
            int counter = 0;
            var xSize = board.GetLength(0);
            var ySize = board.GetLength(1);
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int heightId = (i + y) >= 0 ? (i + y) % (ySize) : y - 1 >= 0 ? y - 1 : ySize - 1;
                    int widthId = (j + x) >= 0 ? (j + x) % (xSize) : x - 1 >= 0 ? x - 1 : xSize - 1;
                    if (board[widthId, heightId] && !(i == 0 && j == 0))
                        counter++;
                }
            }
            return counter;
        }
        bool CalculateState(int x, int y, bool[,] board)
        {
            int neighbours = CountLiveNeighbours(x, y, board);
            return board[x, y] ? neighbours == 2 || neighbours == 3 : neighbours == 3;
        }

        public bool[,] RunIteration(bool[,] board)
        {
            var newBoard = new bool[_width, _height];
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    newBoard[i, j] = CalculateState(i, j, board);
                }
            }
            return newBoard;
        }

        public bool[,] RunIterationBad(bool[,] board)
        {
            var newBoard = new bool[_width, _height];
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    newBoard[i, j] = CalculateStateBad(i, j, board);
                }
            }
            return newBoard;
        }
        bool CalculateStateBad(int x, int y, bool[,] board)
        {
            return board[x, y] ? CountLiveNeighbours(x, y, board) == 2 || CountLiveNeighbours(x, y, board) == 3 : CountLiveNeighbours(x, y, board) == 3;
        }

    }
}

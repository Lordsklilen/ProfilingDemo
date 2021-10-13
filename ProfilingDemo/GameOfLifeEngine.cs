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
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    //if ((j + x) >= y || (j + x) <= -1)
                    //break;// comment this to make it full thorus
                    int widthId = (i + y) >= 0 ? (i + y) % (x) : x - 1;
                    int heightId = (j + x) >= 0 ? (j + x) % (y) : y - 1;
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
    }
}

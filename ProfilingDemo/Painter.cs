using System.Drawing;

namespace ProfilingDemo
{
    public class Painter
    {
        private int _pictureWidth;
        private int _pictureHeight;
        private int _spaceSize = 1;

        private readonly SolidBrush _blackBrush = new SolidBrush(Color.Black);
        private readonly SolidBrush _grayBrush = new SolidBrush(Color.Gray);
        public Painter(int pictureWidth, int pictureHeight)
        {

            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }

        public Bitmap DrawBoard(bool[,] board)
        {
            var xSize = board.GetLength(0);
            var ySize = board.GetLength(1);

            double deltaX = (_pictureWidth - (_spaceSize * (xSize + 1))) / (double)xSize;
            double deltaY = (_pictureHeight - (_spaceSize * (ySize + 1))) / (double)ySize;


            var bmp = new Bitmap(_pictureWidth, _pictureHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int i = 0; i < xSize; i++)
                {
                    for (int j = 0; j < ySize; j++)
                    {
                        var x = (int)(((_spaceSize * (i + 1))) + deltaX * i);
                        var y = (int)(((_spaceSize * (j + 1))) + deltaY * j);
                        if (board[i, j])
                        {
                            g.FillRectangle(new SolidBrush(Color.Black), x, y, (int)deltaX, (int)deltaY);
                        }
                        else
                        {
                            g.FillRectangle(new SolidBrush(Color.Gray), x, y, (int)deltaX, (int)deltaY);
                        }
                    }
                }

            }
            return bmp;
        }
    }
}

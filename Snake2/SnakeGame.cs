using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    public enum DireccioSnake
    {
        Dreta,
        Esquerra,
        Avall,
        Amunt
    }
    class SnakeGame
    {

        public const int X_SIZE = 5;
        public const int Y_SIZE = 5;

        Point capSerp = new Point(0,0);
        DireccioSnake direccio = DireccioSnake.Avall;

        public Point CapSerp { get => capSerp; set => capSerp = value; }
        public DireccioSnake Direccio { get => direccio; set => direccio = value; }

        internal void Moure()
        {
            capSerp.Y++;
        }
    }

}

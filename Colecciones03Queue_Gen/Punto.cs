namespace Colecciones03Queue_Gen
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format($"X = {x}, Y = {y}");
        }
    }
}
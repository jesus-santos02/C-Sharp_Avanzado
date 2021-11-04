namespace MetodosAnonimos03
{
    public class Punto
    {
        public delegate void DelMessage();
        public DelMessage mensaje;
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
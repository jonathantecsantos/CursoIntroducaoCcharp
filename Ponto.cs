namespace DigitalInovationOneDOTNET
{
    public class Ponto
    {
        public int x;
        public int y;
        private int distancia;

        public Ponto (int valorx, int valory){
            this.x = valorx;
            this.y = valory;
            distancia = y*x;
        }

        public int CalcularDistancia(){
            return x * y;
        }
    }
}
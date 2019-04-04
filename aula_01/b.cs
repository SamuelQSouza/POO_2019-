namespace aula01
{
    public class Retangulo
    {
        public double basis;
        public double altura;

        //metodos
        public Retangulo()//construtor default
        {
            basis = 10.0;
            altura = 20.0;
        }
        public Retangulo(double b, double a)
        {
            basis = b;
            altura = a;
        }

        public double Area()
        {
            return (basis * altura);
        }

        public double Perimetro()
        {
            return((2*basis)+(2*altura));
        }
    }
    
}
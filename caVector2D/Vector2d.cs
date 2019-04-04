using System;
namespace caVector2D
{
    public class Vector2d
    {
        //atributos
        private double x;
        private double y;
        //metodos
        public Vector2d(){
            x = 0.0;
            y = 0.0;
        }
        public Vector2d(double X,double Y){
            x= X;
            y= Y;
        }
        public double getX() { 
            return x;}
        public double getY() { 
            return y;}
        public void setX(double X) { 
            X = x;}
        public void setY(double Y) { 
            Y = y;}
        public double modulovet(){
            //v1.angVet() calcula o modulo de v1.
            double modulo;
            modulo = Math.Sqrt(x*x + y*y);
            return modulo;
        }
        public double prodEsc(Vector2d v) {
            //v1.prodEsc(v2) calcula o produto escalar entre v1 e v2
            double escalar;
            escalar = x * v.getX() + y * v.getY();
            return escalar;
        }
        public double angVet(Vector2d v) {
            //v1.angVet(v2) calcula o angulo entre v1 e v2
            double angulo;
            double pi = 3.141592653589;
            angulo = 180*(Math.Acos(prodEsc(v)/(modulovet()*v.modulovet()))/pi);
            return angulo;
        }

    
        public Vector2d projVet(Vector2d v) {
            /* 
            v1.projVet(v2) é a projeção vetorial de v2 em v1
            analogamente 
            v2.projVet(v1) é a projeção vetorial de v1 em v2
            */
            Vector2d z = new Vector2d();
            double auxiliar = prodEsc(v) / (Math.Pow(modulovet(), 2));
            z.setX(x*auxiliar);
            z.setY(y*auxiliar);
            return z;     
        }
    }
}
using System;

namespace caESTACIONAMENTO
{
    public class Tempo
    {
        private int hor;
        private int min;
        private int seg;

        public Tempo(){
            hor = 0;
            min = 0;
            seg = 0; 
        }

        public void cadastrar(){
            bool aux =false;
            while(aux == false){
                aux=false;
                Console.WriteLine("Digite as hora(s):\n");
                hor = Convert.ToInt32(Console.ReadLine());
                if(hor<0 | hor>=24){
                    aux = true;                    
                }
                else {Console.WriteLine("entrada incorreta!");}
            }
            while(aux == false){
                aux=false;
                Console.WriteLine("Digite o(s) minuto(s):\n");
                min = Convert.ToInt32(Console.ReadLine());
                if(min<0 | min>=60){
                    aux = true;                    
                }
                else {Console.WriteLine("entrada incorreta!");}
            }
            while(aux == false){
                aux=false;
                Console.WriteLine("Digite os segundo:\n");
                seg = Convert.ToInt32(Console.ReadLine());
                if(hor<0 | seg>=60){
                    aux = true;                    
                }
                else {Console.WriteLine("entrada incorreta!");}
            }

        }
        protected void setSeg(int s){seg = s;}
        protected void setMin(int m){min = m;}
        protected void setHor(int h){hor =h;}
        public int getSeg(){return seg;}
        public int getMin(){return min;}
        public int getHor(){return hor;}
        public Tempo inc (Tempo t){
            Tempo aux= new Tempo();
            int segundos = t.getSeg() + seg;
            int minutos = t.getMin() + min;
            int horas = t.getHor() + hor;
            if (segundos >= 60)
            {
                segundos = segundos - 60;
                minutos ++;
            }
            if (minutos >= 60)
            {
                minutos = minutos - 60;
                horas++;
            }
            if (horas >= 24)
            {
                horas = horas - 24;            
            }
            aux.setSeg(segundos);
            aux.setMin(minutos);
            aux.setHor(horas);
            return aux;
        }
        public Tempo dec (Tempo t){
            Tempo aux = new Tempo();
            int segundos = t.getSeg() - seg;
            int minutos = t.getMin() - min;
            int horas = t.getHor() - hor;
            if (segundos < 0){segundos = segundos * (-1);}
            if (minutos < 0) {minutos  = minutos  * (-1);}
            if (horas < 0)   {  horas  = horas    * (-1);}
            aux.setSeg(segundos);
            aux.setMin(minutos);
            aux.setHor(horas);
            return aux;
        }
        public void print()
        {
            string str = "\n" + hor + ":" + min + ":" + seg + "\n";
            Console.WriteLine(str);
        }
    }
}






















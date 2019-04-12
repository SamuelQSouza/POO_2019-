using System;

namespace caESTACIONAMENTO
{
    public class Carro
    {
        private string placa;
        private string marca;
        private Tempo entrada;
        private Tempo saida;
        public Carro()
        {
            placa = null;
            marca = null;
            entrada = new Tempo();
            saida = new Tempo();
            
        }
        public void printcarro()
        {
            string str = "\nPlaca: " + placa + "\nMarca: " + marca + "\nEntrada: ";
            Console.WriteLine(str);
            entrada.print();
            Console.WriteLine("\nSaida: ");
            saida.print();
         }
        public void solicitar()
        {
            Console.WriteLine("Digite sua Placa:\n");
            placa = Console.ReadLine();
            Console.WriteLine("Digite a Marca:\n");
            marca = Console.ReadLine();
            Console.WriteLine("Digite a Entrada:\n");
            entrada.cadastrar();
            Console.WriteLine("Digite a Saida:\n");
            saida.cadastrar();
        }
        public void preco()
        {
            Tempo h = entrada.dec(saida);
            double total = 7.0*h.getHor();
            Console.WriteLine("\nPreco: " + total);
        }
    }
}

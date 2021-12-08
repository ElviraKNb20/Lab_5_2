using System;

namespace Lab_5_2
{
    interface ITool
    {
        string KEY { set { KEY = "До мажор"; } }
        void play();
    }
    class Guitar : ITool
    {
        public int quantity { get; set; }
        public Guitar(int quantity)
        {
            this.quantity = quantity;
        }
        public void play()
        {
            Console.WriteLine($"Грає гiтара з кiлькiстю струн - {quantity}");
        }
    }
    class Drum : ITool
    {
        public double size { get; set; }
        public Drum(double size)
        {
            this.size = size;
        }
        public void play()
        {
            Console.WriteLine($"Грає барабан з розмiром - {size} см");
        }
    }
    class Trumpet : ITool
    {
        public double diameter { get; set; }
        public Trumpet(double diameter)
        {
            this.diameter = diameter;
        }
        public void play()
        {
            Console.WriteLine($"Грає труба з дiаметром - {diameter}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITool[] tools = { new Guitar(6), new Drum(45.5), new Trumpet(5) };
            foreach (ITool t in tools)
            {
                t.play();
            }
        }
    }
}

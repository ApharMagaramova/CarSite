using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CarSite
{
    class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public bool Id { get; set; }
        static int nextId;
        public int ModelId { get; set; }

        public int Year { get; set; }
        public double Price { get; set; }
        public string ban { get; set; }
        public string color { get; set; }
        public string yanacaq { get; set; }

        enum Ban
        {
            hibrid, sedan
        }

        enum Color
        {
            ag = 1, qara = 2, qirmizi = 3, goy = 4
        }

        enum Yanacaq
        {
            dizel, benzin
        }

        public Car()
        {
            ModelId= Interlocked.Increment(ref nextId);
        }

        public Car(string marka, string model, int year, double price, int ban, int color, int yanacaq): this()
        {
            Marka = marka;
            Model = model;
            //ModelId = modelId;
            Year = year;
            Price = price;
            if (ban == 1)
                this.ban = Convert.ToString(Ban.hibrid);
            if (ban == 2)
                this.ban = Convert.ToString(Ban.sedan);

            if (color == 1)
                this.color = Convert.ToString(Color.ag);
            if (color == 2)
                this.color = Convert.ToString(Color.qara);
            if (color == 3)
                this.color = Convert.ToString(Color.qirmizi);
            if (color == 4)
                this.color = Convert.ToString(Color.goy);

            if (yanacaq == 1)
                this.yanacaq = Convert.ToString(Yanacaq.dizel);
            if (yanacaq == 2)
                this.yanacaq = Convert.ToString(Yanacaq.benzin);
            
        }

        public override string ToString()
        {
            return Marka.ToString() + "\n" + Model.ToString() + "\n" + ModelId.ToString() + "\t" + Year.ToString() + "\t" +
                Price.ToString() + "\t" + ban.ToString() + "\t" + color.ToString() + yanacaq.ToString();
        }
    }
}

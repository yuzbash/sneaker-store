using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class sneakers
    {
        private string size;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private string colour;

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }


        public sneakers(string size, string model, string colour, string price)
        {
            this.size = size;
            this.model = model;
            this.colour = colour;
            this.price = price;

        }
        public string ShowCharacters()
        {
            return this.model + "/n" + this.price + "/n" + this.colour + "/n" + this.size;
        }

        List<sneakers> sneak = new List<sneakers>();


    }
    
}



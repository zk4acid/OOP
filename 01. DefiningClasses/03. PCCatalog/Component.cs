using System;

namespace PCCatalog
{
    class Component
    {
        private string name;
        private decimal price;

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new Exception("Empty string");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value >=0)
                {
                    this.price = value;
                }
                else
                {
                    throw new Exception("Negative price");
                }
            }
        }
    }
}

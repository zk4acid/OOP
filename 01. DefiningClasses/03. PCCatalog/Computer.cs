using System;

namespace PCCatalog
{
    class Computer
    {
        private string name;
        Component computerProcessor;
        Component computerGraphicsCard;
        Component computerMotherboard;

        public Computer(string name, Component processor, Component graphicsCard, Component motherboard)
        {
            this.Name = name;
            computerProcessor = processor;
            computerGraphicsCard = graphicsCard;
            computerMotherboard = motherboard;
        }

        public Computer(string name) : this(name, null, null, null)
        {
            this.Name = name;
        }

        public Computer(string name, Component processor, decimal price) : this(name, processor, null, null)
        {
            this.Name = name;
            computerProcessor = processor;
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

        public decimal CalculateComputerPrice()
        {
            decimal totalComputerPrice = 0;
            if (computerProcessor.Price >= 0)
            {
                totalComputerPrice += computerProcessor.Price;
            }
            if (computerGraphicsCard.Price >= 0)
            {
                totalComputerPrice += computerGraphicsCard.Price;
            }
            if (computerMotherboard.Price >= 0)
            {
                totalComputerPrice += computerMotherboard.Price;
            }

            return totalComputerPrice;
        }

        public void PrintComputerInformation()
        {
            Console.WriteLine(this.Name);
            if (computerProcessor.Price > 0)
            {
                Console.WriteLine("--> {0} price: {1:c}", computerProcessor.Name, computerProcessor.Price);
            }
            if (computerGraphicsCard.Price > 0)
            {
                Console.WriteLine("--> {0} price: {1:c}", computerGraphicsCard.Name, computerGraphicsCard.Price);
            }
            if (computerMotherboard.Price > 0)
            {
                Console.WriteLine("--> {0} price: {1:c}", computerMotherboard.Name, computerMotherboard.Price);
            }
            if (this.CalculateComputerPrice() > 0)
            {
                Console.WriteLine("Total Price: {0:c}", this.CalculateComputerPrice());
            }         
        }
    }
}
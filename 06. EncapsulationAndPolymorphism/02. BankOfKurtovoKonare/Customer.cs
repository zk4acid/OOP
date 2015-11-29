namespace BankOfKurtovoKonare
{
    public class Customer
    {
        public Customer(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}

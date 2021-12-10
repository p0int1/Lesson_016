namespace Task_3
{
    public class House
    {
        private string street;
        private string number;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public House(string street, string number)
        {
            this.street = street;
            this.number = number;
        }

        public House Clone() //поверхностное копирование
        {
            return this; 
        }

        public House DeepClone() //глубокое копирование
        {
            return new House(this.Street, this.Number);
        }
    }
}

namespace Hotel
{
    public class Pessoa
    {
        private string _name = "";
        private string _lastName = "";

        public Pessoa(){}
        public Pessoa(string name){ Name = name; }
        public Pessoa(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");

                _name = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be empty");

                _lastName = value;
            }
        }

        public string FullName => $"{Name} {LastName}";
    }
}
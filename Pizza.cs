namespace Pizza_UML2
{
    public class Pizza
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Number: {Number}, Name: {Name}, Price: {Price}";
        }
    }
}
/*
 * @Author Muhammed Tastan
 * 
 * Zipped from https://github.com/jpandersen61/UML2
 */ 
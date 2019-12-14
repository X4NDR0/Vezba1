namespace Vezba1.Models
{
    public class SecondClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public SecondClass()
        {

        }

        public SecondClass(string dataFromString)
        {
            string[] tokens = dataFromString.Split(';');

            Name = tokens[0];
            Surname = tokens[1];
        }

        public SecondClass(int numberOne, int numberTwo)
        {
            if (numberOne == 1)
            {
                Name = "Petar";
            }

            if (numberTwo == 2)
            {
                Surname = "Petrovic";
            }
        }
    }
}

using Vezba1.Models;

namespace Vezba1
{
    /// <summary>
    /// Main class where we will do all the logic.
    /// </summary>
    public class Main
    {
        /// <summary>
        /// Main entry point for the whole project.
        /// </summary>
        public void Initialize()
        {
            FirstClass firstClass = new FirstClass();

            SecondClass secondClass1 = new SecondClass();

            SecondClass secondClass2 = new SecondClass("Petar;Petrovic");


        }
    }
}

using Greater.Models.Interfaces;

namespace Greater.Models
{
    public class Hello : IGreeting
    {
        public string Text { get; set; }

        public Hello()
        {
            Text = "Hi there!";
        }
    }
}
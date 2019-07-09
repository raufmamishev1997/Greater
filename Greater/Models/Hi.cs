using Greater.Models.Interfaces;

namespace Greater.Models
{
    public class Hi : IGreeting
    {
        public string Text { get; set; }

        public Hi()
        {
            Text = "Hi everyone!";
        }
    }
}
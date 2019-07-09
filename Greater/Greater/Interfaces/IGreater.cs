using Greater.Models.Interfaces;

namespace Greater.Greater.Interfaces
{
    public interface IGreater<T> where T : IGreeting
    {
        string SayHello();
    }
}

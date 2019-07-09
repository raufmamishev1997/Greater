using Greater.Greater.Interfaces;
using Greater.Models;
using Greater.Models.Interfaces;
using System;

namespace Greater.Greater
{
    public class Greater<T> : IGreater<T> where T : IGreeting
    {
        public string SayHello()
        {
            IGreeting greeting = Activator.CreateInstance<T>();

            return greeting.Text;
        }
    }
}
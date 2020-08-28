using System;
using TestConsole.ClassTests;

namespace TestConsole
{
    class Program
    {
        static IServiceOne _class;
        static IServiceTwo _anotherClass;
        static void Main(string[] args)
        {
            var one = new ImplementingClass();
            var two = new AnotherImplementingClass();

            MockConstructor(one, two);

            Console.WriteLine(_class.ServiceOneMethods());

            Console.WriteLine(_anotherClass.ServiceTwoMethods());
        }

        private static void MockConstructor(IServiceOne impl,IServiceTwo implTwo)
        {
            //this would be any service that requires a config. They inherit from BaseConfigurableClass. Annd they'll have a _config prop;
            _class = (IServiceOne)impl.Configure();

            _anotherClass = (IServiceTwo)implTwo.Configure();

        }
    }
}

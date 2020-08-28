using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.ClassTests
{
    public class AnotherImplementingClass : BaseConfigurableClass, IServiceTwo
    {
        public int anothernumber { get; set; }
        public AnotherImplementingClass()
        {
            _config = new ConfigClass();
            anothernumber = 100;
        }
        public BaseConfigurableClass Configure()
        {
            _config.stringer = "anotherStringer";
            _config.intId = 2;
            return this;
        }

        public string ServiceTwoMethods()
        {
            return "2";
        }
    }
}

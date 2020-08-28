using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.ClassTests
{
    public class ImplementingClass :BaseConfigurableClass, IServiceOne
    {
        public int number { get; set; }
        public ImplementingClass()
        {
            _config = new ConfigClass();
            number = 10;
        }
        public BaseConfigurableClass Configure()
        {
            _config.stringer = "Implementing";
            _config.intId = 1;
            return this;
        }

        public string ServiceOneMethods()
        {
            return "1";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Math2
    {
        private static Math2 _default;
        public static Math2 Default
        {
            get
            {
                if (_default == null)
                    _default = new Math2();
                return _default;
            }
        }

        private Math2()
        {
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiple(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

    }
}

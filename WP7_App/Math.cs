using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Math
    {
        private static Math _default;
        public static Math Default
        {
            get
            {
                if (_default == null)
                    _default = new Math();
                return _default;
            }
        }

        private Math()
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

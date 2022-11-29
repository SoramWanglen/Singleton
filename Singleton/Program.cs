//Thread Safety Singleton using Double-Check Locking
using System;

namespace Singleton
{
    public sealed class Program
    {
        private Program()
        {
        }
        private static readonly Lazy<Program> lazy = new Lazy<Program>(() => new Program());
        public static Program Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}

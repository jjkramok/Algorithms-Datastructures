using System;

namespace CompositePattern
{
    public class D8
    {
        public int Roll()
        {
            return new Random().Next(1, 9);
        }  
    }
}
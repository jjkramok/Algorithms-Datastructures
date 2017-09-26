using System;

namespace CompositePattern
{
    public class D4 : Die
    {
        public int Roll()
        {
            return new Random().Next(1, 5);
        }  
    }
}
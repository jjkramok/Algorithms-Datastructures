using System;

namespace CompositePattern
{
    public class D6 : Die
    {
        public int Roll()
        {
            return new Random().Next(1, 7);
        }  
    }
}
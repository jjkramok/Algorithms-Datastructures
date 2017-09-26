using System;

namespace CompositePattern
{
    public class D20 : Die
    {
        public int Roll()
        {
            return new Random().Next(1, 21);
        }  
    }
}
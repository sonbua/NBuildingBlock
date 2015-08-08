using System;

namespace NBuildingBlock.String
{
    public class StringConstructorBlock : IBlock<char[], string>
    {
        public StringConstructorBlock()
        {
            Handle = chars => new string(chars);
        }

        public Func<char[], string> Handle { get; private set; }
    }
}
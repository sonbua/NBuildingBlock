using System;

namespace NBuildingBlock
{
    public class NoOutputBlock<TInput> : IBlock<TInput, Nothing>
    {
        public NoOutputBlock()
        {
            Handle = input => new Nothing();
        }

        public Func<TInput, Nothing> Handle { get; private set; }
    }
}
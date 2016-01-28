using System;

namespace NBuildingBlock.ControlStructure
{
    internal class AnonymousBlock<TInput, TOutput> : IBlock<TInput, TOutput>
    {
        public AnonymousBlock(Func<TInput, TOutput> handlerFunc)
        {
            Handle = handlerFunc;
        }

        public Func<TInput, TOutput> Handle { get; }
    }
}

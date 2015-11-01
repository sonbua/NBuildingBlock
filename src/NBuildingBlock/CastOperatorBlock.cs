using System;

namespace NBuildingBlock
{
    public class CastOperatorBlock<TInput, TOutput> : IBlock<TInput, TOutput> where TInput : TOutput
    {
        public CastOperatorBlock()
        {
            Handle = derived => (TOutput) derived;
        }

        public Func<TInput, TOutput> Handle { get; private set; }
    }
}
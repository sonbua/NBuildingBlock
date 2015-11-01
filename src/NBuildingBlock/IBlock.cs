using System;

namespace NBuildingBlock
{
    public interface IBlock<TInput, TOutput>
    {
        Func<TInput, TOutput> Handle { get; }
    }
}
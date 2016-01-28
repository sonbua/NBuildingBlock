using System;

namespace NBuildingBlock.ControlStructure
{
    internal class SequentialBlock<TInput, TMiddle, TOutput> : IBlock<TInput, TOutput>
    {
        public SequentialBlock(IBlock<TInput, TMiddle> firstBlock, IBlock<TMiddle, TOutput> nextBlock)
        {
            Handle = input => nextBlock.Handle(firstBlock.Handle(input));
        }

        public Func<TInput, TOutput> Handle { get; }
    }
}
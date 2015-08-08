using System;
using System.Collections.Generic;
using System.Linq;

namespace NBuildingBlock.Linq
{
    public class SelectManyBlock<TInput, TOutput> : IBlock<IEnumerable<TInput>, IEnumerable<TOutput>>
    {
        public SelectManyBlock(Func<TInput, IEnumerable<TOutput>> selector)
        {
            Handle = inputs => inputs.SelectMany(selector);
        }

        public SelectManyBlock(IBlock<TInput, IEnumerable<TOutput>> innerBlock)
        {
            Handle = inputs => inputs.SelectMany(innerBlock.Handle);
        }

        public Func<IEnumerable<TInput>, IEnumerable<TOutput>> Handle { get; private set; }
    }
}
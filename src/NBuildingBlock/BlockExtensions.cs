using System;
using System.Threading.Tasks;
using NBuildingBlock.ControlStructure;

namespace NBuildingBlock
{
    public static class BlockExtensions
    {
        public static IBlock<TInput, TOutput> ForwardCompose<TInput, TMiddle, TOutput>(this IBlock<TInput, TMiddle> firstBlock, IBlock<TMiddle, TOutput> nextBlock)
        {
            if (firstBlock == null)
            {
                throw new ArgumentNullException(nameof(firstBlock));
            }

            if (nextBlock == null)
            {
                throw new ArgumentNullException(nameof(nextBlock));
            }

            return new SequentialBlock<TInput, TMiddle, TOutput>(firstBlock, nextBlock);
        }

        public static IBlock<TInput, TOutput> ForwardCompose<TInput, TMiddle, TOutput>(this IBlock<TInput, TMiddle> firstBlock, Func<TMiddle, TOutput> nextFunc)
        {
            if (firstBlock == null)
            {
                throw new ArgumentNullException(nameof(firstBlock));
            }

            if (nextFunc == null)
            {
                throw new ArgumentNullException(nameof(nextFunc));
            }

            return new AnonymousBlock<TInput, TOutput>(firstBlock.Handle.ForwardCompose(nextFunc));
        }

        public static IBlock<TInput, Task<TOutput>> AsCpuBoundTaskBlock<TInput, TOutput>(this IBlock<TInput, TOutput> block)
        {
            return new CpuBoundTaskBlock<TInput, TOutput>(block);
        }
    }
}

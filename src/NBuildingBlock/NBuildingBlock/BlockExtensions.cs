using System.Threading.Tasks;
using NBuildingBlock.ControlStructure;

namespace NBuildingBlock
{
    public static class BlockExtensions
    {
        public static IBlock<TInput, TOutput> ContinueWith<TInput, TMiddle, TOutput>(this IBlock<TInput, TMiddle> firstBlock, IBlock<TMiddle, TOutput> nextBlock)
        {
            return new SequentialBlock<TInput, TMiddle, TOutput>(firstBlock, nextBlock);
        }

        public static IBlock<TInput, Task<TOutput>> AsCpuBoundTaskBlock<TInput, TOutput>(this IBlock<TInput, TOutput> block)
        {
            return new CpuBoundTaskBlock<TInput, TOutput>(block);
        }
    }
}
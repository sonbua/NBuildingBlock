using System;

namespace NBuildingBlock
{
    public static class FuncExtensions
    {
        public static Func<TInput, TOutput> ForwardCompose<TInput, TMiddle, TOutput>(this Func<TInput, TMiddle> firstFunc, Func<TMiddle, TOutput> nextFunc)
        {
            if (firstFunc == null)
            {
                throw new ArgumentNullException(nameof(firstFunc));
            }

            if (nextFunc == null)
            {
                throw new ArgumentNullException(nameof(nextFunc));
            }

            return input => nextFunc(firstFunc(input));
        }
    }
}

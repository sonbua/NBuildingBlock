using System;
using System.Threading.Tasks;

namespace NBuildingBlock.ControlStructure
{
    public class ResultSynchronizationBlock<TOutput> : IBlock<Task<TOutput>, TOutput>
    {
        public ResultSynchronizationBlock()
        {
            Handle = task => task.Result;
        }

        public Func<Task<TOutput>, TOutput> Handle { get; private set; }
    }
}
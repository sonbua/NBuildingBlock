using System;
using System.Collections.Generic;

namespace NBuildingBlock.String
{
    public class WordCapitalizationBlock : IBlock<string, IEnumerable<char>>
    {
        public WordCapitalizationBlock()
        {
            Handle = InnerHandle;
        }

        public Func<string, IEnumerable<char>> Handle { get; private set; }

        private IEnumerable<char> InnerHandle(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                yield break;
            }

            yield return char.ToUpper(word[0]);

            for (var i = 1; i < word.Length; i++)
            {
                yield return word[i];
            }
        }
    }
}
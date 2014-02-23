using System.Collections.Generic;

namespace Humour.Model.Collections
{
    public class StoryComparer : IComparer<Story>
    {
        public int Compare(Story x, Story y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }
}

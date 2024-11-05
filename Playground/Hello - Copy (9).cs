
using System.Collections.ObjectModel;

namespace dog
{
    public class Hello
    {
        private int y; 
        public static int AddNumber(int a, int b)
        {
            int x = 10;
            return a + b;
        }

        public static int SubNumber(int a, int b)
        {
            return a - b;
        }

    }
    class CSharp13Enumerables
    {
        private ReadOnlySet<int> _setWrapper;

        public int[] SetWrapper
        {
            get { return _setWrapper.ToArray(); } // Noncompliant
        }
        private OrderedDictionary<int, string> _orderedDict;

        public List<KeyValuePair<int, string>> OrderedDict
        {
            get { return _orderedDict.ToList(); } // Noncompliant
        }

    }

}

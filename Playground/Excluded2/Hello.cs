
using System.Collections.ObjectModel;

namespace playground.Excluded2
{
    public class Hello
    {
        private int y; 

        public static int AddNumber(int a, int b)
        {
            int x = 10;
            int y = 12;
            int z = 13;
            int p = 10;
            int l = 12;
            int k = 13;
            int aa = 10;
            int bb = 13;
            int cc = 10;
            int dd = 10; 
            return a + b;
        }

        public static int AddNumberCopy(int a, int b)
        {
            int x = 10;
            int y = 12;
            int z = 13;
            int p = 10;
            int l = 12;
            int k = 13;
            int aa = 10;
            int bb = 13;
            int cc = 10;
            int dd = 10;
            return a + b;
        }

        public static int SubNumber(int a, int b)
        {
            return a - b;
        }

    }
#if NET9_0_OR_GREATER
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
#endif

}

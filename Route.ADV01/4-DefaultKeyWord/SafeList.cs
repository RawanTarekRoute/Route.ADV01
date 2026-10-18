using System.Security.Cryptography;

namespace Route.ADV01._4_DefaultKeyWord
{
    internal class SafeList<T>
    {
        private List<T> _items = [];

        public void Add (T item)
        {
            _items.Add(item);
        }

        public T GetElementAt(int index)
        {
            if ( index > 0 && index < _items.Count)
            {
                return _items[index];
            }

            return default;
        }
    }
}

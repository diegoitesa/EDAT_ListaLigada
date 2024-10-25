namespace ListaLigada.Logica
{
    internal class SingleList<T>
    {
        private SingleNode<T>? _first;

        public SingleList()
        {
            _first = null;
        }

        public bool isEmpty => _first == null;

        public void Add(T item)
        {
            var node = new SingleNode<T>(item);
            if (isEmpty)
            {
                _first = node;
            }
            else
            {
                var pointer = _first;
            }
        }
    }
}

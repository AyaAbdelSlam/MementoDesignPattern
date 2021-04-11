namespace OtherExample
{
    /// <summary>

    /// The 'Caretaker' class

    /// </summary>
    internal class ProspectMemory

    {
        private Memento _memento;

        // Property

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
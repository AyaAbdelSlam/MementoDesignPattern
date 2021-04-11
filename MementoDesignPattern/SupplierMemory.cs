namespace MementoDesignPattern
{
    /// <summary>
    /// The Caretaker class.  
    /// This class never examines the contents of any Memento and is
    /// responsible for keeping that memento.
    /// </summary>
    internal class SupplierMemory
    {
        private FoodSupplierMemento _memento;

        public FoodSupplierMemento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
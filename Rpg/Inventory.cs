namespace Rpg;

public class Inventory<T>
{
    public List<T> Items = new List<T>();
    
    public void AddItem(T item)
    {
        Items.Add(item);
    }

    public void RemoveItem(T item)
    {
        Items.Remove(item);
    }

    public List<T> ShowInventory()
    {
        return Items;
    }
}


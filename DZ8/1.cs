class Item
{
}

//Клас порушує принцип єдиного обов'язку, оскільки розв'язує одразу багато задач. Його можна розподілити на кілька класів

class Order
{
    private List<Item> itemList;

    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }
    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
    public List<Item> GetItems() {/*...*/}
    public int GetItemCount() {/*...*/}
}

class OrderDisplay
{
    public void PrintOrder(Order order) {/*...*/}
    public void ShowOrder(Order order) {/*...*/}
}

class OrderCommunication
{
    public void Load(Order order) {/*...*/}
    public void Save(Order order) {/*...*/}
}

class OrderManagement
{
    public void Update(Order order) {/*...*/}
    public void Delete(Order order) {/*...*/}
}

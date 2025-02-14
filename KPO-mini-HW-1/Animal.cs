namespace KPO_mini_HW_1;

public abstract class Animal: IAlive, IInventory
{
    public int Food { get; set; }
    public int Health { get; set; }
    public int Number { get; set; }
    public string InventoryName { get; set; }
    public string Name { get; set; }
}
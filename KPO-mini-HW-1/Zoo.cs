namespace KPO_mini_HW_1;

public class Zoo
{
    private List<Animal> _animals;
    private List<Thing> _things;
    private IVeterinaryClinic _veterinaryClinic;
    
    public Zoo(IVeterinaryClinic veterinaryClinic)
    {
        _animals = new List<Animal>();
        _things = new List<Thing>();
        _veterinaryClinic = veterinaryClinic;
    }

    public void TakeAnimal(Animal animal)
    {
        if (_veterinaryClinic.CheckAnimal(animal))
        {
            _animals.Add(animal);
        }
    }
    
    public void TakeThing(Thing thing)
    {
        _things.Add(thing);
    }

    public int GetCountAnimals()
    {
        return _animals.Count;
    }

    public int GetCountFoodConsumed()
    {
        return _animals.Select(animal => animal.Food).Sum();
    }

    public List<Animal> GetAnimalsForContactZoo()
    {
        return _animals.Where(animal => animal is Herbo && ((Herbo)animal).Kindness > 5).ToList();
    }

    public List<String> GetInventoryInfo()
    {
        List<String> inventoryInfo = new List<string>();
        foreach (Animal animal in _animals)
        {
            inventoryInfo.Add("Животное: " + animal.InventoryName + ", №" + animal.Number);
        }
        foreach (Thing thing in _things)
        {
            inventoryInfo.Add("Предмет: " + thing.InventoryName + ", №" + thing.Number);
        }

        return inventoryInfo;
    }
}
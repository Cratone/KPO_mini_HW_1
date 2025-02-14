namespace KPO_mini_HW_1;

public class VeterinaryClinic: IVeterinaryClinic
{
    public bool CheckAnimal(Animal animal)
    {
        return animal.Health >= 52;
    }
}
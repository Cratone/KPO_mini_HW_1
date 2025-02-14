using KPO_mini_HW_1;

namespace Tests;

public class VeterinaryClinicTests
{
    [Fact]
    public void CheckAnimal_HealthyAnimal_TrueReturned()
    {
        Animal animal = new Rabbit() { Health = 80 };
        VeterinaryClinic veterinaryClinic = new VeterinaryClinic();
        
        bool result = veterinaryClinic.CheckAnimal(animal);
        
        Assert.True(result);
    }
    
    [Fact]
    public void CheckAnimal_UnhealthyAnimal_FalseReturned()
    {
        Animal animal = new Rabbit() { Health = 40 };
        VeterinaryClinic veterinaryClinic = new VeterinaryClinic();
        
        bool result = veterinaryClinic.CheckAnimal(animal);
        
        Assert.False(result);
    }
}
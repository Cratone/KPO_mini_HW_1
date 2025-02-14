using Xunit;
using Moq;
using KPO_mini_HW_1;

namespace Tests;

public class ZooTests
{
    [Fact]
    public void TakeAnimal_ShouldAddHealthyAnimal()
    {
        var veterinaryClinicMock = new Mock<IVeterinaryClinic>();
        veterinaryClinicMock.Setup(vc => vc.CheckAnimal(It.IsAny<Animal>())).Returns(true);

        Zoo zoo = new Zoo(veterinaryClinicMock.Object);
        Animal monkey = new Monkey() { Health = 80 };

        zoo.TakeAnimal(monkey);

        Assert.Equal(1, zoo.GetCountAnimals());
    }
    
    [Fact]
    public void TakeAnimal_ShouldNotAddUnhealthyAnimal()
    {
        var veterinaryClinicMock = new Mock<IVeterinaryClinic>();
        veterinaryClinicMock.Setup(vc => vc.CheckAnimal(It.IsAny<Animal>())).Returns(false);

        Zoo zoo = new Zoo(veterinaryClinicMock.Object);
        Animal monkey = new Monkey() { Health = 40 };

        zoo.TakeAnimal(monkey);

        Assert.Equal(0, zoo.GetCountAnimals());
    }
    
    [Fact]
    public void TakeThing_ShouldAddThing()
    {
        var veterinaryClinicMock = new Mock<IVeterinaryClinic>();
        veterinaryClinicMock.Setup(vc => vc.CheckAnimal(It.IsAny<Animal>())).Returns(true);

        Zoo zoo = new Zoo(veterinaryClinicMock.Object);
        Thing banana = new Table();

        zoo.TakeThing(banana);

        Assert.Single(zoo.GetInventoryInfo());
    }
    
    [Fact]
    public void GetCountFoodConsumed_ShouldReturnSumOfFood()
    {
        var veterinaryClinicMock = new Mock<IVeterinaryClinic>();
        veterinaryClinicMock.Setup(vc => vc.CheckAnimal(It.IsAny<Animal>())).Returns(true);

        Zoo zoo = new Zoo(veterinaryClinicMock.Object);
        Animal monkey = new Monkey() { Health = 80, Food = 5 };
        Animal rabbit = new Rabbit() { Health = 80, Food = 3 };
        zoo.TakeAnimal(monkey);
        zoo.TakeAnimal(rabbit);

        Assert.Equal(8, zoo.GetCountFoodConsumed());
    }
    
    [Fact]
    public void GetAnimalsForContactZoo_ShouldReturnHerboWithKindnessMoreThanFive()
    {
        var veterinaryClinicMock = new Mock<IVeterinaryClinic>();
        veterinaryClinicMock.Setup(vc => vc.CheckAnimal(It.IsAny<Animal>())).Returns(true);

        Zoo zoo = new Zoo(veterinaryClinicMock.Object);
        Animal monkey = new Monkey() { Health = 80, Kindness = 6 };
        Animal rabbit = new Rabbit() { Health = 80, Kindness = 4 };
        Animal wolf = new Wolf() { Health = 80 };
        zoo.TakeAnimal(monkey);
        zoo.TakeAnimal(rabbit);
        zoo.TakeAnimal(wolf);

        Assert.Single(zoo.GetAnimalsForContactZoo());
    }
    
    [Fact]
    public void GetInventoryInfo_ShouldReturnInfoAboutAnimalsAndThings()
    {
        var veterinaryClinicMock = new Mock<IVeterinaryClinic>();
        veterinaryClinicMock.Setup(vc => vc.CheckAnimal(It.IsAny<Animal>())).Returns(true);

        Zoo zoo = new Zoo(veterinaryClinicMock.Object);
        Animal monkey = new Monkey() { Health = 80, Number = 1 };
        Animal rabbit = new Rabbit() { Health = 80, Number = 2 };
        Thing table = new Table() { Number = 3 };
        zoo.TakeAnimal(monkey);
        zoo.TakeAnimal(rabbit);
        zoo.TakeThing(table);

        Assert.Equal(3, zoo.GetInventoryInfo().Count);
    }
}
using Microsoft.Extensions.DependencyInjection;
using System;
using KPO_mini_HW_1;

internal class Program
{
    private static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection().AddTransient<IVeterinaryClinic, VeterinaryClinic>().BuildServiceProvider();
        Zoo zoo = new Zoo(serviceProvider.GetService<IVeterinaryClinic>());
        
        zoo.TakeAnimal(new Monkey() {Food = 7, Health = 100, Kindness = 10, Name = "Абу", Number = 1});
        zoo.TakeAnimal(new Monkey() {Food = 5, Health = 64, Kindness = 4, Name = "Годзилла", Number = 2});
        zoo.TakeAnimal(new Rabbit() {Food = 4, Health = 49, Kindness = 9, Name = "Питер", Number = 3});
        zoo.TakeAnimal(new Rabbit() {Food = 3, Health = 93, Kindness = 8, Name = "Бакс Банни", Number = 4});
        zoo.TakeAnimal(new Wolf() {Food = 10, Health = 75, Name = "Акела", Number = 5});
        zoo.TakeAnimal(new Wolf() {Food = 9, Health = 84, Name = "Ауф", Number = 6});
        zoo.TakeAnimal(new Tiger() {Food = 11, Health = 91, Name = "Виталий", Number = 7});
        zoo.TakeAnimal(new Tiger() {Food = 13, Health = 27, Name = "Шер-Хан", Number = 8});
        
        zoo.TakeThing(new Computer() {Number = 9});
        zoo.TakeThing(new Table() {Number = 10});
        zoo.TakeThing(new Table() {Number = 11});
        
        Console.WriteLine("Количество животных: " + zoo.GetCountAnimals());
        Console.WriteLine("Количество нужной еды: " + zoo.GetCountFoodConsumed() + " кг");
        
        Console.WriteLine("");
        
        Console.WriteLine("Животные для контактного зоопарка:");
        foreach (Animal animal in zoo.GetAnimalsForContactZoo())
        {
            Console.WriteLine(animal.InventoryName + " по кличке " + animal.Name);
        }
        
        Console.WriteLine("");
        
        Console.WriteLine("Инвентаризация:");
        foreach (String info in zoo.GetInventoryInfo())
        {
            Console.WriteLine(info);
        }
    }
}
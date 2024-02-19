namespace LIveDemoControllers;

public class AnimalService
{
    public List<Animal> Animals { get; set; } = [new Animal { Type = "Dog" }, new Animal { Type = "Cat" }];
}
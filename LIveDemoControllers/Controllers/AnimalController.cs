using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LIveDemoControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly AnimalService _animalService;
        
        public AnimalController(AnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet]
        public List<Animal> GetAllAnimals()
        {
            return _animalService.Animals;
        }

        [HttpGet("{id}")]
        public List<Animal> GetAnimal(int id)
        {
            return _animalService.Animals;
        }


        [HttpPost]
        public void AddAnimal(Animal animal)
        {
            _animalService.Animals.Add(animal);
        }

        [HttpDelete]
        public void RemoveAnimal(Animal animal)
        {
            _animalService.Animals.Remove(animal);
        }

        [HttpPut("{id}")]
        public void UpdateAnimal(int id, Animal animal)
        {
            _animalService.Animals[id] = animal;
        }
    }
}

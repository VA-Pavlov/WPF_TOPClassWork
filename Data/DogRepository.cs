using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_TOPClassWork.Models;

namespace WPF_TOPClassWork.Data
{
    public static class DogRepository
    {
        private static List<Dog> dogs = new List<Dog>();

        public static List<Dog> GetDog()
        {
            if (dogs.Count == 0)
            {
                Dog dog = new Dog()
                {
                    Name = "Марси",
                    Avatar = "/image/Собака1.png",
                    Gender = false,
                    DateOfBiesday = new DateTime(2025, 6, 8),
                    Weight = 2.7,
                    Event = 3,
                    CountPhoto = 9,
                    CountHost = 2,
                    CountGraft = 2,
                    CountNote = 2
                };
                Dog dog2 = new Dog()
                {
                    Name = "Полкан",
                    Avatar = "/image/Собака1.png",
                    Gender = true,
                    DateOfBiesday = new DateTime(2024, 1, 30),
                    Weight = 10,
                    Event = 50,
                    CountPhoto = 100,
                    CountHost = 1,
                    CountGraft = 20,
                    CountNote = 115
                };
                dogs.Add(dog);
                dogs.Add(dog2);
            }
            return dogs;
        }
    }
}

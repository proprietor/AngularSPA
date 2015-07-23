using System.Collections.Generic;
using AngularSPA.Interfaces;
using AngularSPA.Models;
using AngularSPA.ViewModels;

namespace AngularSPA.Services
{
    public class ZooService : IZooService
    {
        public IList<Animal> GetAnimals()
        {
            return new List<Animal>()
            {
                new Animal()
                {
                    Type = "Hourse",
                    Description = "Beautiful",
                }
            };
        }

        public IList<Reptile> GetReptiles()
        {
            return new List<Reptile>()
            {
                new Reptile()
                {
                    Type = "Crocodile", 
                    Description = "Very dangerous",
                }
            };
        }

        public IList<Insect> GetInsects()
        {
            return new List<Insect>()
            {
                new Insect() 
                {
                    Type = "Grasshopper",
                    Description = "Jumps good",
                }
            };
        }

        public ZooViewModel GetZooViewModel()
        {
            return new ZooViewModel()
            {
                Aminals = GetAnimals(),
                Insectors = GetInsects(),
                Reptiles = GetReptiles(),
            };
        }
    }
}
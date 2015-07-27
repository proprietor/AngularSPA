using System.Collections.Generic;
using System.Web.Script.Serialization;
using AngularSPA.Interfaces;
using AngularSPA.Models;
using AngularSPA.ViewModels;

namespace AngularSPA.Services
{
    public class ZooService : IZooService
    {
        private JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

        public string GetAnimals()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal()
                {
                    Type = "Hourse",
                    Description = "Beautiful",
                }
            };
            return javaScriptSerializer.Serialize(animals);
        }

        public string GetReptiles()
        {
            List<Reptile> reptiles = new List<Reptile>()
            {
                new Reptile()
                {
                    Type = "Crocodile", 
                    Description = "Very dangerous",
                }
            };
            return javaScriptSerializer.Serialize(reptiles);
        }

        public string GetInsects()
        {
            List<Insect> insects = new List<Insect>()
            {
                new Insect() 
                {
                    Type = "Grasshopper",
                    Description = "Jumps good",
                }
            };
            return javaScriptSerializer.Serialize(insects);
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
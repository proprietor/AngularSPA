using System.Collections.Generic;
using AngularSPA.Interfaces;
using AngularSPA.Models;

namespace AngularSPA.Services
{
    public class ZooService : IZooService
    {
        public IList<Animal> GetAnimals()
        {
            return new List<DomasticAminal>()
            {
                
            };
        }

        public IList<Reptile> GetReptiles()
        {
            return new List<Reptile>()
            {

            };
        }
    }
}
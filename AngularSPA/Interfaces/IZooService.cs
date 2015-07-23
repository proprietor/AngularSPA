using System.Collections.Generic;
using AngularSPA.Models;

namespace AngularSPA.Interfaces
{
    interface IZooService
    {
        IList<Animal> GetAnimals();

        IList<Reptile> GetReptiles();

        IList<Insect> GetInsects();
    }
}

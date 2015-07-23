using System.Collections.Generic;
using AngularSPA.Models;
using AngularSPA.ViewModels;

namespace AngularSPA.Interfaces
{
    interface IZooService
    {
        IList<Animal> GetAnimals();

        IList<Reptile> GetReptiles();

        IList<Insect> GetInsects();

        ZooViewModel GetZooViewModel();
    }
}

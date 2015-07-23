using System.Collections.Generic;
using AngularSPA.Models;

namespace AngularSPA.ViewModels
{
    public class ZooViewModel
    {
        public IList<Animal> Aminals { get; set; }

        public IList<Reptile> Reptiles { get; set; }

        public IList<Insect> Insectors { get; set; } 
    }
}
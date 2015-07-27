using AngularSPA.ViewModels;

namespace AngularSPA.Interfaces
{
    interface IZooService
    {
        string GetAnimals();

        string GetReptiles();

        string GetInsects();

        ZooViewModel GetZooViewModel();
    }
}

using Microsoft.Practices.Unity;
using ProductCatalogue.Models;
using ProductCatalogue.Models.Validations;

namespace ProductManagement.Factory
{
    public class Factory<T>
    {
        private static IUnityContainer _container = null;

        public static T Create(string type)
        {
            if (_container == null)
            {
                _container = new UnityContainer();
                _container.RegisterType<Product, Hotel>("Hotel", new InjectionConstructor(new HotelValidation()));
            }
            return _container.Resolve<T>(type);
        }
    }
}

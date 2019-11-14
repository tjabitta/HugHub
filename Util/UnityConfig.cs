/*

using Unity;
using ConsoleApp1.Domain.Interfaces;
using ConsoleApp1.Domain.Services;
using CommonServiceLocator;
namespace ConsoleApp1.Util
{
  public static class UnityConfig
  {
    public static void RegisterComponents()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();

      ServiceLocator.SetLocatorProvider(() => new UnityServiceLocatorAdapter(container));

      container.RegisterType<IQuotationSystem1, QuotationSystem1>();
      container.RegisterType<IQuotationSystem2, QuotationSystem2>();
      container.RegisterType<IQuotationSystem1, QuotationSystem3>();
      container.RegisterType<IPriceEngine, PriceEngine>();

      container.RegisterInstance<IQuotationSystem1>(new QuotationSystem1());
      container.RegisterInstance<IQuotationSystem2>(new QuotationSystem2());
      container.RegisterInstance<IQuotationSystem1>(new QuotationSystem3());
      container.RegisterInstance<IPriceEngine>(new PriceEngine());
    }
  }
}
*/
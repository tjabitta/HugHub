using ConsoleApp1.Domain.Models;
namespace ConsoleApp1.Domain.Interfaces
{
  public interface IPriceEngine
  {
    decimal GetPrice(PriceRequest request, out decimal tax, out string insurerName, out string errorMessage);
  }
}

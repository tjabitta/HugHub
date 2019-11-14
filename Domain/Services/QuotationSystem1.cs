using System.Dynamic;
using ConsoleApp1.Domain.Interfaces;

namespace ConsoleApp1.Domain.Services
{
  public class QuotationSystem1 : IQuotationSystem1
  {
    public dynamic GetPrice(dynamic request)
    {
      //makes a call to an external service - SNIP
      //var response = _someExternalService.PostHttpRequest(requestData);

      dynamic response = new ExpandoObject();
      response.Price = 123.45M;
      response.IsSuccess = true;
      response.Name = "Test Name";
      response.Tax = 123.45M * 0.12M;

      return response;
    }
  }
}

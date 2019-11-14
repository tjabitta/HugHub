using System.Dynamic;
using ConsoleApp1.Domain.Interfaces;

namespace ConsoleApp1.Domain.Services
{
  public class QuotationSystem3 : IQuotationSystem1
  {
    public dynamic GetPrice(dynamic request)
    {
      //makes a call to an external service - SNIP
      //var response = _someExternalService.PostHttpRequest(requestData);

      dynamic response = new ExpandoObject();
      response.Price = 92.67M;
      response.IsSuccess = true;
      response.Name = "zxcvbnm";
      response.Tax = 92.67M * 0.12M;

      return response;
    }
  }
}

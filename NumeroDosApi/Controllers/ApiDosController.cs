using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumeroDosApi.Models;

namespace NumeroDosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiDosController : ControllerBase
    {
        ApiDosModels apidos = new ApiDosModels()
        {
           amount=0
        };
        [HttpGet]
        public ActionResult<ApiDosModels> Get(string consignee,string consignor, int cartons)
        {
            apidos.amount = cartons*5;
            return apidos;
        }
    }
}

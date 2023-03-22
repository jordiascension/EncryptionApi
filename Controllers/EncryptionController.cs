using DotnetCoreCryptography;

using Microsoft.AspNetCore.Mvc;

using System.Security.Cryptography;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataEncryptionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncryptionController : ControllerBase
    {
        // GET api/<EncryptionController>/5
        [HttpGet(Name = "Aes")]
        public string Get(string data)
        {
            using (var myAes = Aes.Create())
            {
                var encrypted = MyEncryption.EncryptBytes(Encoding.UTF8.GetBytes(data),
                   myAes.Key, myAes.IV);
                return Convert.ToBase64String(encrypted);       
            }
        }
    }
}

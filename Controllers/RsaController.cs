using DotnetCoreCryptography;

using Microsoft.AspNetCore.Mvc;

using System.Security.Cryptography;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataEncryptionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RsaController : ControllerBase
    {
        [HttpGet(Name = "Rsa")]
        public string Get(string data)
        {
            using (var rsa = RSA.Create())
            {
                var encrypted = RSAEncryption.EncryptBytes(Encoding.UTF8.GetBytes(data),
                    rsa.ExportParameters(false));
                return Convert.ToBase64String(encrypted);
            }
        }
    }
}

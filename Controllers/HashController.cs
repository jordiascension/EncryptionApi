using DotnetCoreCryptography;

using Microsoft.AspNetCore.Mvc;

using System.Security.Cryptography;

using System.Text;
using System.Xml.Linq;

namespace DataEncryptionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HashController: ControllerBase
    {
        [HttpGet(Name = "Hash")]
        public string Get(string data)
        {
            byte[] originalBytes = Encoding.UTF8.GetBytes(data);
            var hash = HashEncryption.ComputeHash(originalBytes);
            return Convert.ToBase64String(hash);   
        }
    }
}

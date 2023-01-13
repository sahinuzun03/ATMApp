using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Domain.Entities
{
    public class Token
    {
        public string AccessToken { get; set; } // Üretilen token'ın ta kendisini tutar.
        public DateTime Expiration { get; set; }
        public string RefreshToken { get; set; }
        //AccessToken süresi doldu!!! Refresh token ile eğer bizim access token süresi dolarsa adamı sistemden atmayı adama hemen hızlıca yeni bir access token üretip sistemde işlem yapmaya devam etmesini sağlayalım.
    }
}

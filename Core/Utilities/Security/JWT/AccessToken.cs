﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken //erişim anahtarı
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; } //tokenin ne zaman sona ereceğinin bilgisi

    }
}

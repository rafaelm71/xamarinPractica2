using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    public class Token
    {
        public int Id { get; set; }
        public string access_token { get; set; }
        public int error_description { get; set; }

        public Token() { }

    }
}

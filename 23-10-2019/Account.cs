﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JsonProject1
{
   public  class Account
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
}

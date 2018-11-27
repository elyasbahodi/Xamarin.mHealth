﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mHealth.core.Models
{
    public class Client
    {
        public int Id { get; set;  }
        public int Height { get; set; }
        public DateTime Birthdate { get; set; }
        public int Weight{ get; set; }
        public Gender Gender { get; set; }
       

    }
}
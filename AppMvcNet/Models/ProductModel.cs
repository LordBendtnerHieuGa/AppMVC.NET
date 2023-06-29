﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcNet.Models
{
  
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
    }
}


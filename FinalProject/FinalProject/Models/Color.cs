﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Color
    {
        public int Id { get; set; }

        [Required,MaxLength(25)]
        public string Name { get; set; }

        public List<ProductInfo> Products { get; set; }
    }
}
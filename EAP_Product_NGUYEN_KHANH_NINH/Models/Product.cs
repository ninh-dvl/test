﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAP_Product_NGUYEN_KHANH_NINH.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
       
    }
}
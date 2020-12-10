﻿using System;
using System.Collections.Generic;
using System.Text;
using Common.Enums;

namespace Common.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public string MainImage { get; set; }
        public ProductStatus ProductStatus { get; set; }
        public int CategoryId { get; set; }
    }
}
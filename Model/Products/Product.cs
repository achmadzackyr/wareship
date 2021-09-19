﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Wareship.Authentication;
using Wareship.Model.Stocks;

namespace Wareship.Model.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double ChargeableWeight { get; set; }

        //Relationship
        public string UserId { get; set; }
        [JsonIgnore]
        public ApplicationUser User { get; set; }
        public int ProductStatusId { get; set; }
        [JsonIgnore]
        public ProductStatus ProductStatus { get; set; }
        public int SubCategoryId { get; set; }
        [JsonIgnore]
        public SubCategory SubCategory { get; set; }
        [JsonIgnore]
        public List<Stock> Stocks { get; set; }
        [JsonIgnore]
        public List<ProductImage> ProductImages { get; set; }
    }
}

﻿namespace StoreApi.Dtos.ProductDto
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public CategoryInProductDetailDto Category { get; set; }
    }

    public class CategoryInProductDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

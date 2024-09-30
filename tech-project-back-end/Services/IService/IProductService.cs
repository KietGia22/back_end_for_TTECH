﻿using tech_project_back_end.DTO;

namespace tech_project_back_end.Services.IService
{
    public interface IProductService
    {
        Task<List<TopSellerProductDTO>> GetTopSellerProducts(int count);
    }
}

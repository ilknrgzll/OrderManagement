﻿using Core.DataAccess;
using Entities;

namespace DataAccess.Abstract
{
	public interface IProductDal : IProductRepository<Product>
	{
	}
}

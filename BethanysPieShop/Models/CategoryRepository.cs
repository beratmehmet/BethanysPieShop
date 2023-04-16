﻿using System;

namespace BethanysPieShop.Models
{
	public class CategoryRepository: ICategoryRepository
	{
		BethanysPieShopDbContext _bethanysPieShopDbContext;
		public CategoryRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
		{
			_bethanysPieShopDbContext = bethanysPieShopDbContext;
		}

        public IEnumerable<Category> AllCategories
		{
			get
			{
				return _bethanysPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
			}
		}
    }
}


﻿using MusicStore.DataAccess.Interfaces;
using MusicStore.Models.DbModels;
using MusicStore.Web.Data;
using System.Linq;

namespace MusicStore.DataAccess.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext db;
        public CategoryRepository(ApplicationDbContext db):base(db)
        {
            this.db = db;
        }

        public void Update(Category category)
        {
            var data = db.Categories.FirstOrDefault(x => x.Id == category.Id);
            if (data != null)
                data.CategoryName = category.CategoryName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BoolKyBookMVCNet5.DataAcceess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var objFromDB = _db.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (objFromDB != null)
            {
                objFromDB.Name = category.Name;

            }


        }
    }
}

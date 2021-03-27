using System;
using System.Linq;
using BoolKyBookMVCNet5.DataAcceess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CoverType coverType)
        {
            var objFromDB = _db.CoverTypes.FirstOrDefault(c => c.Id == coverType.Id);
            if (objFromDB != null)
            {
                objFromDB.Name = coverType.Name;
            }
        }
    }
}

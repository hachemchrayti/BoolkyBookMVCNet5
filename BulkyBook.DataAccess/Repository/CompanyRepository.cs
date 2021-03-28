using System;
using System.Linq;
using BoolKyBookMVCNet5.DataAcceess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            var objFromDB = _db.Companies.FirstOrDefault(c => c.Id == company.Id);
            if (objFromDB != null)
            {
                objFromDB.Name = company.Name;

            }


        }
    }
}

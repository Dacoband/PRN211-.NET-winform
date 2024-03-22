using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects
{
    public class AirConditionerDAO
    {
        private static AirConditionerDAO instance = null;
        private static readonly object objLock = new object();
        private AirConditionerDAO() { }

        public static AirConditionerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AirConditionerDAO();
                }
                return instance;
            }
        }

        public List<AirConditioner> GetAirConditioners()
        {
            using var db = new AirConditionerShop2023DbContext();
            return db.AirConditioners.Include(f => f.Supplier).ToList();
        }

        public AirConditioner GetAirConditionerById(int? id)
        {
            var temp = GetAirConditioners()
            .SingleOrDefault(m => m.AirConditionerId == id);
            return temp;
        }
        public List<SupplierCompany> GetSupplierCompanies()
        {
            using var db = new AirConditionerShop2023DbContext();
            return db.SupplierCompanies.ToList();
        }

        public void SaveAirConditioner(AirConditioner a)
        {
            try
            {
                using var db = new AirConditionerShop2023DbContext();
                db.AirConditioners.Add(a);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateAirConditioner(AirConditioner a)
        {
            using var db = new AirConditionerShop2023DbContext();
            db.AirConditioners.Update(a);
            db.SaveChanges();
        }

        public void DeleteAirConditioner(AirConditioner a)
        {
            using var db = new AirConditionerShop2023DbContext();
            var a1 = db.AirConditioners.SingleOrDefault(m => m.AirConditionerId == a.AirConditionerId);
            db.AirConditioners.Remove(a1);
            db.SaveChanges();
        }
    }
}

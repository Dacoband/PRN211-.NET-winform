using BusinessObjects.Models;
using DataAccessObjects;

namespace Repositories
{
    public class AirConditionerRepository : IAirConditionerRepository
    {
        public void DeleteAirConditioner(AirConditioner airConditioner)
       => AirConditionerDAO.Instance.DeleteAirConditioner(airConditioner);

        public AirConditioner GetAirConditionerById(int id)
        => AirConditionerDAO.Instance.GetAirConditionerById(id);

        public List<AirConditioner> GetAirConditioners()
        => AirConditionerDAO.Instance.GetAirConditioners();


        public List<SupplierCompany> GetSupplierCompanies()
        => AirConditionerDAO.Instance.GetSupplierCompanies();

        public void SaveAirConditioner(AirConditioner airConditioner)
        => AirConditionerDAO.Instance.SaveAirConditioner(airConditioner);

        public void UpdateAirConditioner(AirConditioner airConditioner)
        => AirConditionerDAO.Instance.UpdateAirConditioner(airConditioner);
    }
}

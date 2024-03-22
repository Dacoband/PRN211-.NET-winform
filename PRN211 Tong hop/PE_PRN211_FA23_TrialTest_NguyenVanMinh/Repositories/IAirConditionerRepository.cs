using BusinessObjects.Models;
namespace Repositories
{
    public interface IAirConditionerRepository
    {
        List<AirConditioner> GetAirConditioners();

        List<SupplierCompany> GetSupplierCompanies();
        AirConditioner GetAirConditionerById(int id);
        void DeleteAirConditioner(AirConditioner airConditioner);
        void SaveAirConditioner(AirConditioner airConditioner);
        void UpdateAirConditioner(AirConditioner airConditioner);
    }

}
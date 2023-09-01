using DAL;
namespace BLL
{
    public class CustomerReposity
    {
        public string GetCustomer()
        {
            var DataAccess = new DataAccess();

            return DataAccess.GetData();
        }
    }
}

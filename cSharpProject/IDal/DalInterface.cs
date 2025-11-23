using Dto;

namespace IDal

{
    public interface DalInterface
    {

        ////Customers
        //List<Customer> GetAllCustomers();
        //Customer GetCustomerById(int id);
        //void AddCustomer(Customer customer);
        //void UpdateCustomer(Customer customer);
        //void DeleteCustomer(int id);

        //// Events
        Task<List<DtoEvent>> GetAllEvents();
        //Event GetEventById(int id);
        //void AddEvent(Event ev);
        //void UpdateEvent(Event ev);
        //void DeleteEvent(int id);

        //// Categories
        //List<Category> GetAllCategories();
        //Category GetCategoryById(int id);
        //void AddCategory(Category category);
        //void UpdateCategory(Category category);
        //void DeleteCategory(int id);

        //// Companies
        //List<Company> GetAllCompanies();
        //Company GetCompanyById(int id);
        //void AddCompany(Company company);
        //void UpdateCompany(Company company);
        //void DeleteCompany(int id);

        //// Purchases
        //List<Purchase> GetAllPurchases();
        //Purchase GetPurchaseById(int id);
        //void AddPurchase(Purchase purchase);
        //void UpdatePurchase(Purchase purchase);
        //void DeletePurchase(int id);

        //// PurchaseDetails
        //List<PurchaseDetail> GetPurchaseDetailsByPurchaseId(int purchaseId);
        //void AddPurchaseDetail(PurchaseDetail detail);
        //void UpdatePurchaseDetail(PurchaseDetail detail);
        //void DeletePurchaseDetail(int detailId);

    }
}

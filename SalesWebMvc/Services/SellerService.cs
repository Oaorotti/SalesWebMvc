using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _Context;

        public SellerService(SalesWebMvcContext context)
        {
            _Context = context;
        }

        public List<Seller> FindAll()
        {
            return _Context.Seller.ToList();
        }

        public Seller FindById(int id)
        {
            return _Context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _Context.Seller.Find(id);
            _Context.Seller.Remove(obj);
            _Context.SaveChanges();
        }

        public void Insert(Seller obj)
        {
            _Context.Add(obj);
            _Context.SaveChanges();
        }

    }
}

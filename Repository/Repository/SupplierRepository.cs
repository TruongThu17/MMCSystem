using Data.Models;
using DataAccess;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        public void CreatSupplier(Supplier a) => SupplierDAO.CreatSupplier(a);

        public Supplier FindSupplierById(int id) => SupplierDAO.FindSupplierById(id);

        public List<Supplier> GetSuppliers(int educationId) => SupplierDAO.GetSuppliers(educationId);

        public void UpdateSupplier(Supplier a) => SupplierDAO.UpdateSupplier(a);
    }
}

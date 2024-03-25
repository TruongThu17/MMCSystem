using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface ISupplierRepository
    {
        List<Supplier> GetSuppliers(int educationId);
        Supplier FindSupplierById(int id);
        void CreatSupplier(Supplier a);
        void UpdateSupplier(Supplier a);
    }
}

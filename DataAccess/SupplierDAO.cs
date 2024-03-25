using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SupplierDAO
    {
        public static List<Supplier> GetSuppliers(int educationId)
        {
            var listSuppliers = new List<Supplier>();
            try
            {
                using (var context = new MMCDbContext())
                {
                    listSuppliers = context.Suppliers.Where(x=>x.EducationId== educationId).ToList();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return listSuppliers;
        }
        public static Supplier FindSupplierById(int id)
        {
            Supplier p = new Supplier();
            try
            {
                using (var context = new MMCDbContext())
                {
                    p = context.Suppliers.SingleOrDefault(x => x.SupplierId == id);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void CreatSupplier(Supplier a)
        {
            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Suppliers.Add(a);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateSupplier(Supplier a)
        {

            try
            {
                using (var context = new MMCDbContext())
                {
                    context.Entry<Supplier>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}

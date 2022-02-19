using SupplierApplication.Models;
using SupplierApplication.Persistance;
using SupplierApplication.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierApplication.Repositories.Concretes
{
    public class SupplierRepository : ISupplierRepository<Supplier>
    {
        private readonly SupplierDbContex contex;

        public SupplierRepository(SupplierDbContex contex)
        {
            this.contex = contex;
        }
        public async Task<Supplier> Create(Supplier _object)
        {
            if (_object == null)
                throw new ArgumentNullException("Supplier cannot be null");
            var supplier = await contex.GetSuppliers.AddAsync(_object);
            contex.SaveChanges();
            return supplier.Entity;
        }

        public void Delete(Supplier _object)
        {
            var inspectionId = contex.GetSuppliers.FirstOrDefault(x => x.Id == _object.Id);
            if (inspectionId == null)
                throw new ArgumentNullException("Invalid Supplier");
            contex.Remove(inspectionId);
            contex.SaveChanges();
        }

        public IEnumerable<Supplier> GetAll()
        {
            return contex.GetSuppliers.ToList();
        }

        public Supplier GetById(int Id)
        {
            return contex.GetSuppliers.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Update(Supplier _object)
        {
            if (_object == null)
                throw new ArgumentNullException("Supplier cannot be null");
            var updateSupplier = contex.GetSuppliers.FirstOrDefault(x => x.Id == _object.Id);
            updateSupplier.Name = _object.Name;
            updateSupplier.Email = _object.Email;
            updateSupplier.Address = updateSupplier.Address;
            contex.SaveChanges();
        }
    }
}

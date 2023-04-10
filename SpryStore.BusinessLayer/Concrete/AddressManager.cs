using SpryStore.BusinessLayer.Abstract;
using SpryStore.DataAccessLayer.Abstract;
using SpryStore.DataAccessLayer.Migrations;
using SpryStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStore.BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void TDelete(Address t)
        {
            _addressDal.Delete(t);
        }

        public Address TGetByID(int id)
        {
            return _addressDal.GetByID(id);
        }

        public List<Address> TGetList()
        {
            return _addressDal.GetList();
        }

        public void TInsert(Address t)
        {
            _addressDal.Insert(t);
        }

        public void TUpdate(Address t)
        {
            _addressDal.Update(t);
        }
    }
}

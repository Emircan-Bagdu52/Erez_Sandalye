using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ProductImageManager : IProductImageService
	{
		IProductImageDal _productImageDal;

		public ProductImageManager(IProductImageDal productImageDal)
		{
			_productImageDal = productImageDal;
		}

		public void TAdd(ProductImage t)
		{
			_productImageDal.Insert(t);
		}

		public void TDelete(ProductImage t)
		{
			_productImageDal.Delete(t);
		}

		public ProductImage TGetByID(int id)
		{
			return _productImageDal.GetByID(id);
		}

		public List<ProductImage> TGetList()
		{
			return _productImageDal.GetListAll();
		}

		public void TUpdate(ProductImage t)
		{
			_productImageDal.Update(t);
		}
	}
}

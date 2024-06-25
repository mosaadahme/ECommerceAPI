using ECommerceApi.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ECommerceApi.Application.Features.Products.Exceptions
{
    public class ProductsTitleMustNotBeTheSameException:BaseException
    {
        public ProductsTitleMustNotBeTheSameException():base("This Title is already exist, try again with another title") { }


    }
}

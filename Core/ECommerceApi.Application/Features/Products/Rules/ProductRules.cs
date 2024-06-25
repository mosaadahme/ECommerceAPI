using ECommerceApi.Application.Bases;
using ECommerceApi.Application.Features.Products.Exceptions;
using ECommerceApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ECommerceApi.Application.Features.Products.Rules
{
    public class ProductRules:BaseRule
    {
        public Task ProductsTitleMustNotBeTheSame(IList<Product> products,string titleOfRequest)
        {
            if (products.Any(t => t.Title == titleOfRequest))
                  throw new ProductsTitleMustNotBeTheSameException();
            return Task.CompletedTask; 
        }


    }
}

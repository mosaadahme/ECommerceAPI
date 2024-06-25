using ECommerceApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class Detail : EntityBase
    {
        public Detail() { }


        public Detail(string title, string description, int categoryId)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}

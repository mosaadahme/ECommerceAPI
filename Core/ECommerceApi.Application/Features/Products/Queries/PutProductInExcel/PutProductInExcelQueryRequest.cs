using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Products.Queries.PutProductInExcel
{
    public class PutProductInExcelQueryRequest:IRequest<ActionResult>
    {
    }
}

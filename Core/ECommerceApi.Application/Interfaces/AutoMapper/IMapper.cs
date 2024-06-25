using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Interfaces.AutoMapper
{
    public interface IMapper
    {
        TDestnation Map<TDestnation, TSource>(TSource source, string? ignore = null);

        IList<TDestnation> Map<TDestnation, TSource>(IList<TSource> source, string? ignore = null);

        TDestnation Map<TDestnation>(object source, string? ignore = null);

        IList<TDestnation> Map<TDestnation>(IList<object> source, string? ignore = null);

    }
}

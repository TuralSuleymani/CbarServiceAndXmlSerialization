using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CbarService.Core
{
    public interface IExchangeService<T> where T : class
    {
        Task<T> GetExchangeDatasByDate(DateTime dateTime);
    }
}

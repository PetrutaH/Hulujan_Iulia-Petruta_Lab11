using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hulujan_Iulia_Petruta_Lab11.Models;




namespace Hulujan_Iulia_Petruta_Lab11.Data
{
    //internal interface IRestService
    //{
    //}

    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}

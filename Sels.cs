using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Идентификатор продажи
//Идентификатор продукта
//Количество проданных единиц
//Дата продажи

namespace linq
{
    record class Sell(int id, int productId, int count, string DataSell);
    
}

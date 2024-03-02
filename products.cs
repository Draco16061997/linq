using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Идентификатор(ID)
//Название
//Категорию
//Цену

namespace linq
{
    record class Product(int id, string Name, string Category, float cost);
    
}

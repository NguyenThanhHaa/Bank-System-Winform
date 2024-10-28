using Bank_System.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Bank_System.Controller
{
    internal interface IController
    {
      
        DataTable Load(); 

       
        bool Create(IModel model);

     
        bool Update(IModel model);

       
        bool Delete(object id);

      
        IModel Read(object id);

        
        bool IsExist(string id);

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ApiResult<T>
    {
        public T Result { get; set; }
        public bool IsSuccess { 
            
                get
                {
                    return !this.ErrorMessage.Any();
                }
            
            }
        public List<string> ErrorMessage = new List<string>();
    }
}
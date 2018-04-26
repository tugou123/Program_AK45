using Base.Commomet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace Author.API.Models
{
    public static class ModelStateExtensions
    {
        public static void AddDataValidationError(this ModelStateDictionary state,string errorMessage)
        {
            state.AddModelError("DataValidation", errorMessage);
        }

        public static WebApiResult toJsonError(this ModelStateDictionary state)
        {
            return new WebApiResult<object>
            {
                Code = 1,
                Message = "参数验证失败",
                Data = from e in state
                       where e.Value.Errors.Count > 0
                       select new
                       {
                           name = e.Key,
                           error = e.Value.Errors.Select(n => n.ErrorMessage)
                           .Concat(e.Value.Errors.Where(n => n.Exception != null).Select(n => n.Exception.Message))
                       },
                _other = new { Isvalid = state.IsValid }

            };
        }
    }
}
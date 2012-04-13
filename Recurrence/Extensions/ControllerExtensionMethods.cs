using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recurrence.Models;

namespace Recurrence
{
    public static class ControllerExtensionMethods
    {
        public static JsonNetResult ErrorResult(this Controller input)
        {
            return ErrorResult(input, "The input provided did not validate successfully");
        }
        public static JsonNetResult ErrorResult(this Controller input, string Message)
        {
            ResultModel result = new ResultModel();
            List<string> errors = new List<string>();
            if (input.ModelState.IsValid == false)
            {
                foreach (var e in input.ModelState.Where(r => r.Value.Errors.Count > 0))
                {

                    errors.Add
                    (
                        e.Key + " : " +
                        string.Join
                        (
                            ",",
                            e.Value.Errors.Select(r => r.ErrorMessage).ToArray()
                        )
                    );
                }
            }
            result.Errors = errors.ToArray();
            return new JsonNetResult(result);
        }
    }
}
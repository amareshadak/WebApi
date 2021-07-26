using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Helper
{
    public static class SerializedIdentityErrors
    {
        public static string GetIdentityError(IEnumerable<IdentityError> errors)
        {
            string errorStr = string.Empty;
            foreach (var error in errors)
            {
                if (string.IsNullOrEmpty(errorStr))
                {
                    errorStr = error.Description;
                }
                else
                {
                    errorStr += Environment.NewLine + error.Description;
                }
            }
            return errorStr;
        }
    }
}

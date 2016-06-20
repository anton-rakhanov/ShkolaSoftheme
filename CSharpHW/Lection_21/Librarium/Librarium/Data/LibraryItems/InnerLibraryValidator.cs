using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Librarium.Data.LibraryItems;

namespace Librarium.Data.LibraryItems
{
    public class InnerLibraryValidator
    {
        public bool IsLibraryItemValid(LibraryItem item)
        {

            var results = new List<ValidationResult>();
            var context = new ValidationContext(item);

            if (!Validator.TryValidateObject(item, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

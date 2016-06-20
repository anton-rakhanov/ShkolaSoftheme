using System;
using System.ComponentModel.DataAnnotations;
using Librarium.Data.LibraryItems;

namespace Librarium.Data.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class OnlyForViewingAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value is Journal)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

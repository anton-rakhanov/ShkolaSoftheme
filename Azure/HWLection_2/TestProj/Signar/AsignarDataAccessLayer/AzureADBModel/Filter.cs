//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsignarDataAccessLayer.AzureADBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Filter
    {
        public int FilterID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string FilterContent { get; set; }
        public byte[] Version { get; set; }
    
        public virtual User User { get; set; }
    }
}
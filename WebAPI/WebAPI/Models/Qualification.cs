//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Qualification
    {
        public string PassingYear { get; set; }
        public string Board { get; set; }
        public Nullable<int> Marks { get; set; }
        public Nullable<int> EmpCode { get; set; }
        public int Index { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}

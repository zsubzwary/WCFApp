//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppWCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class parent
    {
        public int par_id { get; set; }
        public Nullable<int> use_id { get; set; }
        public string CNIC { get; set; }
    
        public virtual user user { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Primer01
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMark
    {
        public int MarkID { get; set; }
        public int Mark { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> SubjectID { get; set; }
    
        public virtual tblStudent tblStudent { get; set; }
        public virtual tblSubject tblSubject { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATCQUIZ
{
    using System;
    using System.Collections.Generic;
    
    public partial class Questions_Tests
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public int TestID { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual Test Test { get; set; }
    }
}
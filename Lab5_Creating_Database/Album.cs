//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab5_Creating_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Released { get; set; }
        public string Sales { get; set; }
        public string AlbumImage { get; set; }
        public int BandId { get; set; }
    
        public virtual Band Band { get; set; }
    }
}

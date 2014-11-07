//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Models
{
    using Component.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    
    public partial class Route :Entity
    {
        [Key,MaxLength(40)]
        public string ROUTECODE { get; set; }
        [MaxLength(100)]
        public string ROUTEDESC { get; set; }
        [MaxLength(40),Required]
        public string ROUTETYPE { get; set; }
        [Required]
        public int EFFDATE { get; set; }
        [Required]
        public int IVLDATE { get; set; }
        [MaxLength(40),Required]
        public string MUSER { get; set; }
        [Required]
        public int MDATE { get; set; }
        [Required]
        public int MTIME { get; set; }
        [MaxLength(40)]
        public string EATTRIBUTE1 { get; set; }      
        public Nullable<int> ENABLED { get; set; }
        public virtual ICollection<Op> Ops { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Mo> Moes { get; set; }

    //    public virtual Route2Op route2Op { get; set; }
    }
}

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

    [Table("TBLITEM2SNCHECK")]
    public partial class Item2SnCheck:Entity
    {
        [MaxLength(40),Required]
        public string ITEMCODE { get; set; }
        [MaxLength(40)]

        public string SNPREFIX { get; set; }
        public Nullable<int> SNLENGTH { get; set; }
        [MaxLength(40), Required]

        public string MUSER { get; set; }
        [Required]
        public int MDATE { get; set; }
        [Required]
        public int MTIME { get; set; }
        [MaxLength(40)]

        public string EATTRIBUTE1 { get; set; }
        [MaxLength(40)]

        public string SNCONTENTCHECK { get; set; }
        [MaxLength(40)]

        public string TYPE { get; set; }
    }
}

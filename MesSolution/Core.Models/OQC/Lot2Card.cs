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
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TBLLOT2CARD")]
    public partial class Lot2Card
    {
        [MaxLength(40),Required]
        public string RCARD { get; set; }
        [MaxLength(40), Required]

        public string LOTNO { get; set; }
        [Required]
        public int LOTSEQ { get; set; }
        [MaxLength(40), Required]

        public string MOCODE { get; set; }
        public Nullable<int> RCARDSEQ { get; set; }
        [MaxLength(40), Required]

        public string MODELCODE { get; set; }
        [MaxLength(40), Required]

        public string ITEMCODE { get; set; }
        [MaxLength(40), Required]

        public string ROUTECODE { get; set; }
        [MaxLength(40), Required]

        public string OPCODE { get; set; }
        [MaxLength(40), Required]

        public string SEGCODE { get; set; }
        [MaxLength(40), Required]

        public string SSCODE { get; set; }
        [MaxLength(40), Required]

        public string RESCODE { get; set; }
        [MaxLength(40), Required]

        public string SHIFTTYPECODE { get; set; }
        [MaxLength(40), Required]

        public string SHIFTCODE { get; set; }
        [MaxLength(40), Required]

        public string TPCODE { get; set; }
        [MaxLength(40), Required]

        public string STATUS { get; set; }
        [MaxLength(40), Required]

        public string MUSER { get; set; }
        [Required]
        public int MDATE { get; set; }
        [Required]
        public int MTIME { get; set; }
        [MaxLength(40)]
        
        public string EATTRIBUTE1 { get; set; }
        [MaxLength(40)]

        public string COLLECTTYPE { get; set; }
        public Nullable<int> MOSEQ { get; set; }
    }
}

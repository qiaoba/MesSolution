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

   
    public partial class ItemRoute2Op 
    {
        [Key,MaxLength(100)]
        public string OPID { get; set; }
        [MaxLength(40),Required]
        public string ROUTECODE { get; set; }
        [MaxLength(40), Required]
        public string OPCODE { get; set; }
        [Required]
        public int OPSEQ { get; set; }
        [MaxLength(40), Required]
        public string OPCONTROL { get; set; }
        [MaxLength(40), Required]
        public string IDMERGETYPE { get; set; }
        [Required]
        public int IDMERGERULE { get; set; }
        [MaxLength(40), Required]

        public string MUSER { get; set; }
        [Required]
        public int MDATE { get; set; }
        [Required]
        public int MTIME { get; set; }
        [MaxLength(40)]
        public string EATTRIBUTE1 { get; set; }
        [MaxLength(40), Required]
        public string ITEMCODE { get; set; }
        [MaxLength(40)]
        public string OPTIONALOP { get; set; }
        [MaxLength(22),Required]
        public string ORGID { get; set; }
    }
}
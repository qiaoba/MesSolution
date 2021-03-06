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
  
    public partial class Sbom 
    {
        [MaxLength(40),Required]
        public string ITEMCODE { get; set; }
        [MaxLength(40), Required]
        public string SBITEMCODE { get; set; }
        [MaxLength(40), Required]
        public string SBSITEMCODE { get; set; }
        [Required]
        public int SBITEMQTY { get; set; }
        [Required]
        public int SBITEMEFFDATE { get; set; }
        [MaxLength(40)]
        public string SBWH { get; set; }
        public Nullable<int> SEQ { get; set; }
        [MaxLength(40)]
        public string SBITEMECN { get; set; }
        [MaxLength(100)]
        public string SBITEMNAME { get; set; }
        [MaxLength(100)]
        public string SBITEMDESC { get; set; }
        [MaxLength(1),Required]
        public string SBITEMSTATUS { get; set; }
        [MaxLength(100)]
        public string SBITEMLOCATION { get; set; }
        [Required]
        public int SBITEMEFFTIME { get; set; }
        [Required]
        public int SBITEMINVDATE { get; set; }
        [Required]
        public int SBITEMINVTIME { get; set; }
        [MaxLength(40)]
        public string SBITEMUOM { get; set; }
        [MaxLength(40)]
        public string SBITEMVER { get; set; }
        [MaxLength(40)]
        public string SBITEMCONTYPE { get; set; }
        [MaxLength(40)]
        public string SBPITEMCODE { get; set; }
        [MaxLength(10)]
        public string ALPGR { get; set; }
        [MaxLength(40),Required]
        public string MUSER { get; set; }
        [Required]
        public int MDATE { get; set; }
        [Required]
        public int MTIME { get; set; }
        [MaxLength(40)]
        public string EATTRIBUTE1 { get; set; }
        [MaxLength(22),Required]
        public string ORGID { get; set; }
        [MaxLength(40)]

        public string ITEMDESC { get; set; }
        [MaxLength(40),Required]
        public string SBFACTORY { get; set; }
        [MaxLength(40)]
        public string SBUSAGE { get; set; }
        [MaxLength(40), Required]
        public string SBITEMPROJECT { get; set; }
        [MaxLength(40), Required]
        public string SBITEMSEQ { get; set; }
        [MaxLength(40), Required]
        public string SBOMVER { get; set; }
        [MaxLength(40)]
        public string LOCATION { get; set; }
    }
}

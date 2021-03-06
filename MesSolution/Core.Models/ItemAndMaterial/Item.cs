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

    
    public partial class Item:Entity
    {
        [Key,MaxLength(40)]
        public string ITEMCODE { get; set; }
        [MaxLength(100)]
        public string ITEMNAME { get; set; }
        [MaxLength(100)]
        public string ITEMDESC { get; set; }
        [MaxLength(40)]
        public string ITEMUOM { get; set; }
        [MaxLength(40)]
        public string ITEMVER { get; set; }
        [MaxLength(40),Required]
        public string ITEMTYPE { get; set; }
        [MaxLength(40)]
        public string ITEMCONTROL { get; set; }
        [MaxLength(40),Required]
        public string ITEMUSER { get; set; }
        [Required]
        public int ITEMDATE { get; set; }
        [MaxLength(40),Required]
        public string MUSER { get; set; }
        [Required]
        public int MDATE { get; set; }
        [Required]
        public int MTIME { get; set; }
        [MaxLength(40)]
        public string EATTRIBUTE1 { get; set; }
        [MaxLength(40)]
        public string ITEMCONFIG { get; set; }
        [MaxLength(40)]
        public string ITEMCARTONQTY { get; set; }
        public Nullable<int> ITEMBURNINQTY { get; set; }
                             
        public Nullable<int> ELECTRICCURRENTMINVALUE { get; set; }
        public Nullable<int> ELECTRICCURRENTMAXVALUE { get; set; }
        public Nullable<int> SHIPBOXCAPACITY { get; set; }
        [MaxLength(40)]
        public string PKRULECODE { get; set; }
        [MaxLength(22),Required]
        public string ORGID { get; set; }
        [MaxLength(40)]
        public string CHKITEMOP { get; set; }

        public Nullable<int> LOTSIZE { get; set; }
        [MaxLength(100)]
        public string PRODUCTCODE { get; set; }
        [MaxLength(40)]
        public string NEEDCHKCARTON { get; set; }
        [MaxLength(40)]
        public string NEEDCHKACCESSORY { get; set; }
        [MaxLength(40)]
        public string CKDPREFIX { get; set; }
        public Nullable<int> CARTONHEIGHT { get; set; }
        public Nullable<int> ALLOWHEIGHT { get; set; }
        [MaxLength(100)]
        public string PRINTLABEL { get; set; }

        public virtual Model Model { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
    }
}

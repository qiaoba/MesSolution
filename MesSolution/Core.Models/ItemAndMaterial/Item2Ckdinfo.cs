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

   
    public partial class Item2Ckdinfo
    {
        [Key,MaxLength(40)]
        public string ITEMCODE { get; set; }
        [MaxLength(22),Required]
        public string ORGID { get; set; }
        [MaxLength(100)]
        public string TOCOUNTRY { get; set; }
        [MaxLength(100)]
        public string BRAND { get; set; }
        [MaxLength(100)]
        public string SUPPLY { get; set; }
        [MaxLength(100)]
        public string CUSTOMERNAME { get; set; }
        [MaxLength(100)]
        public string CUSTOMERADDRESS { get; set; }
        [MaxLength(100)]
        public string HISENSEORDER { get; set; }
        [MaxLength(100)]
        public string CUSTOMERORDER { get; set; }
        [MaxLength(100)]
        public string HISENSEMODEL { get; set; }
        [MaxLength(100)]
        public string CUSTOMERMODEL { get; set; }
    }
}

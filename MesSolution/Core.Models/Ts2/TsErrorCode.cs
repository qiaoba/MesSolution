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

  
    public partial class  TsErrorCode:Entity
    {

        public Int64 TsErrorCodeID { get; set; }
       
        [MaxLength(40), Required]

        public string muser { get; set; }
        [Required]
        public int mdate { get; set; }
        [Required]
        public int mtime { get; set; }       

        public virtual Ts ts { get; set; }
        public virtual ICollection<TsErrorCause> tsErrorCauses { get; set; }
        public virtual ErrorCode errorCode { get; set; }
    }
}

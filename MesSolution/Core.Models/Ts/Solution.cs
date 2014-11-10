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

    [Table("TBLSOLUTION")]
    public partial class Solution:Entity
    {
        [Key,MaxLength(40)]
        public string SOLCODE { get; set; }
        [MaxLength(100)]
        public string SOLDESC { get; set; }
        [MaxLength(100)]
        public string SOLIMP { get; set; }
        [MaxLength(40),Required]
        public string MUSER { get; set; }
        [Required]
        public int MDATE { get; set; }
        [Required]
        public int MTIME { get; set; }
        [MaxLength(40)]
        public string EATTRIBUTE1 { get; set; }

        public virtual ICollection<Model> models { get; set; }
    }
}

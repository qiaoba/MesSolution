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

    public partial class Simulation:Entity
    {        
        public Int64 SimulationId { get; set; }
        [MaxLength(40),Required]
        public string RCARD { get; set; }
        [MaxLength(40), Required]

        public string MOCODE { get; set; }
        public Nullable<int> RCARDSEQ { get; set; }
        [MaxLength(40), Required]

        public string TCARD { get; set; }
        public Nullable<int> TCARDSEQ { get; set; }
        [MaxLength(40), Required]

        public string SCARD { get; set; }
        public Nullable<int> SCARDSEQ { get; set; }
        [MaxLength(40), Required]

        public string MODELCODE { get; set; }
        [MaxLength(40), Required]

        public string ITEMCODE { get; set; }
        [MaxLength(40)]

        public string FROMROUTE { get; set; }
        [MaxLength(40)]

        public string FROMOP { get; set; }
        [MaxLength(40)]

        public string ROUTECODE { get; set; }
        [MaxLength(40)]

        public string OpCode { get; set; }
        [MaxLength(40)]

        public string RESCODE { get; set; }
        public Nullable<int> IDMERGERULE { get; set; }
        [MaxLength(40)]

        public string LOTNO { get; set; }
        [MaxLength(40)]

        public string CARTONCODE { get; set; }
        [MaxLength(40)]

        public string PALLETCODE { get; set; }
        [MaxLength(40),Required]

        public string PRODUCTSTATUS { get; set; }
        [MaxLength(40),Required]

        public string LACTION { get; set; }
        [MaxLength(40)]

        public string ACTIONLIST { get; set; }
        public Nullable<int> NGTIMES { get; set; }
        [MaxLength(40)]

        public string ISCOM { get; set; }
        [MaxLength(40)]

        public string EATTRIBUTE1 { get; set; }
        [MaxLength(40),Required]

        public string MUSER { get; set; }
        public Nullable<int> MDATE { get; set; }
        public Nullable<int> MTIME { get; set; }
        [MaxLength(40)]

        public string EATTRIBUTE2 { get; set; }
        public Nullable<int> ISHOLD { get; set; }
        [MaxLength(40)]

        public string SHELFNO { get; set; }
        [MaxLength(40)]

        public string RMABILLCODE { get; set; }
        public Nullable<int> MOSEQ { get; set; }
        [MaxLength(40)]

        public string MACHINETYPE { get; set; }
    }
}

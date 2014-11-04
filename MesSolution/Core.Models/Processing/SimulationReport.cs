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
   
    public partial class SimulationReport:Entity
    {
        public Int64 SimulationReportID { get; set; }

        [MaxLength(40), Required]
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

        public string OPCODE { get; set; }
        [MaxLength(40)]

        public string RESCODE { get; set; }
        public Nullable<int> IDMERGERULE { get; set; }
        [MaxLength(40)]

        public string LOTNO { get; set; }
        [MaxLength(40)]

        public string CARTONCODE { get; set; }
        [MaxLength(40)]

        public string PALLETCODE { get; set; }
        [MaxLength(40), Required]

        public string PRODUCTSTATUS { get; set; }
        [MaxLength(40), Required]

        public string LACTION { get; set; }
        [MaxLength(40)]

        public string ACTIONLIST { get; set; }
        public Nullable<int> NGTIMES { get; set; }
        [MaxLength(40)]

        public string ISCOM { get; set; }
        [MaxLength(40)]

        public string EATTRIBUTE1 { get; set; }
        [MaxLength(40), Required]

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
        public SimulationReport()
        {

        }
        public SimulationReport(Simulation simulation)
        {
            
            ACTIONLIST = simulation.ACTIONLIST;
            CARTONCODE=simulation.CARTONCODE;
            EATTRIBUTE1=simulation.EATTRIBUTE1;
            EATTRIBUTE2=simulation.EATTRIBUTE2;
            FROMOP=simulation.FROMOP;
            FROMROUTE=simulation.FROMROUTE;
            IDMERGERULE=simulation.IDMERGERULE;
            ISCOM=simulation.ISCOM;
            ISHOLD=simulation.ISHOLD;
            ITEMCODE=simulation.ITEMCODE;
            LACTION=simulation.LACTION;
            LOTNO=simulation.LOTNO;
            MACHINETYPE=simulation.MACHINETYPE;
            MDATE=simulation.MDATE;
            MOCODE=simulation.MOCODE;
            MODELCODE=simulation.MODELCODE;
            MOSEQ=simulation.MOSEQ;
            MTIME=simulation.MTIME;
            MUSER=simulation.MUSER;
            NGTIMES=simulation.NGTIMES;
            OPCODE=simulation.OPCODE;
            PALLETCODE=simulation.PALLETCODE;
            PRODUCTSTATUS=simulation.PRODUCTSTATUS;
            RCARD=simulation.RCARD;
            RCARDSEQ=simulation.RCARDSEQ;
            RESCODE=simulation.RESCODE;
            RMABILLCODE=simulation.RMABILLCODE;
            ROUTECODE=simulation.ROUTECODE;
            SCARD=simulation.SCARD;
            SCARDSEQ=simulation.SCARDSEQ;
            SHELFNO=simulation.SHELFNO;
            TCARD=simulation.TCARD;
            TCARDSEQ=simulation.TCARDSEQ;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using CardChequeModule.Models.MetaData;

namespace CardChequeModule.Models
{
    using System;
    using System.Collections.Generic;

    [MetadataType(typeof(CardChTranMeta))]
    public partial class CARDCHTRAN
    {
        public long ID { get; set; }
        public long CHEQUELEAFID { get; set; }
        public string CARDNO { get; set; }
        public string CARDHOLDERNAME { get; set; }
        public Nullable<long> BRANCHCODE { get; set; }
        public System.DateTime REQUESTDATE { get; set; }
        public string BENEFICIARINFO { get; set; }
        public decimal AMOUNT { get; set; }
        public bool ISSIGNATUREVERIFIED { get; set; }
        public long STATUS { get; set; }
        public string APPROVALNO { get; set; }
        public bool ISACTIVE { get; set; }
        public Nullable<long> CREATEDBY { get; set; }
        public System.DateTime CREATEDON { get; set; }
        public Nullable<long> MODIFIEDBY { get; set; }
        public Nullable<System.DateTime> MODIFIEDON { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
        public Nullable<long> AUTHORIZEDBY { get; set; }
        public Nullable<System.DateTime> AUTHORIZEDON { get; set; }
        public string REMARKS { get; set; }
    
        public virtual BRANCHINFO BRANCHINFO { get; set; }
        public virtual BRANCHINFO BRANCHINFO1 { get; set; }
        public virtual CARDCHLEAF CARDCHLEAF { get; set; }
        public virtual OCCENUMERATION OCCENUMERATION { get; set; }
        public virtual OCCUSER OCCUSER { get; set; }
        public virtual OCCUSER OCCUSER1 { get; set; }
        public virtual OCCUSER OCCUSER2 { get; set; }
    }
}

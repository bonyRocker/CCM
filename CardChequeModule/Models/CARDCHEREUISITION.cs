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

    [MetadataType(typeof(ChequeRequisitionMeta))]
    public partial class CARDCHEREUISITION
    {

        public CARDCHEREUISITION()
        {
            this.CARDCHLEAF = new HashSet<CARDCHLEAF>();
        }

        public long ID { get; set; }
        public string CARDNO { get; set; }
        public long BRANCHCODE { get; set; }
        public long STATUS { get; set; }
        public int LEAFNO { get; set; }
        public string LEAFFROM { get; set; }
        public string LEAFTO { get; set; }
        public Nullable<long> LEAFNEXT { get; set; }
        public string REMARKS { get; set; }
        public bool ISACTIVE { get; set; }
        public long CREATEDBY { get; set; }
        public System.DateTime CREATEDON { get; set; }
        public Nullable<long> AUTHORIZEDBY { get; set; }
        public Nullable<System.DateTime> AUTHORIZEDON { get; set; }
        public string REFERENCENO { get; set; }
        public Nullable<long> ESTABLISHMENTBY { get; set; }
        public Nullable<System.DateTime> ESTABLISHMENTON { get; set; }
        public Nullable<long> CALLCENTERBY { get; set; }
        public Nullable<System.DateTime> CALLCENTERON { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
        public Nullable<long> MODIFIEDBY { get; set; }
        public Nullable<System.DateTime> MODIFIEDON { get; set; }
        public Nullable<long> DELIVEREDBY { get; set; }
        public Nullable<System.DateTime> DELIVEREDON { get; set; }

        public virtual BRANCHINFO BRANCHINFO { get; set; }
        public virtual OCCENUMERATION OCCENUMERATION { get; set; }
        public virtual OCCUSER OCCUSER { get; set; }
        public virtual OCCUSER OCCUSER1 { get; set; }
        public virtual OCCUSER OCCUSER2 { get; set; }
        public virtual OCCUSER OCCUSER3 { get; set; }
        public virtual OCCUSER OCCUSER4 { get; set; }
        public virtual OCCUSER OCCUSER5 { get; set; }
        public virtual ICollection<CARDCHLEAF> CARDCHLEAF { get; set; }
    }
}

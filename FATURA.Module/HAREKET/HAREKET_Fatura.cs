using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using FATURA.Module.TANIMLAR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FATURA.Module.HAREKETLER
{
    [DefaultClassOptions]
    [DefaultProperty("FaturaNo")]
    [NavigationItem("Hareketler")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class HAREKET_Fatura : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public HAREKET_Fatura(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        private TANIMLAR_Firma _firmaadi;

        public TANIMLAR_Firma FirmaAdi
        {
            get
            {
                return _firmaadi;
            }
            set
            {
                SetPropertyValue(nameof(FirmaAdi), ref _firmaadi, value);
            }
        }
        private string _fatura_no;[Size(10)]
        public string FaturaNo
        { 
            get
            {
                return _fatura_no;
            }
            set
            {
                SetPropertyValue(nameof(FaturaNo), ref _fatura_no, value);
            }
        }
        private DateTime _fatura_tarih;
        public DateTime FaturaTarih
        {
            get
            {
                return _fatura_tarih;
            }
            set
            {
                SetPropertyValue(nameof(FaturaTarih), ref _fatura_tarih, value);
            }
        }
        [Association("HAREKET_FaturaDetay")]
        public XPCollection<HAREKET_FaturaDetay>Faturalar
        {
            get
            {
                return GetCollection<HAREKET_FaturaDetay>(nameof(Faturalar));
            }
        }

        /*[Association("HAREKET_FaturaDetay")]
        public XPCollection<HAREKET_FaturaDetay> Iletisimler3
        {
            get
            {
                return GetCollection<HAREKET.HAREKET_FaturaDetay>(nameof(Iletisimler3));
            }


        }*/



        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}
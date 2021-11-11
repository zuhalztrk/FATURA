using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FATURA.Module.HAREKETLER
{
    [DefaultClassOptions]
    [NavigationItem("Hareketler")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class HAREKET_FaturaDetay : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public HAREKET_FaturaDetay(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        private HAREKET_Fatura  _fatura_no;
        [Association("HAREKET_FaturaDetay")]

        public HAREKET_Fatura FaturaNo
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
        private TANIMLAR.TANIMLAR_Stok _stok_id;

        public TANIMLAR.TANIMLAR_Stok StokID
        {
            get
            {
                return _stok_id;
            }
            set
            {
                SetPropertyValue(nameof(StokID), ref _stok_id, value);
            }
        }
        private decimal _stok_birim_fiyati;
        public decimal BirimFiyati
        {
            get
            {
                return _stok_birim_fiyati;
            }
            set
            {
                SetPropertyValue(nameof(BirimFiyati), ref _stok_birim_fiyati, value);
            }
        }
        private decimal _stok_kdv;
        public decimal KDV
        {
            get
            {
                return _stok_kdv;
            }
            set
            {
                SetPropertyValue(nameof(KDV), ref _stok_kdv, value);
            }
        }
        private decimal _stok_miktari;
        public decimal Miktar
        {
            get
            {
                return _stok_miktari;
            }
            set
            {
                SetPropertyValue(nameof(Miktar), ref _stok_miktari, value);
            }
        }
        private decimal _fiyat_tutar;

        public decimal FiyatTutari
        {
            get
            {
                return _fiyat_tutar;
            }
            set
            {
                SetPropertyValue(nameof(FiyatTutari), ref _fiyat_tutar, value);
            }
        }
        private decimal _kdv_tutar;

        public decimal KDVFiyatTutari
        {
            get
            {
                return _kdv_tutar;
            }
            set
            {
                SetPropertyValue(nameof(KDVFiyatTutari), ref _kdv_tutar, value);
            }
        }






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

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == "StokID")
            {
                BirimFiyati = StokID.StokFiyati;

                KDV = StokID.StokKDV;

              

            }
            if(propertyName == "Miktar")
            {
                FiyatTutari = BirimFiyati * Miktar;

                KDVFiyatTutari = FiyatTutari*(1+(KDV/100)) ;
            }
           
        }
    }
}
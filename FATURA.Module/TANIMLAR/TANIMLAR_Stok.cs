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

namespace FATURA.Module.TANIMLAR
{
    [DefaultClassOptions]
    [DefaultProperty("StokID")]
    [NavigationItem("Tanımlar")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class TANIMLAR_Stok : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public TANIMLAR_Stok(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        
        private string _stok_id;[Size(50)]
        public string StokID
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
        private string _stok_ad;[Size(100)]
        public string StokAd
        {
            get
            {
                return _stok_ad;
            }
            set
            {
                SetPropertyValue(nameof(StokAd), ref _stok_ad, value);
            }
        }
        private decimal _stok_fiyati;
        public decimal StokFiyati
        {
            get
            {
                return _stok_fiyati;
            }
            set
            {
                SetPropertyValue(nameof(StokFiyati), ref _stok_fiyati, value);
            }
        }
        private decimal _stok_kdv;
        public decimal StokKDV
        {
            get
            {
                return _stok_kdv;
            }
            set
            {
                SetPropertyValue(nameof(StokKDV), ref _stok_kdv, value);
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
    }
}
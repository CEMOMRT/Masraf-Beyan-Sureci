//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.1.32
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bimser.CSP.FormControls.Entities;
using Bimser.Framework.Attributes.Database;
using Bimser.Framework.Domain;
using Bimser.Framework.Domain.Entities;

namespace stj1_masraf_beyan_sureci.Entities {
    
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Masraf_harcama")]
    public class E_stj1_masraf_beyan_sureci_Masraf_harcamaEntity : FormEntity<E_stj1_masraf_beyan_sureci_Masraf_harcamaEntity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _kisiMaksOdeme;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _odencekTutar;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _NBkisiSayisi;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<System.DateTimeOffset>> _masrafTarihi;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _masrafTutari;
        
        private E_stj1_masraf_beyan_sureci_Masraf_harcamaVREntity _VersionEntity;
        
        private RDEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaRDEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaRDMLEntity> _RD;
        
        private RDCEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCMLEntity> _RDC;
        
        private MLEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaMLEntity> _ML;
        
        private SLEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaSLEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaSLMLEntity> _SL;
        
        public E_stj1_masraf_beyan_sureci_Masraf_harcamaEntity() {
            this.ML = new MLEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaMLEntity>();
            this.VersionEntity = new E_stj1_masraf_beyan_sureci_Masraf_harcamaVREntity();
            this.RD = new RDEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaRDEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaRDMLEntity>();
            this.RDC = new RDCEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCMLEntity>();
            this.SL = new SLEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaSLEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaSLMLEntity>();
        }
        
        [ColumnOptionsAttribute(Name="kisiMaksOdeme", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> kisiMaksOdeme {
            get {
                return this._kisiMaksOdeme;
            }
            set {
                this._kisiMaksOdeme = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="odencekTutar", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> odencekTutar {
            get {
                return this._odencekTutar;
            }
            set {
                this._odencekTutar = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="NBkisiSayisi", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> NBkisiSayisi {
            get {
                return this._NBkisiSayisi;
            }
            set {
                this._NBkisiSayisi = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="masrafTarihi", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<System.DateTimeOffset>> masrafTarihi {
            get {
                return this._masrafTarihi;
            }
            set {
                this._masrafTarihi = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="masrafTutari", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> masrafTutari {
            get {
                return this._masrafTutari;
            }
            set {
                this._masrafTutari = value;
            }
        }
        
        public E_stj1_masraf_beyan_sureci_Masraf_harcamaVREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaRDEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaRDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public MLEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaMLEntity> ML {
            get {
                return this._ML;
            }
            set {
                this._ML = value;
            }
        }
        
        public SLEntityCollection<E_stj1_masraf_beyan_sureci_Masraf_harcamaSLEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaSLMLEntity> SL {
            get {
                return this._SL;
            }
            set {
                this._SL = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Masraf_harcamaML")]
    public class E_stj1_masraf_beyan_sureci_Masraf_harcamaMLEntity : MLEntity<E_stj1_masraf_beyan_sureci_Masraf_harcamaMLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _masrafAciklama;
        
        [ColumnOptionsAttribute(Name="masrafAciklama", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> masrafAciklama {
            get {
                return this._masrafAciklama;
            }
            set {
                this._masrafAciklama = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Masraf_harcamaSL")]
    public class E_stj1_masraf_beyan_sureci_Masraf_harcamaSLEntity : SLEntity<E_stj1_masraf_beyan_sureci_Masraf_harcamaSLEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaSLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Masraf_harcamaSLML")]
    public class E_stj1_masraf_beyan_sureci_Masraf_harcamaSLMLEntity : SLMLEntity<E_stj1_masraf_beyan_sureci_Masraf_harcamaSLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Masraf_harcamaVR")]
    public class E_stj1_masraf_beyan_sureci_Masraf_harcamaVREntity : VersionEntity<E_stj1_masraf_beyan_sureci_Masraf_harcamaVREntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Masraf_harcamaRDC")]
    public class E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCEntity : RDCEntity<E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCML")]
    public class E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCMLEntity : RDCMLEntity<E_stj1_masraf_beyan_sureci_Masraf_harcamaRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Masraf_harcamaRD")]
    public class E_stj1_masraf_beyan_sureci_Masraf_harcamaRDEntity : RDEntity<E_stj1_masraf_beyan_sureci_Masraf_harcamaRDEntity, E_stj1_masraf_beyan_sureci_Masraf_harcamaRDMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Masraf_harcamaRDML")]
    public class E_stj1_masraf_beyan_sureci_Masraf_harcamaRDMLEntity : RDMLEntity<E_stj1_masraf_beyan_sureci_Masraf_harcamaRDMLEntity> {
    }
}





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
    
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1")]
    public class E_stj1_masraf_beyan_sureci_Form1Entity : FormEntity<E_stj1_masraf_beyan_sureci_Form1Entity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _toplamMasraf;
        
        private Bimser.Framework.Domain.DataField<string> _UserMetadata1;
        
        private E_stj1_masraf_beyan_sureci_Form1VREntity _VersionEntity;
        
        private RDEntityCollection<E_stj1_masraf_beyan_sureci_Form1RDEntity, E_stj1_masraf_beyan_sureci_Form1RDMLEntity> _RD;
        
        private RDCEntityCollection<E_stj1_masraf_beyan_sureci_Form1RDCEntity, E_stj1_masraf_beyan_sureci_Form1RDCMLEntity> _RDC;
        
        private MLEntityCollection<E_stj1_masraf_beyan_sureci_Form1MLEntity> _ML;
        
        private GridEntityCollection<E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloMLEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLMLEntity> _E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTablo;
        
        public E_stj1_masraf_beyan_sureci_Form1Entity() {
            this.ML = new MLEntityCollection<E_stj1_masraf_beyan_sureci_Form1MLEntity>();
            this.VersionEntity = new E_stj1_masraf_beyan_sureci_Form1VREntity();
            this.RD = new RDEntityCollection<E_stj1_masraf_beyan_sureci_Form1RDEntity, E_stj1_masraf_beyan_sureci_Form1RDMLEntity>();
            this.RDC = new RDCEntityCollection<E_stj1_masraf_beyan_sureci_Form1RDCEntity, E_stj1_masraf_beyan_sureci_Form1RDCMLEntity>();
            this.E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTablo = new GridEntityCollection<E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloMLEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLMLEntity>();
            this.E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTablo.MLEntityEnabled = false;
            this.E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTablo.SLEntityEnabled = false;
        }
        
        [ColumnOptionsAttribute(Name="toplamMasraf", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> toplamMasraf {
            get {
                return this._toplamMasraf;
            }
            set {
                this._toplamMasraf = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="UserMetadata1", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> UserMetadata1 {
            get {
                return this._UserMetadata1;
            }
            set {
                this._UserMetadata1 = value;
            }
        }
        
        public E_stj1_masraf_beyan_sureci_Form1VREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_stj1_masraf_beyan_sureci_Form1RDEntity, E_stj1_masraf_beyan_sureci_Form1RDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_stj1_masraf_beyan_sureci_Form1RDCEntity, E_stj1_masraf_beyan_sureci_Form1RDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public MLEntityCollection<E_stj1_masraf_beyan_sureci_Form1MLEntity> ML {
            get {
                return this._ML;
            }
            set {
                this._ML = value;
            }
        }
        
        public GridEntityCollection<E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloMLEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLMLEntity> E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTablo {
            get {
                return this._E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTablo;
            }
            set {
                this._E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTablo = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1ML")]
    public class E_stj1_masraf_beyan_sureci_Form1MLEntity : MLEntity<E_stj1_masraf_beyan_sureci_Form1MLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _TextBox2;
        
        private Bimser.Framework.Domain.DataField<string> _UserMetadata2;
        
        [ColumnOptionsAttribute(Name="TextBox2", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> TextBox2 {
            get {
                return this._TextBox2;
            }
            set {
                this._TextBox2 = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="UserMetadata2", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> UserMetadata2 {
            get {
                return this._UserMetadata2;
            }
            set {
                this._UserMetadata2 = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTablo")]
    public class E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloEntity : GridEntity<E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloMLEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLMLEntity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _RELATIONDOCUMENTID;
        
        public E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloEntity() {
        }
        
        [ColumnOptionsAttribute(Name="RELATIONDOCUMENTID", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> RELATIONDOCUMENTID {
            get {
                return this._RELATIONDOCUMENTID;
            }
            set {
                this._RELATIONDOCUMENTID = value;
            }
        }
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloML")]
    public class E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloMLEntity : GridMLEntity<E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSL")]
    public class E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLEntity : GridSLEntity<E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLEntity, E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLML")]
    public class E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLMLEntity : GridSLMLEntity<E_stj1_masraf_beyan_sureci_Form1_masrafBeyanTabloSLMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1VR")]
    public class E_stj1_masraf_beyan_sureci_Form1VREntity : VersionEntity<E_stj1_masraf_beyan_sureci_Form1VREntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1RDC")]
    public class E_stj1_masraf_beyan_sureci_Form1RDCEntity : RDCEntity<E_stj1_masraf_beyan_sureci_Form1RDCEntity, E_stj1_masraf_beyan_sureci_Form1RDCMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1RDCML")]
    public class E_stj1_masraf_beyan_sureci_Form1RDCMLEntity : RDCMLEntity<E_stj1_masraf_beyan_sureci_Form1RDCMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1RD")]
    public class E_stj1_masraf_beyan_sureci_Form1RDEntity : RDEntity<E_stj1_masraf_beyan_sureci_Form1RDEntity, E_stj1_masraf_beyan_sureci_Form1RDMLEntity> {
    }
    
    [TableOptions(TableName="E_stj1_masraf_beyan_sureci_Form1RDML")]
    public class E_stj1_masraf_beyan_sureci_Form1RDMLEntity : RDMLEntity<E_stj1_masraf_beyan_sureci_Form1RDMLEntity> {
    }
}





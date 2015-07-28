﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("EventosModel", "fk_tipo_evento", "tipos_evento", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(ToastNotifications.Entity.tipos_evento), "eventos", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ToastNotifications.Entity.eventos), true)]

#endregion

namespace ToastNotifications.Entity
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class EventosEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto EventosEntities usando la cadena de conexión encontrada en la sección 'EventosEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public EventosEntities() : base("name=EventosEntities", "EventosEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto EventosEntities.
        /// </summary>
        public EventosEntities(string connectionString) : base(connectionString, "EventosEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto EventosEntities.
        /// </summary>
        public EventosEntities(EntityConnection connection) : base(connection, "EventosEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<tipos_evento> tipos_evento
        {
            get
            {
                if ((_tipos_evento == null))
                {
                    _tipos_evento = base.CreateObjectSet<tipos_evento>("tipos_evento");
                }
                return _tipos_evento;
            }
        }
        private ObjectSet<tipos_evento> _tipos_evento;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<eventos> eventos
        {
            get
            {
                if ((_eventos == null))
                {
                    _eventos = base.CreateObjectSet<eventos>("eventos");
                }
                return _eventos;
            }
        }
        private ObjectSet<eventos> _eventos;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet tipos_evento. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddTotipos_evento(tipos_evento tipos_evento)
        {
            base.AddObject("tipos_evento", tipos_evento);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet eventos. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToeventos(eventos eventos)
        {
            base.AddObject("eventos", eventos);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EventosModel", Name="eventos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class eventos : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto eventos.
        /// </summary>
        /// <param name="id_evento">Valor inicial de la propiedad id_evento.</param>
        /// <param name="nombre">Valor inicial de la propiedad nombre.</param>
        /// <param name="descripcion">Valor inicial de la propiedad descripcion.</param>
        /// <param name="cantidad">Valor inicial de la propiedad cantidad.</param>
        /// <param name="activo">Valor inicial de la propiedad activo.</param>
        public static eventos Createeventos(global::System.Int64 id_evento, global::System.String nombre, global::System.String descripcion, global::System.Decimal cantidad, global::System.Boolean activo)
        {
            eventos eventos = new eventos();
            eventos.id_evento = id_evento;
            eventos.nombre = nombre;
            eventos.descripcion = descripcion;
            eventos.cantidad = cantidad;
            eventos.activo = activo;
            return eventos;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id_evento
        {
            get
            {
                return _id_evento;
            }
            set
            {
                if (_id_evento != value)
                {
                    Onid_eventoChanging(value);
                    ReportPropertyChanging("id_evento");
                    _id_evento = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_evento");
                    Onid_eventoChanged();
                }
            }
        }
        private global::System.Int64 _id_evento;
        partial void Onid_eventoChanging(global::System.Int64 value);
        partial void Onid_eventoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                OndescripcionChanging(value);
                ReportPropertyChanging("descripcion");
                _descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("descripcion");
                OndescripcionChanged();
            }
        }
        private global::System.String _descripcion;
        partial void OndescripcionChanging(global::System.String value);
        partial void OndescripcionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                OncantidadChanging(value);
                ReportPropertyChanging("cantidad");
                _cantidad = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cantidad");
                OncantidadChanged();
            }
        }
        private global::System.Decimal _cantidad;
        partial void OncantidadChanging(global::System.Decimal value);
        partial void OncantidadChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cuenta_bancaria
        {
            get
            {
                return _cuenta_bancaria;
            }
            set
            {
                Oncuenta_bancariaChanging(value);
                ReportPropertyChanging("cuenta_bancaria");
                _cuenta_bancaria = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cuenta_bancaria");
                Oncuenta_bancariaChanged();
            }
        }
        private global::System.String _cuenta_bancaria;
        partial void Oncuenta_bancariaChanging(global::System.String value);
        partial void Oncuenta_bancariaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String banco
        {
            get
            {
                return _banco;
            }
            set
            {
                OnbancoChanging(value);
                ReportPropertyChanging("banco");
                _banco = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("banco");
                OnbancoChanged();
            }
        }
        private global::System.String _banco;
        partial void OnbancoChanging(global::System.String value);
        partial void OnbancoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String notas
        {
            get
            {
                return _notas;
            }
            set
            {
                OnnotasChanging(value);
                ReportPropertyChanging("notas");
                _notas = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("notas");
                OnnotasChanged();
            }
        }
        private global::System.String _notas;
        partial void OnnotasChanging(global::System.String value);
        partial void OnnotasChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean activo
        {
            get
            {
                return _activo;
            }
            set
            {
                OnactivoChanging(value);
                ReportPropertyChanging("activo");
                _activo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("activo");
                OnactivoChanged();
            }
        }
        private global::System.Boolean _activo;
        partial void OnactivoChanging(global::System.Boolean value);
        partial void OnactivoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String id_tipo_evento
        {
            get
            {
                return _id_tipo_evento;
            }
            set
            {
                Onid_tipo_eventoChanging(value);
                ReportPropertyChanging("id_tipo_evento");
                _id_tipo_evento = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("id_tipo_evento");
                Onid_tipo_eventoChanged();
            }
        }
        private global::System.String _id_tipo_evento;
        partial void Onid_tipo_eventoChanging(global::System.String value);
        partial void Onid_tipo_eventoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Byte> dia_limite
        {
            get
            {
                return _dia_limite;
            }
            set
            {
                Ondia_limiteChanging(value);
                ReportPropertyChanging("dia_limite");
                _dia_limite = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("dia_limite");
                Ondia_limiteChanged();
            }
        }
        private Nullable<global::System.Byte> _dia_limite;
        partial void Ondia_limiteChanging(Nullable<global::System.Byte> value);
        partial void Ondia_limiteChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> es_semanal
        {
            get
            {
                return _es_semanal;
            }
            set
            {
                Ones_semanalChanging(value);
                ReportPropertyChanging("es_semanal");
                _es_semanal = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("es_semanal");
                Ones_semanalChanged();
            }
        }
        private Nullable<global::System.Boolean> _es_semanal;
        partial void Ones_semanalChanging(Nullable<global::System.Boolean> value);
        partial void Ones_semanalChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String dia_semana
        {
            get
            {
                return _dia_semana;
            }
            set
            {
                Ondia_semanaChanging(value);
                ReportPropertyChanging("dia_semana");
                _dia_semana = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("dia_semana");
                Ondia_semanaChanged();
            }
        }
        private global::System.String _dia_semana;
        partial void Ondia_semanaChanging(global::System.String value);
        partial void Ondia_semanaChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EventosModel", "fk_tipo_evento", "tipos_evento")]
        public tipos_evento tipos_evento
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tipos_evento>("EventosModel.fk_tipo_evento", "tipos_evento").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tipos_evento>("EventosModel.fk_tipo_evento", "tipos_evento").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tipos_evento> tipos_eventoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tipos_evento>("EventosModel.fk_tipo_evento", "tipos_evento");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tipos_evento>("EventosModel.fk_tipo_evento", "tipos_evento", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EventosModel", Name="tipos_evento")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tipos_evento : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto tipos_evento.
        /// </summary>
        /// <param name="id_tipo_evento">Valor inicial de la propiedad id_tipo_evento.</param>
        /// <param name="descripcion">Valor inicial de la propiedad descripcion.</param>
        public static tipos_evento Createtipos_evento(global::System.String id_tipo_evento, global::System.String descripcion)
        {
            tipos_evento tipos_evento = new tipos_evento();
            tipos_evento.id_tipo_evento = id_tipo_evento;
            tipos_evento.descripcion = descripcion;
            return tipos_evento;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String id_tipo_evento
        {
            get
            {
                return _id_tipo_evento;
            }
            set
            {
                if (_id_tipo_evento != value)
                {
                    Onid_tipo_eventoChanging(value);
                    ReportPropertyChanging("id_tipo_evento");
                    _id_tipo_evento = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("id_tipo_evento");
                    Onid_tipo_eventoChanged();
                }
            }
        }
        private global::System.String _id_tipo_evento;
        partial void Onid_tipo_eventoChanging(global::System.String value);
        partial void Onid_tipo_eventoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                OndescripcionChanging(value);
                ReportPropertyChanging("descripcion");
                _descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("descripcion");
                OndescripcionChanged();
            }
        }
        private global::System.String _descripcion;
        partial void OndescripcionChanging(global::System.String value);
        partial void OndescripcionChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EventosModel", "fk_tipo_evento", "eventos")]
        public EntityCollection<eventos> eventos
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<eventos>("EventosModel.fk_tipo_evento", "eventos");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<eventos>("EventosModel.fk_tipo_evento", "eventos", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}

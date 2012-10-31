﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("ScrumBDModel", "RolesDeUnProyecto", "Proyecto", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CADAgenda1.Proyecto), "Rol", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CADAgenda1.Rol), true)]
[assembly: EdmRelationshipAttribute("ScrumBDModel", "HistoriasDeUnProyecto", "Proyecto", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(CADAgenda1.Proyecto), "Historia", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(CADAgenda1.Historia), true)]

#endregion

namespace CADAgenda1
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class ScrumBDModelContainer : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto ScrumBDModelContainer usando la cadena de conexión encontrada en la sección 'ScrumBDModelContainer' del archivo de configuración de la aplicación.
        /// </summary>
        public ScrumBDModelContainer() : base("name=ScrumBDModelContainer", "ScrumBDModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto ScrumBDModelContainer.
        /// </summary>
        public ScrumBDModelContainer(string connectionString) : base(connectionString, "ScrumBDModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto ScrumBDModelContainer.
        /// </summary>
        public ScrumBDModelContainer(EntityConnection connection) : base(connection, "ScrumBDModelContainer")
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
        public ObjectSet<Proyecto> Proyectos
        {
            get
            {
                if ((_Proyectos == null))
                {
                    _Proyectos = base.CreateObjectSet<Proyecto>("Proyectos");
                }
                return _Proyectos;
            }
        }
        private ObjectSet<Proyecto> _Proyectos;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Historia> Historias
        {
            get
            {
                if ((_Historias == null))
                {
                    _Historias = base.CreateObjectSet<Historia>("Historias");
                }
                return _Historias;
            }
        }
        private ObjectSet<Historia> _Historias;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Rol> Roles
        {
            get
            {
                if ((_Roles == null))
                {
                    _Roles = base.CreateObjectSet<Rol>("Roles");
                }
                return _Roles;
            }
        }
        private ObjectSet<Rol> _Roles;

        #endregion
        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Proyectos. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToProyectos(Proyecto proyecto)
        {
            base.AddObject("Proyectos", proyecto);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Historias. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToHistorias(Historia historia)
        {
            base.AddObject("Historias", historia);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Roles. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToRoles(Rol rol)
        {
            base.AddObject("Roles", rol);
        }

        #endregion
    }
    

    #endregion
    
    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ScrumBDModel", Name="Historia")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Historia : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Historia.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="descripcion">Valor inicial de la propiedad Descripcion.</param>
        /// <param name="prioridad">Valor inicial de la propiedad Prioridad.</param>
        /// <param name="habilitado">Valor inicial de la propiedad Habilitado.</param>
        /// <param name="proyecto_id">Valor inicial de la propiedad Proyecto_id.</param>
        public static Historia CreateHistoria(global::System.Int32 id, global::System.String descripcion, global::System.Int32 prioridad, global::System.Boolean habilitado, global::System.Int32 proyecto_id)
        {
            Historia historia = new Historia();
            historia.id = id;
            historia.Descripcion = descripcion;
            historia.Prioridad = prioridad;
            historia.Habilitado = habilitado;
            historia.Proyecto_id = proyecto_id;
            return historia;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                OnDescripcionChanging(value);
                ReportPropertyChanging("Descripcion");
                _Descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Descripcion");
                OnDescripcionChanged();
            }
        }
        private global::System.String _Descripcion;
        partial void OnDescripcionChanging(global::System.String value);
        partial void OnDescripcionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Prioridad
        {
            get
            {
                return _Prioridad;
            }
            set
            {
                OnPrioridadChanging(value);
                ReportPropertyChanging("Prioridad");
                _Prioridad = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Prioridad");
                OnPrioridadChanged();
            }
        }
        private global::System.Int32 _Prioridad;
        partial void OnPrioridadChanging(global::System.Int32 value);
        partial void OnPrioridadChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Habilitado
        {
            get
            {
                return _Habilitado;
            }
            set
            {
                OnHabilitadoChanging(value);
                ReportPropertyChanging("Habilitado");
                _Habilitado = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Habilitado");
                OnHabilitadoChanged();
            }
        }
        private global::System.Boolean _Habilitado;
        partial void OnHabilitadoChanging(global::System.Boolean value);
        partial void OnHabilitadoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Proyecto_id
        {
            get
            {
                return _Proyecto_id;
            }
            set
            {
                OnProyecto_idChanging(value);
                ReportPropertyChanging("Proyecto_id");
                _Proyecto_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Proyecto_id");
                OnProyecto_idChanged();
            }
        }
        private global::System.Int32 _Proyecto_id;
        partial void OnProyecto_idChanging(global::System.Int32 value);
        partial void OnProyecto_idChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ScrumBDModel", "HistoriasDeUnProyecto", "Proyecto")]
        public Proyecto Proyecto
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Proyecto>("ScrumBDModel.HistoriasDeUnProyecto", "Proyecto").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Proyecto>("ScrumBDModel.HistoriasDeUnProyecto", "Proyecto").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Proyecto> ProyectoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Proyecto>("ScrumBDModel.HistoriasDeUnProyecto", "Proyecto");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Proyecto>("ScrumBDModel.HistoriasDeUnProyecto", "Proyecto", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ScrumBDModel", Name="Proyecto")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Proyecto : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Proyecto.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="nombre">Valor inicial de la propiedad Nombre.</param>
        /// <param name="fechaInicio">Valor inicial de la propiedad FechaInicio.</param>
        /// <param name="fechaFinalizacion">Valor inicial de la propiedad FechaFinalizacion.</param>
        /// <param name="objetivo">Valor inicial de la propiedad Objetivo.</param>
        /// <param name="cajaTiempo">Valor inicial de la propiedad CajaTiempo.</param>
        public static Proyecto CreateProyecto(global::System.Int32 id, global::System.String nombre, global::System.DateTime fechaInicio, global::System.DateTime fechaFinalizacion, global::System.String objetivo, global::System.Int32 cajaTiempo)
        {
            Proyecto proyecto = new Proyecto();
            proyecto.id = id;
            proyecto.Nombre = nombre;
            proyecto.FechaInicio = fechaInicio;
            proyecto.FechaFinalizacion = fechaFinalizacion;
            proyecto.Objetivo = objetivo;
            proyecto.CajaTiempo = cajaTiempo;
            return proyecto;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime FechaInicio
        {
            get
            {
                return _FechaInicio;
            }
            set
            {
                OnFechaInicioChanging(value);
                ReportPropertyChanging("FechaInicio");
                _FechaInicio = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FechaInicio");
                OnFechaInicioChanged();
            }
        }
        private global::System.DateTime _FechaInicio;
        partial void OnFechaInicioChanging(global::System.DateTime value);
        partial void OnFechaInicioChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime FechaFinalizacion
        {
            get
            {
                return _FechaFinalizacion;
            }
            set
            {
                OnFechaFinalizacionChanging(value);
                ReportPropertyChanging("FechaFinalizacion");
                _FechaFinalizacion = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FechaFinalizacion");
                OnFechaFinalizacionChanged();
            }
        }
        private global::System.DateTime _FechaFinalizacion;
        partial void OnFechaFinalizacionChanging(global::System.DateTime value);
        partial void OnFechaFinalizacionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Objetivo
        {
            get
            {
                return _Objetivo;
            }
            set
            {
                OnObjetivoChanging(value);
                ReportPropertyChanging("Objetivo");
                _Objetivo = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Objetivo");
                OnObjetivoChanged();
            }
        }
        private global::System.String _Objetivo;
        partial void OnObjetivoChanging(global::System.String value);
        partial void OnObjetivoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CajaTiempo
        {
            get
            {
                return _CajaTiempo;
            }
            set
            {
                OnCajaTiempoChanging(value);
                ReportPropertyChanging("CajaTiempo");
                _CajaTiempo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CajaTiempo");
                OnCajaTiempoChanged();
            }
        }
        private global::System.Int32 _CajaTiempo;
        partial void OnCajaTiempoChanging(global::System.Int32 value);
        partial void OnCajaTiempoChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ScrumBDModel", "RolesDeUnProyecto", "Rol")]
        public EntityCollection<Rol> Roles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Rol>("ScrumBDModel.RolesDeUnProyecto", "Rol");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Rol>("ScrumBDModel.RolesDeUnProyecto", "Rol", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ScrumBDModel", "HistoriasDeUnProyecto", "Historia")]
        public EntityCollection<Historia> Historias
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Historia>("ScrumBDModel.HistoriasDeUnProyecto", "Historia");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Historia>("ScrumBDModel.HistoriasDeUnProyecto", "Historia", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ScrumBDModel", Name="Rol")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Rol : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Rol.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="nombreCompleto">Valor inicial de la propiedad NombreCompleto.</param>
        /// <param name="responsabilidad">Valor inicial de la propiedad Responsabilidad.</param>
        /// <param name="responsabilidadSecundaria">Valor inicial de la propiedad ResponsabilidadSecundaria.</param>
        /// <param name="proyecto_id">Valor inicial de la propiedad Proyecto_id.</param>
        public static Rol CreateRol(global::System.Int32 id, global::System.String nombreCompleto, global::System.String responsabilidad, global::System.String responsabilidadSecundaria, global::System.Int32 proyecto_id)
        {
            Rol rol = new Rol();
            rol.id = id;
            rol.NombreCompleto = nombreCompleto;
            rol.Responsabilidad = responsabilidad;
            rol.ResponsabilidadSecundaria = responsabilidadSecundaria;
            rol.Proyecto_id = proyecto_id;
            return rol;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NombreCompleto
        {
            get
            {
                return _NombreCompleto;
            }
            set
            {
                OnNombreCompletoChanging(value);
                ReportPropertyChanging("NombreCompleto");
                _NombreCompleto = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NombreCompleto");
                OnNombreCompletoChanged();
            }
        }
        private global::System.String _NombreCompleto;
        partial void OnNombreCompletoChanging(global::System.String value);
        partial void OnNombreCompletoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Responsabilidad
        {
            get
            {
                return _Responsabilidad;
            }
            set
            {
                OnResponsabilidadChanging(value);
                ReportPropertyChanging("Responsabilidad");
                _Responsabilidad = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Responsabilidad");
                OnResponsabilidadChanged();
            }
        }
        private global::System.String _Responsabilidad;
        partial void OnResponsabilidadChanging(global::System.String value);
        partial void OnResponsabilidadChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ResponsabilidadSecundaria
        {
            get
            {
                return _ResponsabilidadSecundaria;
            }
            set
            {
                OnResponsabilidadSecundariaChanging(value);
                ReportPropertyChanging("ResponsabilidadSecundaria");
                _ResponsabilidadSecundaria = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ResponsabilidadSecundaria");
                OnResponsabilidadSecundariaChanged();
            }
        }
        private global::System.String _ResponsabilidadSecundaria;
        partial void OnResponsabilidadSecundariaChanging(global::System.String value);
        partial void OnResponsabilidadSecundariaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Proyecto_id
        {
            get
            {
                return _Proyecto_id;
            }
            set
            {
                OnProyecto_idChanging(value);
                ReportPropertyChanging("Proyecto_id");
                _Proyecto_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Proyecto_id");
                OnProyecto_idChanged();
            }
        }
        private global::System.Int32 _Proyecto_id;
        partial void OnProyecto_idChanging(global::System.Int32 value);
        partial void OnProyecto_idChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ScrumBDModel", "RolesDeUnProyecto", "Proyecto")]
        public Proyecto Proyecto
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Proyecto>("ScrumBDModel.RolesDeUnProyecto", "Proyecto").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Proyecto>("ScrumBDModel.RolesDeUnProyecto", "Proyecto").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Proyecto> ProyectoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Proyecto>("ScrumBDModel.RolesDeUnProyecto", "Proyecto");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Proyecto>("ScrumBDModel.RolesDeUnProyecto", "Proyecto", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}

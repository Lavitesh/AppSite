﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework EntityObject template.
// Code is generated on: 09-Sep-18 1:26:46 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Reflection;
using System.Linq.Expressions;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("AppSiteTestModel", "FK_AppIcon_App", "App", RelationshipMultiplicity.One, typeof(AppSiteTestModel.App), "AppIcon", RelationshipMultiplicity.One, typeof(AppSiteTestModel.AppIcon), true)]
[assembly: EdmRelationshipAttribute("AppSiteTestModel", "FK_AppLocation_App", "App", RelationshipMultiplicity.One, typeof(AppSiteTestModel.App), "AppLocation", RelationshipMultiplicity.One, typeof(AppSiteTestModel.AppLocation), true)]
[assembly: EdmRelationshipAttribute("AppSiteTestModel", "App_AppCategory", "App", RelationshipMultiplicity.One, typeof(AppSiteTestModel.App), "AppCategories", RelationshipMultiplicity.Many, typeof(AppSiteTestModel.AppCategory), true)]
[assembly: EdmRelationshipAttribute("AppSiteTestModel", "CategoryMaster_AppCategory", "CategoryMaster", RelationshipMultiplicity.One, typeof(AppSiteTestModel.CategoryMaster), "AppCategories", RelationshipMultiplicity.Many, typeof(AppSiteTestModel.AppCategory), true)]

#endregion

namespace AppSiteTestModel
{

    #region AppSiteTestEntities

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AppSiteTestEntities : ObjectContext
    {
        #region Constructors

        /// <summary>
        /// Initialize a new AppSiteTestEntities object.
        /// </summary>
        public AppSiteTestEntities() : 
                base(@"metadata=AppSite.csdl|AppSite.ssdl|AppSite.msl;provider=System.Data.SqlClient;provider connection string=""Data Source=DESKTOP-3ECI093;Initial Catalog=AppSiteTest;Integrated Security=True;Persist Security Info=True""", "AppSiteTestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initializes a new AppSiteTestEntities object using the connection string found in the 'AppSiteTestEntities' section of the application configuration file.
        /// </summary>
        public AppSiteTestEntities(string connectionString) : 
                base(connectionString, "AppSiteTestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new AppSiteTestEntities object.
        /// </summary>
        public AppSiteTestEntities(EntityConnection connection) : base(connection, "AppSiteTestEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        #endregion

        #region Partial Methods

        partial void OnContextCreated();

        #endregion

        #region ObjectSet Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<App> Apps
        {
            get
            {
                if ((_Apps == null))
                {
                    _Apps = base.CreateObjectSet<App>("Apps");
                }
                return _Apps;
            }
        }
        private ObjectSet<App> _Apps;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AppIcon> AppIcons
        {
            get
            {
                if ((_AppIcons == null))
                {
                    _AppIcons = base.CreateObjectSet<AppIcon>("AppIcons");
                }
                return _AppIcons;
            }
        }
        private ObjectSet<AppIcon> _AppIcons;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AppLocation> AppLocations
        {
            get
            {
                if ((_AppLocations == null))
                {
                    _AppLocations = base.CreateObjectSet<AppLocation>("AppLocations");
                }
                return _AppLocations;
            }
        }
        private ObjectSet<AppLocation> _AppLocations;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CategoryMaster> CategoryMasters
        {
            get
            {
                if ((_CategoryMasters == null))
                {
                    _CategoryMasters = base.CreateObjectSet<CategoryMaster>("CategoryMasters");
                }
                return _CategoryMasters;
            }
        }
        private ObjectSet<CategoryMaster> _CategoryMasters;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AppCategory> AppCategories
        {
            get
            {
                if ((_AppCategories == null))
                {
                    _AppCategories = base.CreateObjectSet<AppCategory>("AppCategories");
                }
                return _AppCategories;
            }
        }
        private ObjectSet<AppCategory> _AppCategories;

        #endregion
        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the Apps EntitySet.
        /// </summary>
        public void AddToApps(App app)
        {
            base.AddObject("Apps", app);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the AppIcons EntitySet.
        /// </summary>
        public void AddToAppIcons(AppIcon appIcon)
        {
            base.AddObject("AppIcons", appIcon);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the AppLocations EntitySet.
        /// </summary>
        public void AddToAppLocations(AppLocation appLocation)
        {
            base.AddObject("AppLocations", appLocation);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the CategoryMasters EntitySet.
        /// </summary>
        public void AddToCategoryMasters(CategoryMaster categoryMaster)
        {
            base.AddObject("CategoryMasters", categoryMaster);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the AppCategories EntitySet.
        /// </summary>
        public void AddToAppCategories(AppCategory appCategory)
        {
            base.AddObject("AppCategories", appCategory);
        }

        #endregion
    }

    #endregion
}

namespace AppSiteTestModel
{

    /// <summary>
    /// There are no comments for AppSiteTestModel.App in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="AppSiteTestModel", Name="App")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class App : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new App object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        /// <param name="appName">Initial value of AppName.</param>
        /// <param name="extension">Initial value of Extension.</param>
        /// <param name="size">Initial value of Size.</param>
        public static App CreateApp(global::System.Int32 iD, global::System.String appName, global::System.String extension, global::System.Decimal size)
        {
            App app = new App();
            app.ID = iD;
            app.AppName = appName;
            app.Extension = extension;
            app.Size = size;
            return app;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.Int32 ID
        {
            get
            {
                global::System.Int32 value = _ID;
                OnGetID(ref value);
                return value;
            }
            set
            {
                if (_ID != value)
                {
                  OnIDChanging(ref value);
                  ReportPropertyChanging("ID");
                  _ID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID");
                  OnIDChanged();
              }
            }
        }
        private global::System.Int32 _ID;
        partial void OnGetID(ref global::System.Int32 value);
        partial void OnIDChanging(ref global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// There are no comments for AppName in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.String AppName
        {
            get
            {
                global::System.String value = _AppName;
                OnGetAppName(ref value);
                return value;
            }
            set
            {
                if (_AppName != value)
                {
                  OnAppNameChanging(ref value);
                  ReportPropertyChanging("AppName");
                  _AppName = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("AppName");
                  OnAppNameChanged();
              }
            }
        }
        private global::System.String _AppName;
        partial void OnGetAppName(ref global::System.String value);
        partial void OnAppNameChanging(ref global::System.String value);
        partial void OnAppNameChanged();
    
        /// <summary>
        /// There are no comments for Description in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public virtual global::System.String Description
        {
            get
            {
                global::System.String value = _Description;
                OnGetDescription(ref value);
                return value;
            }
            set
            {
                if (_Description != value)
                {
                  OnDescriptionChanging(ref value);
                  ReportPropertyChanging("Description");
                  _Description = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Description");
                  OnDescriptionChanged();
              }
            }
        }
        private global::System.String _Description;
        partial void OnGetDescription(ref global::System.String value);
        partial void OnDescriptionChanging(ref global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// There are no comments for Extension in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.String Extension
        {
            get
            {
                global::System.String value = _Extension;
                OnGetExtension(ref value);
                return value;
            }
            set
            {
                if (_Extension != value)
                {
                  OnExtensionChanging(ref value);
                  ReportPropertyChanging("Extension");
                  _Extension = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("Extension");
                  OnExtensionChanged();
              }
            }
        }
        private global::System.String _Extension;
        partial void OnGetExtension(ref global::System.String value);
        partial void OnExtensionChanging(ref global::System.String value);
        partial void OnExtensionChanged();
    
        /// <summary>
        /// There are no comments for Size in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.Decimal Size
        {
            get
            {
                global::System.Decimal value = _Size;
                OnGetSize(ref value);
                return value;
            }
            set
            {
                if (_Size != value)
                {
                  OnSizeChanging(ref value);
                  ReportPropertyChanging("Size");
                  _Size = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Size");
                  OnSizeChanged();
              }
            }
        }
        private global::System.Decimal _Size;
        partial void OnGetSize(ref global::System.Decimal value);
        partial void OnSizeChanging(ref global::System.Decimal value);
        partial void OnSizeChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for AppIcon in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AppSiteTestModel", "FK_AppIcon_App", "AppIcon")]
        public virtual AppIcon AppIcon
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<AppIcon>("AppSiteTestModel.FK_AppIcon_App", "AppIcon").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<AppIcon>("AppSiteTestModel.FK_AppIcon_App", "AppIcon").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for AppIcon in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<AppIcon> AppIconReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<AppIcon>("AppSiteTestModel.FK_AppIcon_App", "AppIcon");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<AppIcon>("AppSiteTestModel.FK_AppIcon_App", "AppIcon", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<AppIcon>("AppSiteTestModel.FK_AppIcon_App", "AppIcon").Value = null;
                }
            }
        }
    
        /// <summary>
        /// There are no comments for AppLocation in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AppSiteTestModel", "FK_AppLocation_App", "AppLocation")]
        public virtual AppLocation AppLocation
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<AppLocation>("AppSiteTestModel.FK_AppLocation_App", "AppLocation").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<AppLocation>("AppSiteTestModel.FK_AppLocation_App", "AppLocation").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for AppLocation in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<AppLocation> AppLocationReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<AppLocation>("AppSiteTestModel.FK_AppLocation_App", "AppLocation");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<AppLocation>("AppSiteTestModel.FK_AppLocation_App", "AppLocation", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<AppLocation>("AppSiteTestModel.FK_AppLocation_App", "AppLocation").Value = null;
                }
            }
        }
    
        /// <summary>
        /// There are no comments for AppCategories in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AppSiteTestModel", "App_AppCategory", "AppCategories")]
        public virtual EntityCollection<AppCategory> AppCategories
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<AppCategory>("AppSiteTestModel.App_AppCategory", "AppCategories");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<AppCategory>("AppSiteTestModel.App_AppCategory", "AppCategories", value);
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// There are no comments for AppSiteTestModel.AppIcon in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="AppSiteTestModel", Name="AppIcon")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AppIcon : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new AppIcon object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        /// <param name="iconName">Initial value of IconName.</param>
        public static AppIcon CreateAppIcon(global::System.Int32 iD, global::System.String iconName)
        {
            AppIcon appIcon = new AppIcon();
            appIcon.ID = iD;
            appIcon.IconName = iconName;
            return appIcon;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.Int32 ID
        {
            get
            {
                global::System.Int32 value = _ID;
                OnGetID(ref value);
                return value;
            }
            set
            {
                if (_ID != value)
                {
                  OnIDChanging(ref value);
                  ReportPropertyChanging("ID");
                  _ID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID");
                  OnIDChanged();
              }
            }
        }
        private global::System.Int32 _ID;
        partial void OnGetID(ref global::System.Int32 value);
        partial void OnIDChanging(ref global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// There are no comments for IconName in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.String IconName
        {
            get
            {
                global::System.String value = _IconName;
                OnGetIconName(ref value);
                return value;
            }
            set
            {
                if (_IconName != value)
                {
                  OnIconNameChanging(ref value);
                  ReportPropertyChanging("IconName");
                  _IconName = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("IconName");
                  OnIconNameChanged();
              }
            }
        }
        private global::System.String _IconName;
        partial void OnGetIconName(ref global::System.String value);
        partial void OnIconNameChanging(ref global::System.String value);
        partial void OnIconNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for App in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AppSiteTestModel", "FK_AppIcon_App", "App")]
        public virtual App App
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.FK_AppIcon_App", "App").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.FK_AppIcon_App", "App").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for App in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<App> AppReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.FK_AppIcon_App", "App");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<App>("AppSiteTestModel.FK_AppIcon_App", "App", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.FK_AppIcon_App", "App").Value = null;
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// There are no comments for AppSiteTestModel.AppLocation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="AppSiteTestModel", Name="AppLocation")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AppLocation : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new AppLocation object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        /// <param name="fileName">Initial value of FileName.</param>
        public static AppLocation CreateAppLocation(global::System.Int32 iD, global::System.String fileName)
        {
            AppLocation appLocation = new AppLocation();
            appLocation.ID = iD;
            appLocation.FileName = fileName;
            return appLocation;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.Int32 ID
        {
            get
            {
                global::System.Int32 value = _ID;
                OnGetID(ref value);
                return value;
            }
            set
            {
                if (_ID != value)
                {
                  OnIDChanging(ref value);
                  ReportPropertyChanging("ID");
                  _ID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID");
                  OnIDChanged();
              }
            }
        }
        private global::System.Int32 _ID;
        partial void OnGetID(ref global::System.Int32 value);
        partial void OnIDChanging(ref global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// There are no comments for FileName in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.String FileName
        {
            get
            {
                global::System.String value = _FileName;
                OnGetFileName(ref value);
                return value;
            }
            set
            {
                if (_FileName != value)
                {
                  OnFileNameChanging(ref value);
                  ReportPropertyChanging("FileName");
                  _FileName = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("FileName");
                  OnFileNameChanged();
              }
            }
        }
        private global::System.String _FileName;
        partial void OnGetFileName(ref global::System.String value);
        partial void OnFileNameChanging(ref global::System.String value);
        partial void OnFileNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for App in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AppSiteTestModel", "FK_AppLocation_App", "App")]
        public virtual App App
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.FK_AppLocation_App", "App").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.FK_AppLocation_App", "App").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for App in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<App> AppReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.FK_AppLocation_App", "App");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<App>("AppSiteTestModel.FK_AppLocation_App", "App", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.FK_AppLocation_App", "App").Value = null;
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// There are no comments for AppSiteTestModel.CategoryMaster in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CategoryIndex
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="AppSiteTestModel", Name="CategoryMaster")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CategoryMaster : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new CategoryMaster object.
        /// </summary>
        /// <param name="categoryIndex">Initial value of CategoryIndex.</param>
        /// <param name="category">Initial value of Category.</param>
        public static CategoryMaster CreateCategoryMaster(global::System.Int32 categoryIndex, global::System.String category)
        {
            CategoryMaster categoryMaster = new CategoryMaster();
            categoryMaster.CategoryIndex = categoryIndex;
            categoryMaster.Category = category;
            return categoryMaster;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CategoryIndex in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.Int32 CategoryIndex
        {
            get
            {
                global::System.Int32 value = _CategoryIndex;
                OnGetCategoryIndex(ref value);
                return value;
            }
            set
            {
                if (_CategoryIndex != value)
                {
                  OnCategoryIndexChanging(ref value);
                  ReportPropertyChanging("CategoryIndex");
                  _CategoryIndex = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CategoryIndex");
                  OnCategoryIndexChanged();
              }
            }
        }
        private global::System.Int32 _CategoryIndex;
        partial void OnGetCategoryIndex(ref global::System.Int32 value);
        partial void OnCategoryIndexChanging(ref global::System.Int32 value);
        partial void OnCategoryIndexChanged();
    
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.String Category
        {
            get
            {
                global::System.String value = _Category;
                OnGetCategory(ref value);
                return value;
            }
            set
            {
                if (_Category != value)
                {
                  OnCategoryChanging(ref value);
                  ReportPropertyChanging("Category");
                  _Category = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("Category");
                  OnCategoryChanged();
              }
            }
        }
        private global::System.String _Category;
        partial void OnGetCategory(ref global::System.String value);
        partial void OnCategoryChanging(ref global::System.String value);
        partial void OnCategoryChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for AppCategories in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AppSiteTestModel", "CategoryMaster_AppCategory", "AppCategories")]
        public virtual EntityCollection<AppCategory> AppCategories
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<AppCategory>("AppSiteTestModel.CategoryMaster_AppCategory", "AppCategories");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<AppCategory>("AppSiteTestModel.CategoryMaster_AppCategory", "AppCategories", value);
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// There are no comments for AppSiteTestModel.AppCategory in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// CategoryIndex
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="AppSiteTestModel", Name="AppCategory")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AppCategory : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new AppCategory object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        /// <param name="categoryIndex">Initial value of CategoryIndex.</param>
        public static AppCategory CreateAppCategory(global::System.Int32 iD, global::System.Int32 categoryIndex)
        {
            AppCategory appCategory = new AppCategory();
            appCategory.ID = iD;
            appCategory.CategoryIndex = categoryIndex;
            return appCategory;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.Int32 ID
        {
            get
            {
                global::System.Int32 value = _ID;
                OnGetID(ref value);
                return value;
            }
            set
            {
                if (_ID != value)
                {
                  OnIDChanging(ref value);
                  ReportPropertyChanging("ID");
                  _ID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID");
                  OnIDChanged();
              }
            }
        }
        private global::System.Int32 _ID;
        partial void OnGetID(ref global::System.Int32 value);
        partial void OnIDChanging(ref global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// There are no comments for CategoryIndex in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public virtual global::System.Int32 CategoryIndex
        {
            get
            {
                global::System.Int32 value = _CategoryIndex;
                OnGetCategoryIndex(ref value);
                return value;
            }
            set
            {
                if (_CategoryIndex != value)
                {
                  OnCategoryIndexChanging(ref value);
                  ReportPropertyChanging("CategoryIndex");
                  _CategoryIndex = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CategoryIndex");
                  OnCategoryIndexChanged();
              }
            }
        }
        private global::System.Int32 _CategoryIndex;
        partial void OnGetCategoryIndex(ref global::System.Int32 value);
        partial void OnCategoryIndexChanging(ref global::System.Int32 value);
        partial void OnCategoryIndexChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for App in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AppSiteTestModel", "App_AppCategory", "App")]
        public virtual App App
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.App_AppCategory", "App").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.App_AppCategory", "App").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for App in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<App> AppReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.App_AppCategory", "App");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<App>("AppSiteTestModel.App_AppCategory", "App", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<App>("AppSiteTestModel.App_AppCategory", "App").Value = null;
                }
            }
        }
    
        /// <summary>
        /// There are no comments for CategoryMaster in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AppSiteTestModel", "CategoryMaster_AppCategory", "CategoryMaster")]
        public virtual CategoryMaster CategoryMaster
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<CategoryMaster>("AppSiteTestModel.CategoryMaster_AppCategory", "CategoryMaster").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<CategoryMaster>("AppSiteTestModel.CategoryMaster_AppCategory", "CategoryMaster").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for CategoryMaster in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CategoryMaster> CategoryMasterReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<CategoryMaster>("AppSiteTestModel.CategoryMaster_AppCategory", "CategoryMaster");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<CategoryMaster>("AppSiteTestModel.CategoryMaster_AppCategory", "CategoryMaster", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<CategoryMaster>("AppSiteTestModel.CategoryMaster_AppCategory", "CategoryMaster").Value = null;
                }
            }
        }

        #endregion
    }

}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AllTheSame.Entity.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AllTheSameDbContext : DbContext
    {
        public AllTheSameDbContext()
            : base("name=AllTheSameDbContext")
        {
            Init();
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Alert> Alerts { get; set; }
        public virtual DbSet<AlertType> AlertTypes { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentType> AppointmentTypes { get; set; }
        public virtual DbSet<Community> Communities { get; set; }
        public virtual DbSet<CommunityAdmin> CommunityAdmins { get; set; }
        public virtual DbSet<CommunityImport> CommunityImports { get; set; }
        public virtual DbSet<CommunityType> CommunityTypes { get; set; }
        public virtual DbSet<CommunityWorker> CommunityWorkers { get; set; }
        public virtual DbSet<CommunityWorker_Alert> CommunityWorker_Alert { get; set; }
        public virtual DbSet<DataSync> DataSyncs { get; set; }
        public virtual DbSet<FamilyMember> FamilyMembers { get; set; }
        public virtual DbSet<ImportErrorLog> ImportErrorLogs { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<Kiosk> Kiosks { get; set; }
        public virtual DbSet<KioskStatus> KioskStatuses { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<OrgType> OrgTypes { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }
        public virtual DbSet<Requirement> Requirements { get; set; }
        public virtual DbSet<RequirementType> RequirementTypes { get; set; }
        public virtual DbSet<Resident> Residents { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Role_Permission> Role_Permission { get; set; }
        public virtual DbSet<SignOut> SignOuts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Org_Permission> User_Org_Permission { get; set; }
        public virtual DbSet<User_Org_Role> User_Org_Role { get; set; }
        public virtual DbSet<UserSession> UserSessions { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Vendor_Archive> Vendor_Archive { get; set; }
        public virtual DbSet<VendorAdmin> VendorAdmins { get; set; }
        public virtual DbSet<VendorCredDocument> VendorCredDocuments { get; set; }
        public virtual DbSet<VendorCredential> VendorCredentials { get; set; }
        public virtual DbSet<VendorImport> VendorImports { get; set; }
        public virtual DbSet<VendorType> VendorTypes { get; set; }
        public virtual DbSet<VendorWorker> VendorWorkers { get; set; }
        public virtual DbSet<VendorWorker_Alert> VendorWorker_Alert { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<VisitImport> VisitImports { get; set; }
        public virtual DbSet<Visitor> Visitors { get; set; }

        public virtual ObjectResult<spGetOrgPermissions_Result> spGetOrgPermissions(Nullable<int> orgId, Nullable<int> userId)
        {
            var orgIdParameter = orgId.HasValue ?
                new ObjectParameter("orgId", orgId) :
                new ObjectParameter("orgId", typeof(int));

            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetOrgPermissions_Result>("spGetOrgPermissions", orgIdParameter, userIdParameter);
        }

        public virtual int spHasPermission(Nullable<int> orgId, Nullable<int> userId, string permissionCode, ObjectParameter hasPermission)
        {
            var orgIdParameter = orgId.HasValue ?
                new ObjectParameter("orgId", orgId) :
                new ObjectParameter("orgId", typeof(int));

            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));

            var permissionCodeParameter = permissionCode != null ?
                new ObjectParameter("permissionCode", permissionCode) :
                new ObjectParameter("permissionCode", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spHasPermission", orgIdParameter, userIdParameter, permissionCodeParameter, hasPermission);
        }

        public virtual int spOrganizationAdd(Nullable<int> parentOrgId, string name, ObjectParameter newId)
        {
            var parentOrgIdParameter = parentOrgId.HasValue ?
                new ObjectParameter("parentOrgId", parentOrgId) :
                new ObjectParameter("parentOrgId", typeof(int));

            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spOrganizationAdd", parentOrgIdParameter, nameParameter, newId);
        }

        public virtual int spOrganizationMoveSubTree(Nullable<int> oldParentId, Nullable<int> newParentId)
        {
            var oldParentIdParameter = oldParentId.HasValue ?
                new ObjectParameter("oldParentId", oldParentId) :
                new ObjectParameter("oldParentId", typeof(int));

            var newParentIdParameter = newParentId.HasValue ?
                new ObjectParameter("newParentId", newParentId) :
                new ObjectParameter("newParentId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spOrganizationMoveSubTree", oldParentIdParameter, newParentIdParameter);
        }

        public virtual int spImportCommunities(Nullable<System.Guid> communityImportId)
        {
            var communityImportIdParameter = communityImportId.HasValue ?
                new ObjectParameter("CommunityImportId", communityImportId) :
                new ObjectParameter("CommunityImportId", typeof(System.Guid));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spImportCommunities", communityImportIdParameter);
        }

        public virtual int spImportVendors(Nullable<System.Guid> vendorImportId)
        {
            var vendorImportIdParameter = vendorImportId.HasValue ?
                new ObjectParameter("VendorImportId", vendorImportId) :
                new ObjectParameter("VendorImportId", typeof(System.Guid));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spImportVendors", vendorImportIdParameter);
        }

        public virtual int spImportVisits(Nullable<System.Guid> visitImportId)
        {
            var visitImportIdParameter = visitImportId.HasValue ?
                new ObjectParameter("VisitImportId", visitImportId) :
                new ObjectParameter("VisitImportId", typeof(System.Guid));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spImportVisits", visitImportIdParameter);
        }
    }
}
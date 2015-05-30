﻿using AllTheSame.Entity.Model;
using AllTheSame.Repository.Common;
using AllTheSame.Repository.UserData.interfaces;
using AllTheSame.Service.Common;
using AllTheSame.Service.Interfaces;

namespace AllTheSame.Service.Implementation
{
    /// <summary>
    /// CommunityAdminService
    /// Uncomment _unitOfWork, _repository and Dipose area below
    /// when building custom methods for this service
    /// </summary>
    public class CommunityAdminService : SyncEntityService<CommunityAdmin, ICommunityAdminRepository>, ICommunityAdminService
    {
        /// <summary>
        /// The _repository
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="repository">The repository.</param>
        public CommunityAdminService(IUnitOfWork unitOfWork, ICommunityAdminRepository repository)
            : base(unitOfWork, repository)
        {
            //_unitOfWork = unitOfWork;
            //_repository = repository;
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    _unitOfWork.Dispose();
            //}

            base.Dispose(disposing);
        }
    }
}
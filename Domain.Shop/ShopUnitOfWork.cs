﻿using Infrastructure.Database;
using Infrastructure.Database.Entities;
using Infrastructure.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application
{
    public class ShopUnitOfWork : IUnitOfWork<ShopDBContext>, IDisposable
    {
        public ShopDBContext _context { get; }

        public ShopUnitOfWork(ShopDBContext context)
        {
            _context = context;
        }

        public async Task SaveAsync(RequestContext requestContext = null)
        {
            UpdateRequestInfo(requestContext);
            await _context.SaveChangesAsync();
        }

        public int Save(RequestContext requestContext = null)
        {
            UpdateRequestInfo(requestContext);
            return _context.SaveChanges();
        }

        private void UpdateRequestInfo(RequestContext requestContext = null)
        {
            if (requestContext == null)
                return;
            if (_context.ChangeTracker.HasChanges())
            {
                foreach (var dbEntity in _context.ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified))
                {
                    var entity = dbEntity.Entity as BaseEntity;
                    if (entity == null) continue;

                    if (dbEntity.State == EntityState.Added)
                    {
                        entity.CreateAt = requestContext.RequestTime;
                        entity.CreateBy = requestContext.UserId;
                    }
                    else if (dbEntity.State == EntityState.Modified)
                    {
                        entity.LastUpdateAt = requestContext.RequestTime;
                        entity.LastUpdateBy = requestContext.UserId;
                    }

                }
            }
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

		public IDbContextTransaction BeginTransaction()
		{
            return _context.Database.BeginTransaction();
		}
	}
}

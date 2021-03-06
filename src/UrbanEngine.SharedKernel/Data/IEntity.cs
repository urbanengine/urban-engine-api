﻿using System;

namespace UrbanEngine.SharedKernel.Data
{
    public interface IEntity
    {
        long Id { get; }

        bool IsDeleted { get; set; }

        DateTimeOffset? DateCreated { get; }
    }

    /// <summary>
    /// base class for entities
    /// </summary>
    /// <typeparam name="TIdentity"></typeparam>
    public abstract class EntityBase : IEntity
    {
        /// <summary>
        /// uniquely identifies the entity
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// used for soft deletes to indicate if item is deleted
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// date item was created in the database
        /// </summary>
        public DateTimeOffset? DateCreated { get; set; } = DateTime.Now;

        protected EntityBase() { }
    }
}

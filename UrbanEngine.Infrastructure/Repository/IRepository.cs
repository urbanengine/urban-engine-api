﻿namespace UrbanEngine.Infrastructure.Repository {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    /// <summary>
    /// represents a repository used to interact with database
    /// </summary>
    public interface IRepository {
         
        /// <summary>
        /// returns dbset of specified entity 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IQueryable<TEntity> Set<TEntity>()
            where TEntity : class;

        /// <summary>
        /// gets single or default instance of an entity for a given predicate 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> SingleOrDefaultAsync<TEntity>( Expression<Func<TEntity, bool>> predicate = null )
            where TEntity : class;

        /// <summary>
        /// gets single or default instance of an entity for a given predicate 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> FirstOrDefaultAsync<TEntity>( Expression<Func<TEntity, bool>> predicate = null )
            where TEntity : class;

        /// <summary>
        /// gets an enumerable list of an entity for a given predicate
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> ListAsync<TEntity>( Expression<Func<TEntity, bool>> predicate = null ) 
            where TEntity : class;

        /// <summary>
        /// retreive specified entity for given predicate 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<TEntity> Get<TEntity>( Expression<Func<TEntity, bool>> predicate = null )
            where TEntity : class;

        /// <summary>
        /// retreive entity using specified sql 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IQueryable<TEntity> FromSql<TEntity>( string sql, params object[] parameters ) where TEntity : class;

        /// <summary>
        /// create new instance of entity 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<int> CreateAsync<TEntity>( params TEntity[] entities )
            where TEntity : class;

        /// <summary>
        /// update entity 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<int> UpdateAsync<TEntity>( params TEntity[] entities )
            where TEntity : class;

        /// <summary>
        /// delete entity 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<int> DeleteAsync<TEntity>( params TEntity[] entities )
            where TEntity : class;

    }
}
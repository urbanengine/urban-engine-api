﻿using UrbanEngine.SharedKernel.Paging;

namespace UrbanEngine.SharedKernel.Results
{
    public class QueryResult : ResultBase
    { 
        public object Data { get; private set; }

        public IPagingResult Paging { get; private set; }
        
        public override string ResultType => "Query";

        public QueryResult(object data, IPagingResult paging = null, string message = null)
            : base(message)
        {
            Data = data; 
            Paging = paging;
        }
        
    }

    public class QueryResult<T> : QueryResult
    {
        public QueryResult(T data, IPagingResult paging = null)
            : base(data, paging) { }

        public static QueryResult<T> New(T data)
        {
            IPagingResult paging;
            if(data is IPageableReadOnlyList) 
                paging = ((IPageableReadOnlyList)data).GetPagingResult(); 
            else 
                paging = PagingResult.None; 

            return new QueryResult<T>(data, paging);
        }
    }
}

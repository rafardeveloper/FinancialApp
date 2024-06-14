﻿using System.Text.Json.Serialization;

namespace Financial.Core.Responses;

public abstract class PagedResponse<TData>: Response<TData>
{
    private int statusCode = Configuration.DefaultStatusCode;
    public int CurrentPage { get; set; }
    public int TotalCount { get; set; }
    public int PageSize { get; set; } = Configuration.DefaultPageSize;
    
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

    [JsonConstructor]
    public PagedResponse(
        TData? data,
        int totalCount,
        int currentPage = 1,
        int pageSize = Configuration.DefaultPageSize) : base(data)
    {
        Data = data;
        TotalCount = totalCount;
        CurrentPage = currentPage;
        PageSize = pageSize;
    }

    public PagedResponse(TData? data,
        int statusCode = Configuration.DefaultStatusCode,
        string? message = null)
        : base(data, statusCode, message)
    {
        
    }
}
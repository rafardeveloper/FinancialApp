﻿namespace Financial.Core.Requests;

public abstract class Request
{
    public string UserId { get; set; } = String.Empty;
}
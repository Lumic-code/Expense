﻿namespace Expenses.Api.Models
{
    public class Response<T>
    {
        public T[] Data { get; set; }
        public int Total { get; set; }
    }
}
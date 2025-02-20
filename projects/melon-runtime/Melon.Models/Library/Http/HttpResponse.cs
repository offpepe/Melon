﻿using System.Net.Http.Headers;

namespace Melon.Models.Library
{
    public class HttpResponse
    {
        public string? Body { get; set; }
        public HttpResponseHeaders? Headers { get; set; }
        public float? Latency { get; set; }
        public bool Ok { get; set; }
        public uint StatusCode { get; set; }
    }
}

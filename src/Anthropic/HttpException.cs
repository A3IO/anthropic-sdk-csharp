using CodeAnalysis = System.Diagnostics.CodeAnalysis;
using Net = System.Net;
using System = System;

namespace Anthropic;

public sealed class HttpException : System::Exception
{
    public required Net::HttpStatusCode? StatusCode { get; set; }
    public required string ResponseBody { get; set; }
    public override string Message
    {
        get
        {
            return string.Format(
                "Status Code: {0}\n{1}",
                this.StatusCode?.ToString() ?? "Unknown",
                this.ResponseBody
            );
        }
    }

    [CodeAnalysis::SetsRequiredMembers]
    public HttpException(Net::HttpStatusCode? statusCode, string responseBody)
    {
        this.StatusCode = statusCode;
        this.ResponseBody = responseBody;
    }
}

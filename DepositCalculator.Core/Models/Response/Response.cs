using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DepositCalculator.Core.Models.Response
{
	public class SimpleResponse
	{
		public string? Status { get; set; }
		public string? Message { get; set; }
	}

	public class Response<T>
	{
		public T Result { get; set; }

		[JsonIgnore]
		public HttpStatusCode StatusCode { get; set; }

		[JsonIgnore]
		public bool IsSuccessful { get; set; }

		public List<string> Errors { get; set; }

		public static Response<T> Success(T result, HttpStatusCode statusCode)
		{
			return new Response<T> { Result = result, StatusCode = statusCode, IsSuccessful = true };
		}

		public static Response<T> Success(HttpStatusCode statusCode)
		{
			return new Response<T> { Result = default, StatusCode = statusCode, IsSuccessful = true };
		}

		public static Response<T> Fail(List<string> errors, HttpStatusCode statusCode)
		{
			return new Response<T>
			{
				Errors = errors,
				StatusCode = statusCode,
				IsSuccessful = false
			};
		}

		public static Response<T> Fail(string error, HttpStatusCode statusCode)
		{
			return new Response<T> { Errors = new List<string>() { error }, StatusCode = statusCode, IsSuccessful = false };
		}
	}
}

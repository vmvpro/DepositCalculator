using Microsoft.AspNetCore.Builder;

namespace DepositCalculator.WebApi
{
	public static class ExceptionMiddlewareExtensions
	{
		public static IApplicationBuilder UseExceptionHandler(
			this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<Middleware.ExceptionMiddleware>();
		}
	}
}

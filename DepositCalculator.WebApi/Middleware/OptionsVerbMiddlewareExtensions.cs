using Microsoft.AspNetCore.Builder;

namespace DepositCalculator.WebApi
{
	public static class OptionsVerbMiddlewareExtensions
	{
		public static IApplicationBuilder UseOptionsVerbHandler(
			this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<Middleware.OptionsVerbMiddleware>();
		}
	}
}

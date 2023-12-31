var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

//services.AddTransient<IMongoDatabase>(options =>
//{
//	var settings = mongoDbConfig;
//	var client = new MongoClient(settings.ConnectionString);
//	return client.GetDatabase(settings.Name);
//});

var app = builder.Build();

app.UseCors(builder => builder
				.WithOrigins("null")
				.AllowAnyHeader()
				.AllowAnyMethod()
				.AllowCredentials());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
else
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
	endpoints.MapDefaultControllerRoute();

	endpoints.MapControllerRoute(
		name: "default",
		pattern: "{controller=Home}/{action=Index}/{id?}");

	endpoints.MapControllerRoute(name: "api",
		pattern: "api/{controller}/{action}/{id?}",
		defaults: new { controller = "ToDo", action = "GetString" });
});

//app.MapControllers();

app.Run();

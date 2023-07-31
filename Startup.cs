public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

        services.AddControllers();

        services.AddHttpClient<ITodoApiClient, TodoApiClient>(client =>
        {
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseExceptionHandler(errorApp =>
        {
            errorApp.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var ex = context.Features.Get<IExceptionHandlerFeature>();
                if (ex != null)
                {
                    var error = new
                    {
                        message = "Terjadi kesalahan pada server.",
                        details = ex.Error.Message
                    };

                    var errorJson = JsonConvert.SerializeObject(error);
                    await context.Response.WriteAsync(errorJson);
                }
            });
        });

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}

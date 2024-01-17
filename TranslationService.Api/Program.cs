using TranslationService.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

var allowedOrigins = builder.Configuration.GetSection("CorsOrigins").Get<string[]>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigins",
        builder =>
        {
            builder.WithOrigins(allowedOrigins)
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

// Add services to the container.
builder.Services.AddScoped<ITranslationsService, GoogleTranslationsService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowOrigins");
app.MapControllers();

app.Run();

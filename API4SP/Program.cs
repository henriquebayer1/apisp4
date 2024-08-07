using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();




//Adiciona o servico de Jwt Bearer (forma de autenticacao)
builder.Services.AddAuthentication(
   options =>
   {

       options.DefaultAuthenticateScheme = "JwtBearer";
       options.DefaultAuthenticateScheme = "JwtBearer";

   });






//Configuracao do servico do swagger documentacao
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API CodeFirst Bayer",
        Description = "API gerenciadora codeFirst - introducao da sprint 2 - API BackEnd",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Henrique",
            Url = new Uri("https://example.com/contact")
        },

    });

    


    
  

});


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

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
//Finaliza a configuracao do swagger

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
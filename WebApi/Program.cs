using Application.EndpointsExtensions;
using Application.Handlers;
using Domain.Interfaces;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// ✅ Register your handlers before calling Build()
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<CreateStudentHandler>();
builder.Services.AddScoped<GetStudentHandler>();
builder.Services.AddScoped<GetAllStudentsHandler>();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello World!");
app.MapStudentEndpoints();

app.Run();

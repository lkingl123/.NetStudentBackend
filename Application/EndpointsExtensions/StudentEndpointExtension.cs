using Application.Handlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.EndpointsExtensions;

public static class StudentEndpointExtension
{
    public static void MapStudentEndpoints(this WebApplication app)
    {
        app.MapGet("/students/{id}", async (string id, GetStudentHandler handler) =>
        {
            var student = await handler.HandleAsync(id);
            return student is not null ? Results.Ok(student) : Results.NotFound();
        });

        app.MapGet("/students", async ([FromServices] GetAllStudentsHandler handler) =>
        {
            var students = await handler.HandleAsync();
            return Results.Ok(students);
        });


        app.MapPost("/students", async ([FromServices] CreateStudentHandler handler, StudentDto dto) =>
        {
            var student = await handler.HandleAsync(dto.FirstName, dto.LastName, dto.Email);
            return Results.Created($"/students/{student.Id}", student);
        });

    }

    public record StudentDto(string FirstName, string LastName, string? Email);
}

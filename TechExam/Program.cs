using System.Globalization;
using Microsoft.OpenApi.Extensions;
using TechExam.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ProgressionService>();

var app = builder.Build();

Console.WriteLine(Week.GetWeekNumber().GetDisplayName());

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();


public static class Week
{
    public static DayOfWeek GetWeekNumber()
    {
        CultureInfo ciCurr = CultureInfo.CurrentCulture;
        var day = ciCurr.Calendar.GetDayOfWeek(DateTime.Now);
        return day;
    }
}
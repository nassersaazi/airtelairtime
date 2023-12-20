using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TransactionDB>(opt => opt.UseInMemoryDatabase("PaymentsDB"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();

app.MapGet("/transactions/status/{referenceId}", async (string referenceId, TransactionDB db) =>
    await db.Transactions.FindAsync(referenceId)
        is Transaction transaction
            ? Results.Ok(transaction)
            : Results.NotFound());

app.MapPost("/transactions", async (Transaction transaction, TransactionDB db) =>
{
    db.Transactions.Add(transaction);
    await db.SaveChangesAsync();

    return Results.Created($"/transaction/{transaction.referenceId}", transaction);
});



app.Run();
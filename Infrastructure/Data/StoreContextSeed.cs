using System;
using System.Text.Json;
using Core.Models;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    public static async Task SeedAsync(LibraryDbContext context)
    {
        if (!context.Authors.Any())
        {
            var authorsData = File.ReadAllText("../Infrastructure/Data/SeedData/authors.json");
            var authors = JsonSerializer.Deserialize<List<Author>>(authorsData);
            if (authors == null) return;
            context.Authors.AddRange(authors);
            await context.SaveChangesAsync();
        }
    }
    
    
        

}

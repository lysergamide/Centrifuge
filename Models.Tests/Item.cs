using System;
using Centrifuge.Models;

namespace Models.Tests;

public class ItemTests
{
    string UUID;
    LocalDbContext ctx;

    public ItemTests() {
        UUID = Guid.NewGuid().ToString();
        ctx = new LocalDbContext();
        ctx.Database.EnsureCreated();
    }

    [Fact]
    public void InsertTestItem()
    {        
        var item = new Item(){
            Title = UUID,
            Description = "",
            Tags = new List <Tag> (),
        };

        ctx.Items.Add(item);
        ctx.SaveChanges();

        var found = ctx.Items
            .Where(x => x.Title == UUID)
        .First<Item>();
        Assert.Equal(found.Title, UUID);
    }
}
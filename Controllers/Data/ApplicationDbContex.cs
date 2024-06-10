
using Microsoft.EntityFrameworkCore;
using Books_Inbox.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Books_Inbox.Controllers;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Writer> Writers { get; set; }

}
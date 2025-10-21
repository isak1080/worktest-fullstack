using Microsoft.EntityFrameworkCore;
using TrainingApp.Api.Models;

namespace TrainingApp.Api.Data;

public class TrainingContext : DbContext
{
    public TrainingContext(DbContextOptions<TrainingContext> options) : base(options) {}

    public DbSet<Athlete> Athletes => Set<Athlete>();
    public DbSet<Exercise> Exercises => Set<Exercise>();
    public DbSet<Group> Groups => Set<Group>();
}

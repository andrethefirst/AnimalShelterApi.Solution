using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
      {
      }
      public DbSet<Animal> Animals { get; set; }
      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
        .HasData(
          new Animal {AnimalId = 1, Name = "Zeus", Type = "Dog", Species = "German Shepherd", Gender = "Male", Size = "Large"},
          new Animal {AnimalId = 2, Name = "Poseidon", Type = "Dog", Species = "Rottweiler", Gender = "Male", Size = "Large"},
          new Animal {AnimalId = 3, Name = "Hades", Type = "Dog", Species = "Doberman", Gender = "Male", Size = "Large"},
          new Animal {AnimalId = 4, Name = "Jones", Type = "Dog", Species = "Chihuahua", Gender = "Female", Size = "Tiny"},
          new Animal {AnimalId = 5, Name = "Rose", Type = "Dog", Species = "Bulldog", Gender = "Female", Size = "Medium"},
          new Animal {AnimalId = 6, Name = "Swift", Type = "Cat", Species = "Persian", Gender = "Female", Size = "Tiny"},
          new Animal {AnimalId = 7, Name = "Bonkers", Type = "Cat", Species = "Siamese", Gender = "Male", Size = "Tiny"},
          new Animal {AnimalId = 8, Name = "Jordan", Type = "Cat", Species = "Siberian", Gender = "Female", Size = "Tiny"}
        );
      }
  }
}
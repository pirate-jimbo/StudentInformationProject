using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentInformationProject.Models.DomainModels;

namespace StudentInformationProject.Database.Configuration
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            var currentTime = DateTime.Now;
            builder.HasData(
                new Class() { Id = 1, Name = "Class 1", ModificationDate = currentTime, CreatedDate = currentTime },
                new Class() { Id = 2, Name = "Class 2", ModificationDate = currentTime, CreatedDate = currentTime },
                new Class() { Id = 3, Name = "Class 3", ModificationDate = currentTime, CreatedDate = currentTime },
                new Class() { Id = 4, Name = "Class 4", ModificationDate = currentTime, CreatedDate = currentTime },
                new Class() { Id = 5, Name = "Class 5", ModificationDate = currentTime, CreatedDate = currentTime },
                new Class() { Id = 6, Name = "Class 6", ModificationDate = currentTime, CreatedDate = currentTime },
                new Class() { Id = 7, Name = "Class 7", ModificationDate = currentTime, CreatedDate = currentTime },
                new Class() { Id = 8, Name = "Class 8", ModificationDate = currentTime, CreatedDate = currentTime },
                new Class() { Id = 9, Name = "Class 9", ModificationDate = currentTime, CreatedDate = currentTime },
                new Class() { Id = 10, Name = "Class 10", ModificationDate = currentTime, CreatedDate = currentTime }
            );
        }
    }
}

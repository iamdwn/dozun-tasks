using be_dozun_tasks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace be_dozun_tasks.Configuration
{
    public class DztasksConfiguration : IEntityTypeConfiguration<Todo>
    {
        void IEntityTypeConfiguration<Todo>.Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("todos");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.isComplete).IsRequired().HasDefaultValue(false);
        }
    }
}

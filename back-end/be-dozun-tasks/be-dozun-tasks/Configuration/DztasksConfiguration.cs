using be_dozun_tasks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace be_dozun_tasks.Configuration
{
    public class DztasksConfiguration : IEntityTypeConfiguration<Models.Tasks>
    {
        void IEntityTypeConfiguration<Models.Tasks>.Configure(EntityTypeBuilder<Models.Tasks> builder)
        {
            builder.ToTable("todos");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.isComplete).IsRequired().HasDefaultValue(false);
        }
    }
}

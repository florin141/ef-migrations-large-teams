using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cintera.DAL.Mappings
{
    public class SightingMap : EntityTypeConfiguration<Sighting>
    {
        public SightingMap()
        {
            this.Property(s => s.Address)
                .HasMaxLength(256)
                .IsRequired();
        }
    }
}

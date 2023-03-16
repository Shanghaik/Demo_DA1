using A_DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configuration
{
    internal class BillDetailsConfig : IEntityTypeConfiguration<BillDetails>
    {
        public void Configure(EntityTypeBuilder<BillDetails> builder)
        {
            builder.HasKey(x => x.Id);
            // Set khóa ngoại
            builder.HasOne(p=>p.Bill).WithMany(p=>p.Details).
                HasForeignKey(p=>p.BillID);
            builder.HasOne(p => p.Product).WithMany(p => p.Details).
                HasForeignKey(p => p.ProductID);
        }
    }
}

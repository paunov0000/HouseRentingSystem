﻿using HouseRentingSystem.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Infrastructure.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Cottage"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Single-Family"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Duplex"
                }
                );

        }
    }
}

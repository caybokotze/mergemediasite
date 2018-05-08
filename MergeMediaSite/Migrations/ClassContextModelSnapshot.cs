﻿// <auto-generated />
using MergeMediaSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MergeMediaSite.Migrations
{
    [DbContext(typeof(ClassContext))]
    partial class ClassContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MergeMediaSite.Models.HostingTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cores");

                    b.Property<string>("Instance");

                    b.Property<double>("Price");

                    b.Property<double>("Ram");

                    b.Property<double>("Storage");

                    b.HasKey("Id");

                    b.ToTable("HostingTables");
                });
#pragma warning restore 612, 618
        }
    }
}

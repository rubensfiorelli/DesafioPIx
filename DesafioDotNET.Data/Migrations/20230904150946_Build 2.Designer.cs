﻿// <auto-generated />
using System;
using DesafioDotNET.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesafioDotNET.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230904150946_Build 2")]
    partial class Build2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesafioDotNET.Domain.Entities.KeyPix", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KeyType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("DesafioDotNET.Domain.Entities.Payer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Payers");
                });

            modelBuilder.Entity("DesafioDotNET.Domain.Entities.Receiver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Receivers");
                });

            modelBuilder.Entity("DesafioDotNET.Domain.Entities.TransactionPix", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateTrans")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("PayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReceiverId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PayerId");

                    b.HasIndex("ReceiverId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("DesafioDotNET.Domain.Entities.TransactionPix", b =>
                {
                    b.HasOne("DesafioDotNET.Domain.Entities.Payer", "Payer")
                        .WithMany("Transactions")
                        .HasForeignKey("PayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesafioDotNET.Domain.Entities.Receiver", "Receiver")
                        .WithMany("Transactions")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payer");

                    b.Navigation("Receiver");
                });

            modelBuilder.Entity("DesafioDotNET.Domain.Entities.Payer", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("DesafioDotNET.Domain.Entities.Receiver", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}

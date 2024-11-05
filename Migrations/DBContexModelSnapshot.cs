﻿// <auto-generated />
using System;
using Meta_xi.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Meta_xi.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Meta_xi.Application.Plan", b =>
                {
                    b.Property<int>("IDPlan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDPlan"));

                    b.Property<double>("DailyBenefit")
                        .HasColumnType("double precision");

                    b.Property<int>("DaysActive")
                        .HasColumnType("integer");

                    b.Property<int>("MaxQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<double>("TotalBenefit")
                        .HasColumnType("double precision");

                    b.HasKey("IDPlan");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("Meta_xi.Application.ReferLevel1", b =>
                {
                    b.Property<int>("IDReferLevel1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDReferLevel1"));

                    b.Property<int>("IDUserReferrer")
                        .HasColumnType("integer");

                    b.Property<string>("UniqueCodeReFerred")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UniqueCodeReferrer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IDReferLevel1");

                    b.HasIndex("IDUserReferrer");

                    b.ToTable("ReferLevel1s");
                });

            modelBuilder.Entity("Meta_xi.Application.ReferLevel2", b =>
                {
                    b.Property<int>("IDReferLevel1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDReferLevel1"));

                    b.Property<int>("IDUserReferrer")
                        .HasColumnType("integer");

                    b.Property<string>("UniqueCodeReFerred")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UniqueCodeReferrer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IDReferLevel1");

                    b.HasIndex("IDUserReferrer");

                    b.ToTable("ReferLevel2s");
                });

            modelBuilder.Entity("Meta_xi.Application.ReferLevel3", b =>
                {
                    b.Property<int>("IDReferLevel1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDReferLevel1"));

                    b.Property<int>("IDUserReferrer")
                        .HasColumnType("integer");

                    b.Property<string>("UniqueCodeReFerred")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UniqueCodeReferrer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IDReferLevel1");

                    b.HasIndex("IDUserReferrer");

                    b.ToTable("ReferLevel3s");
                });

            modelBuilder.Entity("Meta_xi.Application.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("WalletIdWallet")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WalletIdWallet");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Meta_xi.Application.Wallet", b =>
                {
                    b.Property<int>("IdWallet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdWallet"));

                    b.Property<float>("Balance")
                        .HasColumnType("real");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdWallet");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("Meta_xi.Application.ReferLevel1", b =>
                {
                    b.HasOne("Meta_xi.Application.User", "User")
                        .WithMany("referLevel1s")
                        .HasForeignKey("IDUserReferrer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Meta_xi.Application.ReferLevel2", b =>
                {
                    b.HasOne("Meta_xi.Application.User", "User")
                        .WithMany("referLevel2s")
                        .HasForeignKey("IDUserReferrer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Meta_xi.Application.ReferLevel3", b =>
                {
                    b.HasOne("Meta_xi.Application.User", "User")
                        .WithMany("referLevel3s")
                        .HasForeignKey("IDUserReferrer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Meta_xi.Application.User", b =>
                {
                    b.HasOne("Meta_xi.Application.Wallet", "Wallet")
                        .WithMany()
                        .HasForeignKey("WalletIdWallet");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("Meta_xi.Application.User", b =>
                {
                    b.Navigation("referLevel1s");

                    b.Navigation("referLevel2s");

                    b.Navigation("referLevel3s");
                });
#pragma warning restore 612, 618
        }
    }
}

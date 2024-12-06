﻿// <auto-generated />
using System;
using Domic.Persistence.Contexts.C;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Domic.Persistence.Migrations.C
{
    [DbContext(typeof(SQLContext))]
    [Migration("20241206151525_AddBankGatewayEntity")]
    partial class AddBankGatewayEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domic.Core.Domain.Entities.ConsumerEvent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CountOfRetry")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt_EnglishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedAt_PersianDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConsumerEvents", (string)null);
                });

            modelBuilder.Entity("Domic.Core.Domain.Entities.Event", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt_EnglishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedAt_PersianDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<string>("Payload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Service")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Table")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt_EnglishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedAt_PersianDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Events", (string)null);
                });

            modelBuilder.Entity("Domic.Domain.Account.Entities.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("IsActive")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id", "IsDeleted");

                    b.ToTable("Accounts", (string)null);
                });

            modelBuilder.Entity("Domic.Domain.Transaction.Entities.BankGatewayLogHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("IsActive")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint");

                    b.Property<string>("SecretConnectionKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TransactionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId");

                    b.HasIndex("Id", "IsDeleted");

                    b.ToTable("LogHistories");
                });

            modelBuilder.Entity("Domic.Domain.Transaction.Entities.Transaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("IsActive")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint");

                    b.Property<byte>("TransactionType")
                        .HasColumnType("tinyint");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("Id", "IsDeleted");

                    b.ToTable("Transactions", (string)null);
                });

            modelBuilder.Entity("Domic.Domain.Account.Entities.Account", b =>
                {
                    b.OwnsOne("Domic.Domain.Commons.ValueObjects.Amount", "Balance", b1 =>
                        {
                            b1.Property<string>("AccountId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<long?>("Value")
                                .IsRequired()
                                .HasColumnType("bigint")
                                .HasColumnName("Balance");

                            b1.HasKey("AccountId");

                            b1.ToTable("Accounts");

                            b1.WithOwner()
                                .HasForeignKey("AccountId");
                        });

                    b.OwnsOne("Domic.Core.Domain.ValueObjects.CreatedAt", "CreatedAt", b1 =>
                        {
                            b1.Property<string>("AccountId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<DateTime?>("EnglishDate")
                                .IsRequired()
                                .HasColumnType("datetime2")
                                .HasColumnName("CreatedAt_EnglishDate");

                            b1.Property<string>("PersianDate")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CreatedAt_PersianDate");

                            b1.HasKey("AccountId");

                            b1.ToTable("Accounts");

                            b1.WithOwner()
                                .HasForeignKey("AccountId");
                        });

                    b.OwnsOne("Domic.Core.Domain.ValueObjects.UpdatedAt", "UpdatedAt", b1 =>
                        {
                            b1.Property<string>("AccountId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<DateTime?>("EnglishDate")
                                .HasColumnType("datetime2")
                                .HasColumnName("UpdatedAt_EnglishDate");

                            b1.Property<string>("PersianDate")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("UpdatedAt_PersianDate");

                            b1.HasKey("AccountId");

                            b1.ToTable("Accounts");

                            b1.WithOwner()
                                .HasForeignKey("AccountId");
                        });

                    b.Navigation("Balance");

                    b.Navigation("CreatedAt")
                        .IsRequired();

                    b.Navigation("UpdatedAt");
                });

            modelBuilder.Entity("Domic.Domain.Transaction.Entities.BankGatewayLogHistory", b =>
                {
                    b.HasOne("Domic.Domain.Transaction.Entities.Transaction", "Transaction")
                        .WithMany("LogHistories")
                        .HasForeignKey("TransactionId");

                    b.OwnsOne("Domic.Core.Domain.ValueObjects.CreatedAt", "CreatedAt", b1 =>
                        {
                            b1.Property<string>("BankGatewayLogHistoryId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<DateTime?>("EnglishDate")
                                .IsRequired()
                                .HasColumnType("datetime2")
                                .HasColumnName("CreatedAt_EnglishDate");

                            b1.Property<string>("PersianDate")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CreatedAt_PersianDate");

                            b1.HasKey("BankGatewayLogHistoryId");

                            b1.ToTable("LogHistories");

                            b1.WithOwner()
                                .HasForeignKey("BankGatewayLogHistoryId");
                        });

                    b.OwnsOne("Domic.Core.Domain.ValueObjects.UpdatedAt", "UpdatedAt", b1 =>
                        {
                            b1.Property<string>("BankGatewayLogHistoryId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<DateTime?>("EnglishDate")
                                .HasColumnType("datetime2")
                                .HasColumnName("UpdatedAt_EnglishDate");

                            b1.Property<string>("PersianDate")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("UpdatedAt_PersianDate");

                            b1.HasKey("BankGatewayLogHistoryId");

                            b1.ToTable("LogHistories");

                            b1.WithOwner()
                                .HasForeignKey("BankGatewayLogHistoryId");
                        });

                    b.Navigation("CreatedAt")
                        .IsRequired();

                    b.Navigation("Transaction");

                    b.Navigation("UpdatedAt");
                });

            modelBuilder.Entity("Domic.Domain.Transaction.Entities.Transaction", b =>
                {
                    b.HasOne("Domic.Domain.Account.Entities.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Domic.Core.Domain.ValueObjects.CreatedAt", "CreatedAt", b1 =>
                        {
                            b1.Property<string>("TransactionId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<DateTime?>("EnglishDate")
                                .IsRequired()
                                .HasColumnType("datetime2")
                                .HasColumnName("CreatedAt_EnglishDate");

                            b1.Property<string>("PersianDate")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CreatedAt_PersianDate");

                            b1.HasKey("TransactionId");

                            b1.ToTable("Transactions");

                            b1.WithOwner()
                                .HasForeignKey("TransactionId");
                        });

                    b.OwnsOne("Domic.Domain.Commons.ValueObjects.Amount", "DecreasedAmount", b1 =>
                        {
                            b1.Property<string>("TransactionId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<long?>("Value")
                                .HasColumnType("bigint")
                                .HasColumnName("DecreasedAmount");

                            b1.HasKey("TransactionId");

                            b1.ToTable("Transactions");

                            b1.WithOwner()
                                .HasForeignKey("TransactionId");
                        });

                    b.OwnsOne("Domic.Domain.Commons.ValueObjects.Amount", "IncreasedAmount", b1 =>
                        {
                            b1.Property<string>("TransactionId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<long?>("Value")
                                .HasColumnType("bigint")
                                .HasColumnName("IncreasedAmount");

                            b1.HasKey("TransactionId");

                            b1.ToTable("Transactions");

                            b1.WithOwner()
                                .HasForeignKey("TransactionId");
                        });

                    b.OwnsOne("Domic.Core.Domain.ValueObjects.UpdatedAt", "UpdatedAt", b1 =>
                        {
                            b1.Property<string>("TransactionId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<DateTime?>("EnglishDate")
                                .HasColumnType("datetime2")
                                .HasColumnName("UpdatedAt_EnglishDate");

                            b1.Property<string>("PersianDate")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("UpdatedAt_PersianDate");

                            b1.HasKey("TransactionId");

                            b1.ToTable("Transactions");

                            b1.WithOwner()
                                .HasForeignKey("TransactionId");
                        });

                    b.Navigation("Account");

                    b.Navigation("CreatedAt")
                        .IsRequired();

                    b.Navigation("DecreasedAmount");

                    b.Navigation("IncreasedAmount");

                    b.Navigation("UpdatedAt");
                });

            modelBuilder.Entity("Domic.Domain.Account.Entities.Account", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Domic.Domain.Transaction.Entities.Transaction", b =>
                {
                    b.Navigation("LogHistories");
                });
#pragma warning restore 612, 618
        }
    }
}

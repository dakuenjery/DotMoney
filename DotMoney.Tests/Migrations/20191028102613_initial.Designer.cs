﻿// <auto-generated />
using DotMoney.Tests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotMoney.Tests.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191028102613_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("DotMoney.Tests.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DotMoney.Tests.Product", b =>
                {
                    b.OwnsOne("DotMoney.Money", "Price", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("INTEGER");

                            b1.Property<decimal>("Amount")
                                .HasColumnName("Price")
                                .HasColumnType("TEXT");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");

                            b1.OwnsOne("DotMoney.Currency", "Currency", b2 =>
                                {
                                    b2.Property<int>("MoneyProductId")
                                        .HasColumnType("INTEGER");

                                    b2.Property<string>("IsoCode")
                                        .IsRequired()
                                        .HasColumnName("Currency")
                                        .HasColumnType("TEXT");

                                    b2.HasKey("MoneyProductId");

                                    b2.ToTable("Products");

                                    b2.WithOwner()
                                        .HasForeignKey("MoneyProductId");
                                });
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

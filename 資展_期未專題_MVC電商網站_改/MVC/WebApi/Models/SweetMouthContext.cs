﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi.Models
{
    public partial class SweetMouthContext : DbContext
    {
        public SweetMouthContext()
        {
        }

        public SweetMouthContext(DbContextOptions<SweetMouthContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<CusCake> CusCake { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.Floor })
                    .HasName("PK__Blog__F29BE1217B53236E");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.Article).HasMaxLength(1000);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SubTitle).HasMaxLength(100);

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Blog)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Blog__MemberID__6383C8BA");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Blog)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Blog__ProductID__6477ECF3");
            });

            modelBuilder.Entity<CusCake>(entity =>
            {
                entity.Property(e => e.CusCakeId).HasColumnName("CusCakeID");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.ForWho).HasMaxLength(50);

                entity.Property(e => e.Hate).HasMaxLength(50);

                entity.Property(e => e.Like).HasMaxLength(50);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.Purpose).HasMaxLength(1000);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.CusCake)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CusCake__MemberI__71D1E811");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.HasKey(e => e.DiscountCode)
                    .HasName("PK__Discount__A1120AF41716907D");

                entity.Property(e => e.DiscountCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Discount1).HasColumnName("Discount");

                entity.Property(e => e.DueDate).HasColumnType("date");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FavoriteProduct)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Permission).HasDefaultValueSql("((0))");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Amount).HasDefaultValueSql("((1))");

                entity.Property(e => e.Delivary).HasMaxLength(50);

                entity.Property(e => e.DiscountCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.DiscountCodeNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.DiscountCode)
                    .HasConstraintName("FK__Order__DiscountC__02FC7413");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__MemberID__01142BA1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Order__ProductID__02084FDA");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Avalible).HasDefaultValueSql("((1))");

                entity.Property(e => e.Category)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('????')");

                entity.Property(e => e.Flavor).HasMaxLength(200);

                entity.Property(e => e.ImageName).HasMaxLength(300);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Tag).HasMaxLength(200);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("PK__Schedule__77387D0605D7B36D");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Note).HasMaxLength(800);

                entity.Property(e => e.PeopleNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK__Schedule__Member__6754599E");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Schedule__Produc__68487DD7");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
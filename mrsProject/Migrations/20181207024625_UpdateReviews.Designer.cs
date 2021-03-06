﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mrsProject.DAL;

namespace mrsProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181207024625_UpdateReviews")]
    partial class UpdateReviews
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("mrsProject.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("ActiveStatus");

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreditCard1");

                    b.Property<int>("CreditCard1Type");

                    b.Property<string>("CreditCard2");

                    b.Property<int>("CreditCard2Type");

                    b.Property<string>("CreditCard3");

                    b.Property<int>("CreditCard3Type");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<int?>("InventoryID");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("SeedPassword");

                    b.Property<string>("State");

                    b.Property<string>("TempRole");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.HasIndex("InventoryID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("mrsProject.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ActiveStatus");

                    b.Property<string>("Author");

                    b.Property<string>("BookDescription");

                    b.Property<int>("BookUniqueID");

                    b.Property<decimal>("Cost");

                    b.Property<int?>("GenreID");

                    b.Property<int?>("InventoryID");

                    b.Property<bool>("ItemInStock");

                    b.Property<DateTime>("LastOrderDate");

                    b.Property<int>("NumInStock");

                    b.Property<int>("NumPurchased");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("PublicationDate");

                    b.Property<int>("ReOrder");

                    b.Property<decimal>("SimpleRating");

                    b.Property<string>("Title");

                    b.HasKey("BookID");

                    b.HasIndex("GenreID");

                    b.HasIndex("InventoryID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("mrsProject.Models.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CouponCode");

                    b.Property<bool>("DiscountActive");

                    b.Property<decimal>("DiscountNum");

                    b.HasKey("DiscountID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("mrsProject.Models.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("mrsProject.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InventoryQuantity");

                    b.Property<int>("ReorderPoint");

                    b.Property<decimal>("ReorderPrice");

                    b.HasKey("InventoryID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("mrsProject.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DiscountID");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("OrderNotes");

                    b.Property<int>("OrderNumber");

                    b.Property<decimal>("OrderSubtotal");

                    b.Property<string>("PaymentMethod");

                    b.Property<bool>("PendingOrder");

                    b.Property<decimal>("ShippingCost");

                    b.Property<string>("userId");

                    b.HasKey("OrderID");

                    b.HasIndex("DiscountID");

                    b.HasIndex("userId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("mrsProject.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookID");

                    b.Property<decimal>("OrderDetailPrice");

                    b.Property<decimal>("OrderExtendedPrice");

                    b.Property<int?>("OrderID");

                    b.Property<int>("OrderQuantity");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("BookID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("mrsProject.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Approved");

                    b.Property<string>("ApproverId");

                    b.Property<string>("AuthorId");

                    b.Property<int?>("BookID");

                    b.Property<decimal>("Rating")
                        .HasMaxLength(5);

                    b.Property<string>("ReviewDescription")
                        .HasMaxLength(100);

                    b.HasKey("ReviewID");

                    b.HasIndex("ApproverId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("mrsProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("mrsProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mrsProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("mrsProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mrsProject.Models.AppUser", b =>
                {
                    b.HasOne("mrsProject.Models.Inventory")
                        .WithMany("Users")
                        .HasForeignKey("InventoryID");
                });

            modelBuilder.Entity("mrsProject.Models.Book", b =>
                {
                    b.HasOne("mrsProject.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreID");

                    b.HasOne("mrsProject.Models.Inventory", "Inventory")
                        .WithMany("Books")
                        .HasForeignKey("InventoryID");
                });

            modelBuilder.Entity("mrsProject.Models.Order", b =>
                {
                    b.HasOne("mrsProject.Models.Discount")
                        .WithMany("Orders")
                        .HasForeignKey("DiscountID");

                    b.HasOne("mrsProject.Models.AppUser", "user")
                        .WithMany("Orders")
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("mrsProject.Models.OrderDetail", b =>
                {
                    b.HasOne("mrsProject.Models.Book", "Book")
                        .WithMany("OrderDetails")
                        .HasForeignKey("BookID");

                    b.HasOne("mrsProject.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("mrsProject.Models.Review", b =>
                {
                    b.HasOne("mrsProject.Models.AppUser", "Approver")
                        .WithMany("ReviewsApproved")
                        .HasForeignKey("ApproverId");

                    b.HasOne("mrsProject.Models.AppUser", "Author")
                        .WithMany("ReviewsWritten")
                        .HasForeignKey("AuthorId");

                    b.HasOne("mrsProject.Models.Book", "book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookID");
                });
#pragma warning restore 612, 618
        }
    }
}

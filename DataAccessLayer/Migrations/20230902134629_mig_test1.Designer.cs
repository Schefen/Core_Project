﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230902134629_mig_test1")]
    partial class mig_test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutId"), 1L, 1);

                    b.Property<string>("AboutAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutAge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"), 1L, 1);

                    b.Property<string>("ContactDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExperienceId"), 1L, 1);

                    b.Property<string>("ExperienceDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExperienceId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeatureId"), 1L, 1);

                    b.Property<string>("FeatureHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"), 1L, 1);

                    b.Property<string>("MessageContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MessageStatus")
                        .HasColumnType("bit");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Portfolio", b =>
                {
                    b.Property<int>("PortfolioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PortfolioId"), 1L, 1);

                    b.Property<string>("PortfolioImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioImage3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioImage4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioImageUrl2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioPlatform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PortfolioRatio")
                        .HasColumnType("int");

                    b.Property<bool?>("PortfolioStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PortfolioUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PortfolioId");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"), 1L, 1);

                    b.Property<string>("ServiceImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"), 1L, 1);

                    b.Property<string>("SkillTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SocialMedia", b =>
                {
                    b.Property<int>("SocialMediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocialMediaId"), 1L, 1);

                    b.Property<string>("SocialMediaIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMediaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SocialMediaStatus")
                        .HasColumnType("bit");

                    b.Property<string>("SocialMediaUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialMediaId");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Test1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Test1s");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Testimonial", b =>
                {
                    b.Property<int>("TestimonialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestimonialId"), 1L, 1);

                    b.Property<string>("ClientComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestimonialId");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ToDoList", b =>
                {
                    b.Property<int>("ToDoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ToDoId"), 1L, 1);

                    b.Property<string>("ToDoContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ToDoStatus")
                        .HasColumnType("bit");

                    b.HasKey("ToDoId");

                    b.ToTable("ToDoLists");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("UserImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UserStatus")
                        .HasColumnType("bit");

                    b.Property<string>("UserSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.UserMessage", b =>
                {
                    b.Property<int>("UserMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserMessageId"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserMessageContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UserMessageDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("UserMessageStatus")
                        .HasColumnType("bit");

                    b.Property<string>("UserMessageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserMessageId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMessages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.UserMessage", b =>
                {
                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("UserMessages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Navigation("UserMessages");
                });
#pragma warning restore 612, 618
        }
    }
}

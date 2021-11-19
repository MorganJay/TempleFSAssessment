﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempleFSAssessment.Data;

namespace TempleFSAssessment.Migrations
{
    [DbContext(typeof(DictionaryDbContext))]
    [Migration("20211119074315_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TempleFSAssessment.Data.Entities.WordDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emoji")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Example")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Word")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Word");

                    b.ToTable("WordDefinitions");
                });

            modelBuilder.Entity("TempleFSAssessment.Data.Entities.WordModel", b =>
                {
                    b.Property<string>("Word")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Definitions")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pronunciation")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Word");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("TempleFSAssessment.Data.Entities.WordDefinition", b =>
                {
                    b.HasOne("TempleFSAssessment.Data.Entities.WordModel", "WordEntity")
                        .WithMany("WordDefinitions")
                        .HasForeignKey("Word");

                    b.Navigation("WordEntity");
                });

            modelBuilder.Entity("TempleFSAssessment.Data.Entities.WordModel", b =>
                {
                    b.Navigation("WordDefinitions");
                });
#pragma warning restore 612, 618
        }
    }
}

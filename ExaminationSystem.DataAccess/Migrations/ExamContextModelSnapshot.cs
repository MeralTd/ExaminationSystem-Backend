﻿// <auto-generated />
using System;
using ExaminationSystem.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExaminationSystem.DataAccess.Migrations
{
    [DbContext(typeof(ExamContext))]
    partial class ExamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExaminationSystem.Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Yönetici"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Öğrenci"
                        });
                });

            modelBuilder.Entity("ExaminationSystem.Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Email = "meral@gmail.com",
                            FirstName = "Meral",
                            LastName = "Taşdemir",
                            PasswordHash = new byte[] { 194, 235, 176, 64, 44, 213, 99, 231, 66, 184, 19, 128, 73, 201, 201, 193, 5, 169, 61, 24, 157, 68, 144, 168, 125, 255, 232, 87, 146, 9, 177, 98, 48, 204, 178, 130, 239, 135, 124, 154, 32, 85, 96, 200, 172, 127, 144, 60, 48, 241, 117, 139, 189, 206, 252, 92, 126, 231, 86, 86, 32, 87, 118, 24 },
                            PasswordSalt = new byte[] { 206, 90, 177, 53, 97, 156, 201, 162, 189, 110, 18, 67, 53, 70, 216, 113, 146, 143, 179, 242, 140, 34, 63, 232, 127, 89, 11, 91, 132, 252, 75, 226, 164, 40, 158, 130, 96, 59, 166, 123, 26, 107, 182, 140, 27, 255, 234, 7, 231, 186, 186, 174, 57, 194, 141, 83, 142, 199, 231, 48, 97, 217, 24, 101, 254, 196, 168, 120, 113, 82, 119, 28, 124, 84, 233, 66, 139, 35, 155, 195, 232, 148, 201, 218, 222, 244, 54, 67, 162, 193, 50, 228, 110, 128, 201, 161, 111, 60, 236, 81, 38, 139, 83, 177, 228, 5, 29, 182, 93, 153, 249, 134, 96, 186, 122, 103, 67, 39, 190, 224, 29, 84, 122, 196, 132, 26, 10, 160 },
                            Status = false
                        },
                        new
                        {
                            Id = 1,
                            Email = "fikret@gmail.com",
                            FirstName = "Fikret",
                            LastName = "Yeşilyayla",
                            PasswordHash = new byte[] { 91, 5, 224, 205, 85, 182, 78, 37, 135, 138, 42, 193, 166, 234, 143, 255, 64, 222, 105, 251, 26, 222, 254, 161, 69, 85, 245, 50, 34, 19, 136, 117, 166, 40, 239, 181, 241, 90, 62, 26, 55, 142, 170, 0, 58, 29, 255, 78, 227, 7, 116, 213, 33, 200, 138, 176, 160, 67, 0, 221, 78, 192, 165, 116 },
                            PasswordSalt = new byte[] { 43, 184, 60, 35, 4, 89, 223, 134, 38, 144, 237, 165, 46, 179, 192, 154, 145, 127, 46, 135, 94, 110, 195, 13, 248, 235, 200, 13, 234, 234, 97, 94, 186, 10, 79, 239, 202, 225, 192, 111, 150, 144, 227, 205, 173, 209, 229, 62, 31, 89, 115, 71, 31, 214, 52, 117, 210, 232, 152, 201, 246, 196, 20, 65, 56, 103, 196, 246, 222, 88, 179, 109, 92, 244, 15, 67, 151, 228, 18, 17, 151, 178, 36, 230, 77, 81, 230, 7, 111, 172, 103, 171, 161, 211, 199, 159, 227, 67, 208, 149, 201, 242, 12, 20, 170, 42, 232, 30, 136, 194, 220, 6, 35, 222, 223, 29, 182, 129, 88, 110, 65, 146, 251, 93, 105, 67, 142, 144 },
                            Status = false
                        });
                });

            modelBuilder.Entity("ExaminationSystem.Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("UserId", "OperationClaimId");

                    b.HasIndex("OperationClaimId");

                    b.ToTable("UserOperationClaims");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            OperationClaimId = 1,
                            Id = 1
                        },
                        new
                        {
                            UserId = 2,
                            OperationClaimId = 2,
                            Id = 2
                        });
                });

            modelBuilder.Entity("ExaminationSystem.Entities.Concrete.Choice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Correct")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("ExaminationSystem.Entities.Concrete.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ExaminationSystem.Entities.Concrete.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ExaminationSystem.Entities.Concrete.UserExam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnswerSheet")
                        .HasColumnType("int");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("UserId");

                    b.ToTable("UserExams");
                });

            modelBuilder.Entity("ExaminationSystem.Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.HasOne("ExaminationSystem.Core.Entities.Concrete.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystem.Core.Entities.Concrete.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExaminationSystem.Entities.Concrete.Choice", b =>
                {
                    b.HasOne("ExaminationSystem.Entities.Concrete.Question", "Question")
                        .WithMany("Choices")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ExaminationSystem.Entities.Concrete.Question", b =>
                {
                    b.HasOne("ExaminationSystem.Entities.Concrete.Exam", "Exam")
                        .WithMany("Questions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("ExaminationSystem.Entities.Concrete.UserExam", b =>
                {
                    b.HasOne("ExaminationSystem.Entities.Concrete.Exam", "Exam")
                        .WithMany("UserExams")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystem.Core.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExaminationSystem.Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("ExaminationSystem.Core.Entities.Concrete.User", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("ExaminationSystem.Entities.Concrete.Exam", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("UserExams");
                });

            modelBuilder.Entity("ExaminationSystem.Entities.Concrete.Question", b =>
                {
                    b.Navigation("Choices");
                });
#pragma warning restore 612, 618
        }
    }
}

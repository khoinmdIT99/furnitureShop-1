﻿// <auto-generated />
using System;
using Domain.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DatabaseTools.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20200720042703_InitMenuManagement")]
    partial class InitMenuManagement
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Domain.Application.Entities.Menu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Controller")
                        .IsRequired()
                        .HasColumnName("CONTROLLER")
                        .HasColumnType("text");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("DISPLAY_NAME")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("HierarchyCode")
                        .IsRequired()
                        .HasColumnName("HIERARCHY_CODE")
                        .HasColumnType("text");

                    b.Property<string>("Icon")
                        .HasColumnName("ICON")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Order")
                        .HasColumnName("ORDER")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("MENUS");
                });

            modelBuilder.Entity("Domain.Application.Entities.MenuRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MenuId")
                        .HasColumnName("MENU_ID")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("RoleId")
                        .HasColumnName("ROLE_ID")
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("MENU_ROLE");
                });

            modelBuilder.Entity("Domain.Application.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnName("CREATE_AT")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CREATE_BY")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastUpdateAt")
                        .HasColumnName("LAST_UPDATE_AT")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastUpdateBy")
                        .HasColumnName("LAST_UPDATE_BY")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("RoleCode")
                        .HasColumnName("ROLE_CODE")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("RoleName")
                        .HasColumnName("ROLE_NAME")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ROLES");
                });

            modelBuilder.Entity("Domain.Application.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnName("CREATE_AT")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CREATE_BY")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("DayOfBirth")
                        .HasColumnName("DAY_OF_BIRTH")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnName("EMAIL")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("FullName")
                        .HasColumnName("FULL_NAME")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("Gender")
                        .HasColumnName("GENDER")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastUpdateAt")
                        .HasColumnName("LAST_UPDATE_AT")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastUpdateBy")
                        .HasColumnName("LAST_UPDATE_BY")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnName("PASSWORD")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("PhoneNo")
                        .HasColumnName("PHONE_NO")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UserName")
                        .HasColumnName("USER_NAME")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("Domain.Application.Entities.UserRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("RoleId")
                        .HasColumnName("ROLE_ID")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UserId")
                        .HasColumnName("USER_ID")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("USER_ROLE");
                });

            modelBuilder.Entity("Domain.Application.Entities.MenuRole", b =>
                {
                    b.HasOne("Domain.Application.Entities.Menu", null)
                        .WithMany("MenuRoles")
                        .HasForeignKey("MenuId");

                    b.HasOne("Domain.Application.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Domain.Application.Entities.UserRole", b =>
                {
                    b.HasOne("Domain.Application.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Domain.Application.Entities.User", "User")
                        .WithMany("UserRole")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}

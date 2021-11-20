using System;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabaseClient.DbModels
{
    public partial class MaiDbLbContext : DbContext
    {
        public MaiDbLbContext()
        {
        }

        public MaiDbLbContext(DbContextOptions<MaiDbLbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Archive> Archive { get; set; }
        public virtual DbSet<AvialableRooms> AvialableRooms { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Living> Living { get; set; }
        public virtual DbSet<PaidServices> PaidServices { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<RoomTypes> RoomTypes { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<ServiceList> ServiceList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(Properties.Settings.Default.MySQL_conn);
                #warning Enabled Logging SQL
                optionsBuilder.EnableSensitiveDataLogging();
                ILoggerFactory myLoggerFactory = LoggerFactory.Create(builder => {; });
                //ConsoleLoggerExtensions.AddConsole(myLoggerFactory);
                optionsBuilder.UseLoggerFactory(myLoggerFactory);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Archive>(entity =>
            {
                entity.HasComment("Архив записей");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.DateIn)
                    .HasColumnType("date")
                    .HasComment("Дата заселения");

                entity.Property(e => e.DateOut)
                    .HasColumnType("date")
                    .HasComment("Дата выселения");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("FIO")
                    .HasMaxLength(63)
                    .HasComment("ФИО клиента");

                entity.Property(e => e.Passport)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("Данные паспорта клиента");

                entity.Property(e => e.RoomNumber)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsFixedLength()
                    .HasComment("Номер комнаты");
            });

            modelBuilder.Entity<AvialableRooms>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Avialable_Rooms");

                entity.Property(e => e.Capacity)
                    .HasColumnType("tinyint(5) unsigned")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Вместимость");

                entity.Property(e => e.CheckIn)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Cost)
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'100'")
                    .HasComment("Стоимость");

                entity.Property(e => e.Id).HasColumnType("int(11) unsigned");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsFixedLength()
                    .HasComment("Номер");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Класс номера");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasComment("Счета на оплату");

                entity.HasIndex(e => e.ClientId)
                    .HasName("FK_Bill_Client");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Id клиента");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1023)
                    .HasComment("Содержание счета");

                entity.Property(e => e.SumLiving)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Сумма за проживание");

                entity.Property(e => e.SumPaidServices)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Сумма всех платных услуг");

                entity.Property(e => e.Total)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Итоговая сумма");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bill_Client");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasComment("Список клиентов");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Age)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Возраст");

                entity.Property(e => e.DateBirth)
                    .HasColumnType("date")
                    .HasComment("Дата рождения");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("FIO")
                    .HasMaxLength(63)
                    .HasComment("ФИО клиента / Название организации");

                entity.Property(e => e.Passport)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasComment("Серия и номер паспорта");

                entity.Property(e => e.Sex)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("Пол: муж 0 / жен 1");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasComment("Телефон");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("Тип: физ. лицо 0 / юр. лицо 1");
            });

            modelBuilder.Entity<Living>(entity =>
            {
                entity.HasComment("Проживание");

                entity.HasIndex(e => e.ClientId)
                    .HasName("FK_Living_Client");

                entity.HasIndex(e => e.RoomId)
                    .HasName("FK_Living_Rooms");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Id клиента");

                entity.Property(e => e.DateIn)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'")
                    .HasComment("Дата заселения");

                entity.Property(e => e.DateOut)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'")
                    .HasComment("Дата выселения");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Id номера");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Living)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Living_Client");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Living)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Living_Rooms");
            });

            modelBuilder.Entity<PaidServices>(entity =>
            {
                entity.ToTable("Paid_Services");

                entity.HasComment("Список платных услуг");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Cost)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'100'")
                    .HasComment("Стоимость услуги");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(127)
                    .HasComment("Название услуги");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasComment("Бронь номеров");

                entity.HasIndex(e => e.ClientId)
                    .HasName("Client");

                entity.HasIndex(e => e.RoomId)
                    .HasName("Room");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Id Клиента");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'2010-01-01'")
                    .HasComment("Дата истечения брони");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Id Номера");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Reservation)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Client");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Reservation)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Room");
            });

            modelBuilder.Entity<RoomTypes>(entity =>
            {
                entity.ToTable("Room_Types");

                entity.HasComment("Виды номеров и их стоимость на человека");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Cost)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'100'")
                    .HasComment("Стоимость номера такого класса на 1 человека");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasComment("Название класса номера");
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.HasComment("Список номеров отеля");

                entity.HasIndex(e => e.RoomNumber)
                    .HasName("Номер комнаты")
                    .IsUnique();

                entity.HasIndex(e => e.Type)
                    .HasName("Класс номера");

                entity.Property(e => e.Id).HasColumnType("int(11) unsigned");

                entity.Property(e => e.Busy)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("Занят");

                entity.Property(e => e.Capacity)
                    .HasColumnType("tinyint(5) unsigned")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Вместимость");

                entity.Property(e => e.Cost)
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'100'")
                    .HasComment("Стоимость");

                entity.Property(e => e.Reserved)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("Бронь");

                entity.Property(e => e.RoomNumber)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsFixedLength()
                    .HasComment("Номер");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Класс номера");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Класс номера");
            });

            modelBuilder.Entity<ServiceList>(entity =>
            {
                entity.ToTable("Service_List");

                entity.HasComment(@"Список оказанных услуг
");

                entity.HasIndex(e => e.PaidServiceId)
                    .HasName("FK_Service_List_Paid_Services");

                entity.HasIndex(e => e.RoomId)
                    .HasName("FK_Service_List_Rooms");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Count)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Кол-во ");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Дата оказания");

                entity.Property(e => e.PaidServiceId)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Id услуги");

                entity.Property(e => e.RoomId)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Id номера");

                entity.HasOne(d => d.PaidService)
                    .WithMany(p => p.ServiceList)
                    .HasForeignKey(d => d.PaidServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_List_Paid_Services");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.ServiceList)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_List_Rooms");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

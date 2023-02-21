﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TurkiyeBolgelerSehirler.Classes;

#nullable disable

namespace TurkiyeBolgelerSehirler.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    partial class UygulamaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TurkiyeBolgelerSehirler.Classes.Bolge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BolgeAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bolgeler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BolgeAd = "Akdeniz Bölgesi",
                            Slug = "akdeniz-bolgesi"
                        },
                        new
                        {
                            Id = 2,
                            BolgeAd = "Doğu Anadolu Bölgesi",
                            Slug = "dogu-anadolu-bolgesi"
                        },
                        new
                        {
                            Id = 3,
                            BolgeAd = "Ege Bölgesi",
                            Slug = "ege-bolgesi"
                        },
                        new
                        {
                            Id = 4,
                            BolgeAd = "Güneydoğu Anadolu Bölgesi",
                            Slug = "guneydogu-anadolu-bolgesi"
                        },
                        new
                        {
                            Id = 5,
                            BolgeAd = "İç Anadolu Bölgesi",
                            Slug = "ic-anadolu-bolgesi"
                        },
                        new
                        {
                            Id = 6,
                            BolgeAd = "Karadeniz Bölgesi",
                            Slug = "karadeniz-bolgesi"
                        },
                        new
                        {
                            Id = 7,
                            BolgeAd = "Marmara Bölgesi",
                            Slug = "marmara-bolgesi"
                        });
                });

            modelBuilder.Entity("TurkiyeBolgelerSehirler.Classes.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BolgeId")
                        .HasColumnType("int");

                    b.Property<int>("Nufus")
                        .HasColumnType("int");

                    b.Property<string>("SehirAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BolgeId");

                    b.ToTable("Sehirler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BolgeId = 1,
                            Nufus = 2201670,
                            SehirAd = "Adana",
                            Slug = "adana"
                        },
                        new
                        {
                            Id = 2,
                            BolgeId = 4,
                            Nufus = 610484,
                            SehirAd = "Adıyaman",
                            Slug = "adiyaman"
                        },
                        new
                        {
                            Id = 3,
                            BolgeId = 3,
                            Nufus = 714523,
                            SehirAd = "Afyonkarahisar",
                            Slug = "afyonkarahisar"
                        },
                        new
                        {
                            Id = 4,
                            BolgeId = 2,
                            Nufus = 542255,
                            SehirAd = "Ağrı",
                            Slug = "agri"
                        },
                        new
                        {
                            Id = 5,
                            BolgeId = 6,
                            Nufus = 326351,
                            SehirAd = "Amasya",
                            Slug = "amasya"
                        },
                        new
                        {
                            Id = 6,
                            BolgeId = 5,
                            Nufus = 5346518,
                            SehirAd = "Ankara",
                            Slug = "ankara"
                        },
                        new
                        {
                            Id = 7,
                            BolgeId = 1,
                            Nufus = 2328555,
                            SehirAd = "Antalya",
                            Slug = "antalya"
                        },
                        new
                        {
                            Id = 8,
                            BolgeId = 6,
                            Nufus = 168068,
                            SehirAd = "Artvin",
                            Slug = "artvin"
                        },
                        new
                        {
                            Id = 9,
                            BolgeId = 3,
                            Nufus = 1068260,
                            SehirAd = "Aydın",
                            Slug = "aydin"
                        },
                        new
                        {
                            Id = 10,
                            BolgeId = 7,
                            Nufus = 1196176,
                            SehirAd = "Balıkesir",
                            Slug = "balikesir"
                        },
                        new
                        {
                            Id = 11,
                            BolgeId = 7,
                            Nufus = 218297,
                            SehirAd = "Bilecik",
                            Slug = "bilecik"
                        },
                        new
                        {
                            Id = 12,
                            BolgeId = 2,
                            Nufus = 269560,
                            SehirAd = "Bingöl",
                            Slug = "bingol"
                        },
                        new
                        {
                            Id = 13,
                            BolgeId = 2,
                            Nufus = 341225,
                            SehirAd = "Bitlis",
                            Slug = "bitlis"
                        },
                        new
                        {
                            Id = 14,
                            BolgeId = 6,
                            Nufus = 299896,
                            SehirAd = "Bolu",
                            Slug = "bolu"
                        },
                        new
                        {
                            Id = 15,
                            BolgeId = 1,
                            Nufus = 261401,
                            SehirAd = "Burdur",
                            Slug = "burdur"
                        },
                        new
                        {
                            Id = 16,
                            BolgeId = 7,
                            Nufus = 2901396,
                            SehirAd = "Bursa",
                            Slug = "bursa"
                        },
                        new
                        {
                            Id = 17,
                            BolgeId = 7,
                            Nufus = 519793,
                            SehirAd = "Çanakkale",
                            Slug = "canakkale"
                        },
                        new
                        {
                            Id = 18,
                            BolgeId = 5,
                            Nufus = 183880,
                            SehirAd = "Çankırı",
                            Slug = "cankiri"
                        },
                        new
                        {
                            Id = 19,
                            BolgeId = 6,
                            Nufus = 527863,
                            SehirAd = "Çorum",
                            Slug = "corum"
                        },
                        new
                        {
                            Id = 20,
                            BolgeId = 3,
                            Nufus = 1005687,
                            SehirAd = "Denizli",
                            Slug = "denizli"
                        },
                        new
                        {
                            Id = 21,
                            BolgeId = 4,
                            Nufus = 1673119,
                            SehirAd = "Diyarbakır",
                            Slug = "diyarbakir"
                        },
                        new
                        {
                            Id = 22,
                            BolgeId = 7,
                            Nufus = 401701,
                            SehirAd = "Edirne",
                            Slug = "edirne"
                        },
                        new
                        {
                            Id = 23,
                            BolgeId = 2,
                            Nufus = 578789,
                            SehirAd = "Elazığ",
                            Slug = "elazig"
                        },
                        new
                        {
                            Id = 24,
                            BolgeId = 2,
                            Nufus = 226032,
                            SehirAd = "Erzincan",
                            Slug = "erzincan"
                        },
                        new
                        {
                            Id = 25,
                            BolgeId = 2,
                            Nufus = 762021,
                            SehirAd = "Erzurum",
                            Slug = "erzurum"
                        },
                        new
                        {
                            Id = 26,
                            BolgeId = 5,
                            Nufus = 844842,
                            SehirAd = "Eskişehir",
                            Slug = "eskisehir"
                        },
                        new
                        {
                            Id = 27,
                            BolgeId = 4,
                            Nufus = 1974244,
                            SehirAd = "Gaziantep",
                            Slug = "gaziantep"
                        },
                        new
                        {
                            Id = 28,
                            BolgeId = 6,
                            Nufus = 444467,
                            SehirAd = "Giresun",
                            Slug = "giresun"
                        },
                        new
                        {
                            Id = 29,
                            BolgeId = 6,
                            Nufus = 172034,
                            SehirAd = "Gümüşhane",
                            Slug = "gumushane"
                        },
                        new
                        {
                            Id = 30,
                            BolgeId = 2,
                            Nufus = 267813,
                            SehirAd = "Hakkari",
                            Slug = "hakkari"
                        },
                        new
                        {
                            Id = 31,
                            BolgeId = 1,
                            Nufus = 1555165,
                            SehirAd = "Hatay",
                            Slug = "hatay"
                        },
                        new
                        {
                            Id = 32,
                            BolgeId = 1,
                            Nufus = 427324,
                            SehirAd = "Isparta",
                            Slug = "isparta"
                        },
                        new
                        {
                            Id = 33,
                            BolgeId = 1,
                            Nufus = 1773852,
                            SehirAd = "Mersin",
                            Slug = "mersin"
                        },
                        new
                        {
                            Id = 34,
                            BolgeId = 7,
                            Nufus = 14804116,
                            SehirAd = "İstanbul",
                            Slug = "istanbul"
                        },
                        new
                        {
                            Id = 35,
                            BolgeId = 3,
                            Nufus = 4223545,
                            SehirAd = "İzmir",
                            Slug = "izmir"
                        },
                        new
                        {
                            Id = 36,
                            BolgeId = 2,
                            Nufus = 289786,
                            SehirAd = "Kars",
                            Slug = "kars"
                        },
                        new
                        {
                            Id = 37,
                            BolgeId = 6,
                            Nufus = 376945,
                            SehirAd = "Kastamonu",
                            Slug = "kastamonu"
                        },
                        new
                        {
                            Id = 38,
                            BolgeId = 5,
                            Nufus = 1358980,
                            SehirAd = "Kayseri",
                            Slug = "kayseri"
                        },
                        new
                        {
                            Id = 39,
                            BolgeId = 7,
                            Nufus = 351684,
                            SehirAd = "Kırklareli",
                            Slug = "kirklareli"
                        },
                        new
                        {
                            Id = 40,
                            BolgeId = 5,
                            Nufus = 229975,
                            SehirAd = "Kırşehir",
                            Slug = "kirsehir"
                        },
                        new
                        {
                            Id = 41,
                            BolgeId = 7,
                            Nufus = 1830772,
                            SehirAd = "Kocaeli",
                            Slug = "kocaeli"
                        },
                        new
                        {
                            Id = 42,
                            BolgeId = 5,
                            Nufus = 2161303,
                            SehirAd = "Konya",
                            Slug = "konya"
                        },
                        new
                        {
                            Id = 43,
                            BolgeId = 3,
                            Nufus = 573642,
                            SehirAd = "Kütahya",
                            Slug = "kutahya"
                        },
                        new
                        {
                            Id = 44,
                            BolgeId = 2,
                            Nufus = 781305,
                            SehirAd = "Malatya",
                            Slug = "malatya"
                        },
                        new
                        {
                            Id = 45,
                            BolgeId = 3,
                            Nufus = 1396945,
                            SehirAd = "Manisa",
                            Slug = "manisa"
                        },
                        new
                        {
                            Id = 46,
                            BolgeId = 1,
                            Nufus = 1112634,
                            SehirAd = "Kahramanmaraş",
                            Slug = "kahramanmaras"
                        },
                        new
                        {
                            Id = 47,
                            BolgeId = 4,
                            Nufus = 796237,
                            SehirAd = "Mardin",
                            Slug = "mardin"
                        },
                        new
                        {
                            Id = 48,
                            BolgeId = 3,
                            Nufus = 923773,
                            SehirAd = "Muğla",
                            Slug = "mugla"
                        },
                        new
                        {
                            Id = 49,
                            BolgeId = 2,
                            Nufus = 406501,
                            SehirAd = "Muş",
                            Slug = "mus"
                        },
                        new
                        {
                            Id = 50,
                            BolgeId = 5,
                            Nufus = 290895,
                            SehirAd = "Nevşehir",
                            Slug = "nevsehir"
                        },
                        new
                        {
                            Id = 51,
                            BolgeId = 5,
                            Nufus = 351468,
                            SehirAd = "Niğde",
                            Slug = "nigde"
                        },
                        new
                        {
                            Id = 52,
                            BolgeId = 6,
                            Nufus = 750588,
                            SehirAd = "Ordu",
                            Slug = "ordu"
                        },
                        new
                        {
                            Id = 53,
                            BolgeId = 6,
                            Nufus = 331048,
                            SehirAd = "Rize",
                            Slug = "rize"
                        },
                        new
                        {
                            Id = 54,
                            BolgeId = 7,
                            Nufus = 976948,
                            SehirAd = "Sakarya",
                            Slug = "sakarya"
                        },
                        new
                        {
                            Id = 55,
                            BolgeId = 6,
                            Nufus = 1295927,
                            SehirAd = "Samsun",
                            Slug = "samsun"
                        },
                        new
                        {
                            Id = 56,
                            BolgeId = 4,
                            Nufus = 322664,
                            SehirAd = "Siirt",
                            Slug = "siirt"
                        },
                        new
                        {
                            Id = 57,
                            BolgeId = 6,
                            Nufus = 205478,
                            SehirAd = "Sinop",
                            Slug = "sinop"
                        },
                        new
                        {
                            Id = 58,
                            BolgeId = 5,
                            Nufus = 621224,
                            SehirAd = "Sivas",
                            Slug = "sivas"
                        },
                        new
                        {
                            Id = 59,
                            BolgeId = 7,
                            Nufus = 972875,
                            SehirAd = "Tekirdağ",
                            Slug = "tekirdag"
                        },
                        new
                        {
                            Id = 60,
                            BolgeId = 6,
                            Nufus = 602662,
                            SehirAd = "Tokat",
                            Slug = "tokat"
                        },
                        new
                        {
                            Id = 61,
                            BolgeId = 6,
                            Nufus = 779379,
                            SehirAd = "Trabzon",
                            Slug = "trabzon"
                        },
                        new
                        {
                            Id = 62,
                            BolgeId = 2,
                            Nufus = 82193,
                            SehirAd = "Tunceli",
                            Slug = "tunceli"
                        },
                        new
                        {
                            Id = 63,
                            BolgeId = 4,
                            Nufus = 1940627,
                            SehirAd = "Şanlıurfa",
                            Slug = "sanliurfa"
                        },
                        new
                        {
                            Id = 64,
                            BolgeId = 3,
                            Nufus = 358736,
                            SehirAd = "Uşak",
                            Slug = "usak"
                        },
                        new
                        {
                            Id = 65,
                            BolgeId = 2,
                            Nufus = 1100190,
                            SehirAd = "Van",
                            Slug = "van"
                        },
                        new
                        {
                            Id = 66,
                            BolgeId = 5,
                            Nufus = 421041,
                            SehirAd = "Yozgat",
                            Slug = "yozgat"
                        },
                        new
                        {
                            Id = 67,
                            BolgeId = 6,
                            Nufus = 597524,
                            SehirAd = "Zonguldak",
                            Slug = "zonguldak"
                        },
                        new
                        {
                            Id = 68,
                            BolgeId = 5,
                            Nufus = 396673,
                            SehirAd = "Aksaray",
                            Slug = "aksaray"
                        },
                        new
                        {
                            Id = 69,
                            BolgeId = 6,
                            Nufus = 90154,
                            SehirAd = "Bayburt",
                            Slug = "bayburt"
                        },
                        new
                        {
                            Id = 70,
                            BolgeId = 5,
                            Nufus = 245610,
                            SehirAd = "Karaman",
                            Slug = "karaman"
                        },
                        new
                        {
                            Id = 71,
                            BolgeId = 5,
                            Nufus = 277984,
                            SehirAd = "Kırıkkale",
                            Slug = "kirikkale"
                        },
                        new
                        {
                            Id = 72,
                            BolgeId = 4,
                            Nufus = 576899,
                            SehirAd = "Batman",
                            Slug = "batman"
                        },
                        new
                        {
                            Id = 73,
                            BolgeId = 4,
                            Nufus = 483788,
                            SehirAd = "Şırnak",
                            Slug = "sirnak"
                        },
                        new
                        {
                            Id = 74,
                            BolgeId = 6,
                            Nufus = 192389,
                            SehirAd = "Bartın",
                            Slug = "bartin"
                        },
                        new
                        {
                            Id = 75,
                            BolgeId = 2,
                            Nufus = 98335,
                            SehirAd = "Ardahan",
                            Slug = "ardahan"
                        },
                        new
                        {
                            Id = 76,
                            BolgeId = 2,
                            Nufus = 192785,
                            SehirAd = "Iğdır",
                            Slug = "igdir"
                        },
                        new
                        {
                            Id = 77,
                            BolgeId = 7,
                            Nufus = 241665,
                            SehirAd = "Yalova",
                            Slug = "yalova"
                        },
                        new
                        {
                            Id = 78,
                            BolgeId = 6,
                            Nufus = 242347,
                            SehirAd = "Karabük",
                            Slug = "karabuk"
                        },
                        new
                        {
                            Id = 79,
                            BolgeId = 4,
                            Nufus = 130825,
                            SehirAd = "Kilis",
                            Slug = "kilis"
                        },
                        new
                        {
                            Id = 80,
                            BolgeId = 1,
                            Nufus = 522175,
                            SehirAd = "Osmaniye",
                            Slug = "osmaniye"
                        },
                        new
                        {
                            Id = 81,
                            BolgeId = 6,
                            Nufus = 370371,
                            SehirAd = "Düzce",
                            Slug = "duzce"
                        });
                });

            modelBuilder.Entity("TurkiyeBolgelerSehirler.Classes.Sehir", b =>
                {
                    b.HasOne("TurkiyeBolgelerSehirler.Classes.Bolge", "Bolge")
                        .WithMany("Sehirler")
                        .HasForeignKey("BolgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolge");
                });

            modelBuilder.Entity("TurkiyeBolgelerSehirler.Classes.Bolge", b =>
                {
                    b.Navigation("Sehirler");
                });
#pragma warning restore 612, 618
        }
    }
}

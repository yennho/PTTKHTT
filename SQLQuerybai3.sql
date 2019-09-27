/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     27/09/2019 9:48:52 AM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAN') and o.name = 'FK_BAN_BAN_SACH')
alter table BAN
   drop constraint FK_BAN_BAN_SACH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAN') and o.name = 'FK_BAN_BAN2_HOADON')
alter table BAN
   drop constraint FK_BAN_BAN2_HOADON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADON') and o.name = 'FK_HOADON_LAP_NHANVIEN')
alter table HOADON
   drop constraint FK_HOADON_LAP_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KESACH') and o.name = 'FK_KESACH_DAT_THELOAI')
alter table KESACH
   drop constraint FK_KESACH_DAT_THELOAI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KESACH') and o.name = 'FK_KESACH_QUANLY_CATRUC')
alter table KESACH
   drop constraint FK_KESACH_QUANLY_CATRUC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHAP') and o.name = 'FK_NHAP_NHAP_PHIEUNHA')
alter table NHAP
   drop constraint FK_NHAP_NHAP_PHIEUNHA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHAP') and o.name = 'FK_NHAP_NHAP2_SACH')
alter table NHAP
   drop constraint FK_NHAP_NHAP2_SACH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUNHAP') and o.name = 'FK_PHIEUNHA_GHI_NCC')
alter table PHIEUNHAP
   drop constraint FK_PHIEUNHA_GHI_NCC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SACH') and o.name = 'FK_SACH_THUOC_THELOAI')
alter table SACH
   drop constraint FK_SACH_THUOC_THELOAI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRUC') and o.name = 'FK_TRUC_TRUC_CATRUC')
alter table TRUC
   drop constraint FK_TRUC_TRUC_CATRUC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRUC') and o.name = 'FK_TRUC_TRUC2_NHANVIEN')
alter table TRUC
   drop constraint FK_TRUC_TRUC2_NHANVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BAN')
            and   name  = 'BAN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BAN.BAN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BAN')
            and   name  = 'BAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index BAN.BAN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BAN')
            and   type = 'U')
   drop table BAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATRUC')
            and   type = 'U')
   drop table CATRUC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADON')
            and   name  = 'LAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADON.LAP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADON')
            and   type = 'U')
   drop table HOADON
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KESACH')
            and   name  = 'QUANLY_FK'
            and   indid > 0
            and   indid < 255)
   drop index KESACH.QUANLY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KESACH')
            and   name  = 'DAT_FK'
            and   indid > 0
            and   indid < 255)
   drop index KESACH.DAT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KESACH')
            and   type = 'U')
   drop table KESACH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NCC')
            and   type = 'U')
   drop table NCC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHAP')
            and   name  = 'NHAP2_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHAP.NHAP2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHAP')
            and   name  = 'NHAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHAP.NHAP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHAP')
            and   type = 'U')
   drop table NHAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUNHAP')
            and   name  = 'GHI_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUNHAP.GHI_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUNHAP')
            and   type = 'U')
   drop table PHIEUNHAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SACH')
            and   name  = 'THUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index SACH.THUOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SACH')
            and   type = 'U')
   drop table SACH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THELOAI')
            and   type = 'U')
   drop table THELOAI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRUC')
            and   name  = 'TRUC2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRUC.TRUC2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRUC')
            and   name  = 'TRUC_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRUC.TRUC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRUC')
            and   type = 'U')
   drop table TRUC
go

/*==============================================================*/
/* Table: BAN                                                   */
/*==============================================================*/
create table BAN (
   MASACH               varchar(50)          not null,
   STTHDON              varchar(50)          not null,
   SOLUONGBAN           int                  null,
   constraint PK_BAN primary key (MASACH, STTHDON)
)
go

/*==============================================================*/
/* Index: BAN_FK                                                */
/*==============================================================*/
create index BAN_FK on BAN (
MASACH ASC
)
go

/*==============================================================*/
/* Index: BAN2_FK                                               */
/*==============================================================*/
create index BAN2_FK on BAN (
STTHDON ASC
)
go

/*==============================================================*/
/* Table: CATRUC                                                */
/*==============================================================*/
create table CATRUC (
   STTCATRUC            int                  not null,
   GIOBD                datetime             null,
   GIOKT                datetime             null,
   constraint PK_CATRUC primary key nonclustered (STTCATRUC)
)
go

/*==============================================================*/
/* Table: HOADON                                                */
/*==============================================================*/
create table HOADON (
   STTHDON              varchar(50)          not null,
   MANV                 varchar(50)          not null,
   NGAYMUA              datetime             null,
   SOLUONG              int                  null,
   DONGIA               money                null,
   THANHTIEN            money                null,
   TSOTIEN              money                null,
   constraint PK_HOADON primary key nonclustered (STTHDON)
)
go

/*==============================================================*/
/* Index: LAP_FK                                                */
/*==============================================================*/
create index LAP_FK on HOADON (
MANV ASC
)
go

/*==============================================================*/
/* Table: KESACH                                                */
/*==============================================================*/
create table KESACH (
   MAKSACH              int                  not null,
   MATL                 varchar(50)          not null,
   STTCATRUC            int                  not null,
   TENKS                varchar(100)         null,
   constraint PK_KESACH primary key nonclustered (MAKSACH)
)
go

/*==============================================================*/
/* Index: DAT_FK                                                */
/*==============================================================*/
create index DAT_FK on KESACH (
MATL ASC
)
go

/*==============================================================*/
/* Index: QUANLY_FK                                             */
/*==============================================================*/
create index QUANLY_FK on KESACH (
STTCATRUC ASC
)
go

/*==============================================================*/
/* Table: NCC                                                   */
/*==============================================================*/
create table NCC (
   MACC                 varchar(50)          not null,
   TENCC                varchar(200)         null,
   DTHOAI               varchar(10)          null,
   DIACHI               varchar(200)         null,
   constraint PK_NCC primary key nonclustered (MACC)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV                 varchar(50)          not null,
   HOTENNV              varchar(200)         null,
   GIOITINHNV           varchar(50)          null,
   DIACHINV             varchar(200)         null,
   DTHOAINV             varchar(10)          null,
   constraint PK_NHANVIEN primary key nonclustered (MANV)
)
go

/*==============================================================*/
/* Table: NHAP                                                  */
/*==============================================================*/
create table NHAP (
   STTNHAP              int                  not null,
   MASACH               varchar(50)          not null,
   SLNHAP               int                  null,
   GIANHAP              money                null,
   constraint PK_NHAP primary key (STTNHAP, MASACH)
)
go

/*==============================================================*/
/* Index: NHAP_FK                                               */
/*==============================================================*/
create index NHAP_FK on NHAP (
STTNHAP ASC
)
go

/*==============================================================*/
/* Index: NHAP2_FK                                              */
/*==============================================================*/
create index NHAP2_FK on NHAP (
MASACH ASC
)
go

/*==============================================================*/
/* Table: PHIEUNHAP                                             */
/*==============================================================*/
create table PHIEUNHAP (
   STTNHAP              int                  not null,
   MACC                 varchar(50)          not null,
   NGAYNHAP             datetime             null,
   DOTNHAP              int                  null,
   constraint PK_PHIEUNHAP primary key nonclustered (STTNHAP)
)
go

/*==============================================================*/
/* Index: GHI_FK                                                */
/*==============================================================*/
create index GHI_FK on PHIEUNHAP (
MACC ASC
)
go

/*==============================================================*/
/* Table: SACH                                                  */
/*==============================================================*/
create table SACH (
   MASACH               varchar(50)          not null,
   MATL                 varchar(50)          not null,
   TENSACH              varchar(200)         null,
   TACGIA               varchar(100)         null,
   NXB                  varchar(100)         null,
   GIABIA               money                null,
   constraint PK_SACH primary key nonclustered (MASACH)
)
go

/*==============================================================*/
/* Index: THUOC_FK                                              */
/*==============================================================*/
create index THUOC_FK on SACH (
MATL ASC
)
go

/*==============================================================*/
/* Table: THELOAI                                               */
/*==============================================================*/
create table THELOAI (
   MATL                 varchar(50)          not null,
   TENTL                varchar(200)         null,
   constraint PK_THELOAI primary key nonclustered (MATL)
)
go

/*==============================================================*/
/* Table: TRUC                                                  */
/*==============================================================*/
create table TRUC (
   STTCATRUC            int                  not null,
   MANV                 varchar(50)          not null,
   NGAYTRUC             char(10)             null,
   constraint PK_TRUC primary key (STTCATRUC, MANV)
)
go

/*==============================================================*/
/* Index: TRUC_FK                                               */
/*==============================================================*/
create index TRUC_FK on TRUC (
STTCATRUC ASC
)
go

/*==============================================================*/
/* Index: TRUC2_FK                                              */
/*==============================================================*/
create index TRUC2_FK on TRUC (
MANV ASC
)
go

alter table BAN
   add constraint FK_BAN_BAN_SACH foreign key (MASACH)
      references SACH (MASACH)
go

alter table BAN
   add constraint FK_BAN_BAN2_HOADON foreign key (STTHDON)
      references HOADON (STTHDON)
go

alter table HOADON
   add constraint FK_HOADON_LAP_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

alter table KESACH
   add constraint FK_KESACH_DAT_THELOAI foreign key (MATL)
      references THELOAI (MATL)
go

alter table KESACH
   add constraint FK_KESACH_QUANLY_CATRUC foreign key (STTCATRUC)
      references CATRUC (STTCATRUC)
go

alter table NHAP
   add constraint FK_NHAP_NHAP_PHIEUNHA foreign key (STTNHAP)
      references PHIEUNHAP (STTNHAP)
go

alter table NHAP
   add constraint FK_NHAP_NHAP2_SACH foreign key (MASACH)
      references SACH (MASACH)
go

alter table PHIEUNHAP
   add constraint FK_PHIEUNHA_GHI_NCC foreign key (MACC)
      references NCC (MACC)
go

alter table SACH
   add constraint FK_SACH_THUOC_THELOAI foreign key (MATL)
      references THELOAI (MATL)
go

alter table TRUC
   add constraint FK_TRUC_TRUC_CATRUC foreign key (STTCATRUC)
      references CATRUC (STTCATRUC)
go

alter table TRUC
   add constraint FK_TRUC_TRUC2_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

select * from TRUC

select * from NCC

select * from CATRUC

select * from NHANVIEN

select * from THELOAI

select * from PHIEUNHAP

select * from SACH

select * from NHAP

select * from HOADON

select * from BAN

select * from KESACH
/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     27/09/2019 7:55:41 AM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HKHAU') and o.name = 'FK_HKHAU_QUAN_LY_XA_PHUON')
alter table HKHAU
   drop constraint FK_HKHAU_QUAN_LY_XA_PHUON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHANKHAU') and o.name = 'FK_NHANKHAU_O_TRONG_HKHAU')
alter table NHANKHAU
   drop constraint FK_NHANKHAU_O_TRONG_HKHAU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('XA_PHUONG') and o.name = 'FK_XA_PHUON_THUOC_QUAN_HUY')
alter table XA_PHUONG
   drop constraint FK_XA_PHUON_THUOC_QUAN_HUY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HKHAU')
            and   name  = 'QUAN_LY_FK'
            and   indid > 0
            and   indid < 255)
   drop index HKHAU.QUAN_LY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HKHAU')
            and   type = 'U')
   drop table HKHAU
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHANKHAU')
            and   name  = 'O_TRONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHANKHAU.O_TRONG_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANKHAU')
            and   type = 'U')
   drop table NHANKHAU
go

if exists (select 1
            from  sysobjects
           where  id = object_id('QUAN_HUYEN')
            and   type = 'U')
   drop table QUAN_HUYEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('XA_PHUONG')
            and   name  = 'THUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index XA_PHUONG.THUOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('XA_PHUONG')
            and   type = 'U')
   drop table XA_PHUONG
go

/*==============================================================*/
/* Table: HKHAU                                                 */
/*==============================================================*/
create table HKHAU (
   SOSO                 varchar(20)          not null,
   MAX_P                varchar(20)          not null,
   TENCH                varchar(100)         null,
   SONHA                varchar(5)           null,
   TENDP                varchar(50)          null,
   KHUPHO               varchar(50)          null,
   constraint PK_HKHAU primary key nonclustered (SOSO)
)
go

/*==============================================================*/
/* Index: QUAN_LY_FK                                            */
/*==============================================================*/
create index QUAN_LY_FK on HKHAU (
MAX_P ASC
)
go

/*==============================================================*/
/* Table: NHANKHAU                                              */
/*==============================================================*/
create table NHANKHAU (
   STTNHANKHAU          int                  not null,
   SOSO                 varchar(20)          not null,
   HOTENNK              varchar(100)         null,
   GTINH                varchar(10)          null,
   NSINH                datetime             null,
   constraint PK_NHANKHAU primary key nonclustered (STTNHANKHAU)
)
go

/*==============================================================*/
/* Index: O_TRONG_FK                                            */
/*==============================================================*/
create index O_TRONG_FK on NHANKHAU (
SOSO ASC
)
go

/*==============================================================*/
/* Table: QUAN_HUYEN                                            */
/*==============================================================*/
create table QUAN_HUYEN (
   MAQ_H                varchar(20)          not null,
   TENQ_H               varchar(50)          null,
   constraint PK_QUAN_HUYEN primary key nonclustered (MAQ_H)
)
go

/*==============================================================*/
/* Table: XA_PHUONG                                             */
/*==============================================================*/
create table XA_PHUONG (
   MAX_P                varchar(20)          not null,
   MAQ_H                varchar(20)          not null,
   TENX_P               varchar(50)          null,
   constraint PK_XA_PHUONG primary key nonclustered (MAX_P)
)
go

/*==============================================================*/
/* Index: THUOC_FK                                              */
/*==============================================================*/
create index THUOC_FK on XA_PHUONG (
MAQ_H ASC
)
go

alter table HKHAU
   add constraint FK_HKHAU_QUAN_LY_XA_PHUON foreign key (MAX_P)
      references XA_PHUONG (MAX_P)
go

alter table NHANKHAU
   add constraint FK_NHANKHAU_O_TRONG_HKHAU foreign key (SOSO)
      references HKHAU (SOSO)
go

alter table XA_PHUONG
   add constraint FK_XA_PHUON_THUOC_QUAN_HUY foreign key (MAQ_H)
      references QUAN_HUYEN (MAQ_H)
go


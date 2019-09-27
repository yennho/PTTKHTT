/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     27/09/2019 9:11:31 AM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHANKHAU') and o.name = 'FK_NHANKHAU_CO_SOHOKHAU')
alter table NHANKHAU
   drop constraint FK_NHANKHAU_CO_SOHOKHAU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHUONGXA') and o.name = 'FK_PHUONGXA_THUOC_QUANHUYE')
alter table PHUONGXA
   drop constraint FK_PHUONGXA_THUOC_QUANHUYE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SOHOKHAU') and o.name = 'FK_SOHOKHAU_QUANLY_PHUONGXA')
alter table SOHOKHAU
   drop constraint FK_SOHOKHAU_QUANLY_PHUONGXA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHANKHAU')
            and   name  = 'CO_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHANKHAU.CO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANKHAU')
            and   type = 'U')
   drop table NHANKHAU
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHUONGXA')
            and   name  = 'THUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHUONGXA.THUOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHUONGXA')
            and   type = 'U')
   drop table PHUONGXA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('QUANHUYEN')
            and   type = 'U')
   drop table QUANHUYEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SOHOKHAU')
            and   name  = 'QUANLY_FK'
            and   indid > 0
            and   indid < 255)
   drop index SOHOKHAU.QUANLY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SOHOKHAU')
            and   type = 'U')
   drop table SOHOKHAU
go

/*==============================================================*/
/* Table: NHANKHAU                                              */
/*==============================================================*/
create table NHANKHAU (
   STTNK                int                  not null,
   SOSO                 int                  not null,
   HOTENNK              varchar(200)         null,
   GIOITINH             varchar(5)           null,
   NGAYSINH             datetime             null,
   constraint PK_NHANKHAU primary key nonclustered (STTNK)
)
go

/*==============================================================*/
/* Index: CO_FK                                                 */
/*==============================================================*/
create index CO_FK on NHANKHAU (
SOSO ASC
)
go

/*==============================================================*/
/* Table: PHUONGXA                                              */
/*==============================================================*/
create table PHUONGXA (
   MAPX                 varchar(50)          not null,
   MAQH                 varchar(50)          not null,
   TENPX                varchar(50)          null,
   constraint PK_PHUONGXA primary key nonclustered (MAPX)
)
go

/*==============================================================*/
/* Index: THUOC_FK                                              */
/*==============================================================*/
create index THUOC_FK on PHUONGXA (
MAQH ASC
)
go

/*==============================================================*/
/* Table: QUANHUYEN                                             */
/*==============================================================*/
create table QUANHUYEN (
   MAQH                 varchar(50)          not null,
   TENQH                varchar(50)          null,
   constraint PK_QUANHUYEN primary key nonclustered (MAQH)
)
go

/*==============================================================*/
/* Table: SOHOKHAU                                              */
/*==============================================================*/
create table SOHOKHAU (
   SOSO                 int                  not null,
   MAPX                 varchar(50)          not null,
   HOTENCHUHO           varchar(200)         null,
   SONHA                varchar(50)          null,
   TENDUONG             varchar(50)          null,
   KHUPHO               varchar(50)          null,
   constraint PK_SOHOKHAU primary key nonclustered (SOSO)
)
go

/*==============================================================*/
/* Index: QUANLY_FK                                             */
/*==============================================================*/
create index QUANLY_FK on SOHOKHAU (
MAPX ASC
)
go

alter table NHANKHAU
   add constraint FK_NHANKHAU_CO_SOHOKHAU foreign key (SOSO)
      references SOHOKHAU (SOSO)
go

alter table PHUONGXA
   add constraint FK_PHUONGXA_THUOC_QUANHUYE foreign key (MAQH)
      references QUANHUYEN (MAQH)
go

alter table SOHOKHAU
   add constraint FK_SOHOKHAU_QUANLY_PHUONGXA foreign key (MAPX)
      references PHUONGXA (MAPX)
go

select * from QUANHUYEN

select * from PHUONGXA

select * from SOHOKHAU

select * from NHANKHAU
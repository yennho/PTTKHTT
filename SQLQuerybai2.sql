/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     27/09/2019 9:23:01 AM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAOCAO') and o.name = 'FK_BAOCAO_LAP_DONVI')
alter table BAOCAO
   drop constraint FK_BAOCAO_LAP_DONVI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DONVI') and o.name = 'FK_DONVI_PHAITHUOC_NGANHKTQ')
alter table DONVI
   drop constraint FK_DONVI_PHAITHUOC_NGANHKTQ
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DONVI') and o.name = 'FK_DONVI_THUOC_SOBNBOCQ')
alter table DONVI
   drop constraint FK_DONVI_THUOC_SOBNBOCQ
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BAOCAO')
            and   name  = 'LAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index BAOCAO.LAP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BAOCAO')
            and   type = 'U')
   drop table BAOCAO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DONVI')
            and   name  = 'PHAITHUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index DONVI.PHAITHUOC_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DONVI')
            and   name  = 'THUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index DONVI.THUOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DONVI')
            and   type = 'U')
   drop table DONVI
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NGANHKTQD')
            and   type = 'U')
   drop table NGANHKTQD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SOBNBOCQ')
            and   type = 'U')
   drop table SOBNBOCQ
go

/*==============================================================*/
/* Table: BAOCAO                                                */
/*==============================================================*/
create table BAOCAO (
   QUY                  int                  not null,
   NAM                  int                  not null,
   MADV                 varchar(50)          not null,
   TONGSLD              int                  null,
   SLNU                 int                  null,
   SLDBQ                int                  null,
   TONGTHUNHAP          float                null,
   LUONG                float                null,
   THUNHAPKHAC          float                null,
   TNBQ                 float                null,
   constraint PK_BAOCAO primary key nonclustered (QUY, NAM)
)
go

/*==============================================================*/
/* Index: LAP_FK                                                */
/*==============================================================*/
create index LAP_FK on BAOCAO (
MADV ASC
)
go

/*==============================================================*/
/* Table: DONVI                                                 */
/*==============================================================*/
create table DONVI (
   MADV                 varchar(50)          not null,
   MACQ                 varchar(50)          not null,
   MANGANH              varchar(50)          not null,
   TENDV                varchar(100)         null,
   DIACHI               varchar(100)         null,
   constraint PK_DONVI primary key nonclustered (MADV)
)
go

/*==============================================================*/
/* Index: THUOC_FK                                              */
/*==============================================================*/
create index THUOC_FK on DONVI (
MACQ ASC
)
go

/*==============================================================*/
/* Index: PHAITHUOC_FK                                          */
/*==============================================================*/
create index PHAITHUOC_FK on DONVI (
MANGANH ASC
)
go

/*==============================================================*/
/* Table: NGANHKTQD                                             */
/*==============================================================*/
create table NGANHKTQD (
   MANGANH              varchar(50)          not null,
   TENNGANH             varchar(100)         null,
   constraint PK_NGANHKTQD primary key nonclustered (MANGANH)
)
go

/*==============================================================*/
/* Table: SOBNBOCQ                                              */
/*==============================================================*/
create table SOBNBOCQ (
   MACQ                 varchar(50)          not null,
   TENDVCQ              varchar(100)         null,
   CAPQL                varchar(50)          null,
   constraint PK_SOBNBOCQ primary key nonclustered (MACQ)
)
go

alter table BAOCAO
   add constraint FK_BAOCAO_LAP_DONVI foreign key (MADV)
      references DONVI (MADV)
go

alter table DONVI
   add constraint FK_DONVI_PHAITHUOC_NGANHKTQ foreign key (MANGANH)
      references NGANHKTQD (MANGANH)
go

alter table DONVI
   add constraint FK_DONVI_THUOC_SOBNBOCQ foreign key (MACQ)
      references SOBNBOCQ (MACQ)
go

select * from SOBNBOCQ

select * from NGANHKTQD

select * from DONVI

select * from BAOCAO
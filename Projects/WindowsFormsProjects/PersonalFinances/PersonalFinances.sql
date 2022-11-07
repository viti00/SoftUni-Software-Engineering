/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     2017-02-15 15:03:15                          */
/*==============================================================*/
CREATE DATABASE PersonalFinances
GO
USE PersonalFinances
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADDRESS') and o.name = 'FK_ADDRESS_REFERENCE_CLIENT')
alter table ADDRESS
   drop constraint FK_ADDRESS_REFERENCE_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOSSIER') and o.name = 'FK_DOSSIER_REFERENCE_CLIENT')
alter table DOSSIER
   drop constraint FK_DOSSIER_REFERENCE_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOSSIER_DETAILS') and o.name = 'FK_DOSSIER__REFERENCE_DOSSIER')
alter table DOSSIER_DETAILS
   drop constraint FK_DOSSIER__REFERENCE_DOSSIER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOSSIER_DETAILS') and o.name = 'FK_DOSSIER__REFERENCE_INCOME_E')
alter table DOSSIER_DETAILS
   drop constraint FK_DOSSIER__REFERENCE_INCOME_E
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADDRESS')
            and   name  = 'IDX_ADDRESS_UQ'
            and   indid > 0
            and   indid < 255)
   drop index ADDRESS.IDX_ADDRESS_UQ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADDRESS')
            and   type = 'U')
   drop table ADDRESS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENT')
            and   name  = 'IDX_CLIENT_UQ'
            and   indid > 0
            and   indid < 255)
   drop index CLIENT.IDX_CLIENT_UQ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DOSSIER')
            and   name  = 'IDX_DOSSIER_UQ'
            and   indid > 0
            and   indid < 255)
   drop index DOSSIER.IDX_DOSSIER_UQ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOSSIER')
            and   type = 'U')
   drop table DOSSIER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOSSIER_DETAILS')
            and   type = 'U')
   drop table DOSSIER_DETAILS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INCOME_EXPNECE')
            and   name  = 'IDX_INCOME_EXPENCE_UQ'
            and   indid > 0
            and   indid < 255)
   drop index INCOME_EXPNECE.IDX_INCOME_EXPENCE_UQ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INCOME_EXPNECE')
            and   type = 'U')
   drop table INCOME_EXPNECE
go

/*==============================================================*/
/* Table: ADDRESS                                               */
/*==============================================================*/
create table ADDRESS (
   ADDRESS_ID           numeric              identity,
   CLIENT_ID            numeric              not null,
   ADDRESS_TYPE         char(1)              not null
      constraint CKC_ADDRESS_TYPE_ADDRESS check (ADDRESS_TYPE in ('P','K')),
   ADDRESS_REGION       varchar(100)         null,
   ADDRES_MUNICIPALITY  varchar(100)         null,
   ADDRESS_PLACE        varchar(100)         not null,
   ADDRESS_PCODE        varchar(4)           not null,
   ADDRESS_TEXT         varchar(100)         not null,
   constraint PK_ADDRESS primary key (ADDRESS_ID)
)
go

/*==============================================================*/
/* Index: IDX_ADDRESS_UQ                                        */
/*==============================================================*/
create unique index IDX_ADDRESS_UQ on ADDRESS (
CLIENT_ID ASC,
ADDRESS_TYPE ASC
)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   CLIENT_ID            numeric              identity,
   CLIENT_EGN           varchar(10)          not null,
   CLIENT_NAME          varchar(50)          not null,
   CLIENT_SURNAME       varchar(50)          not null,
   CLIENT_LASTNAME      varchar(50)          not null,
   CLIENT_EMAIL         varchar(100)         not null,
   CLIENT_PHONE         varchar(10)          null,
   constraint PK_CLIENT primary key (CLIENT_ID)
)
go

/*==============================================================*/
/* Index: IDX_CLIENT_UQ                                         */
/*==============================================================*/
create unique index IDX_CLIENT_UQ on CLIENT (
CLIENT_EGN ASC
)
go

/*==============================================================*/
/* Table: DOSSIER                                               */
/*==============================================================*/
create table DOSSIER (
   DOSSIER_NO           numeric              identity,
   CLIENT_ID            numeric              not null,
   DOSSIER_YEAR         numeric              not null,
   DOSSIER_CURRENT_BALANCE numeric(10,2)	 null default 0,		
   DOSSIER_STATUS       char(1)              not null
      constraint CKC_DOSSIER_STATUS_DOSSIER check (DOSSIER_STATUS in ('O','C')),
   DOSSIER_MIN_BALANCE  numeric(10,2)        null,
   constraint PK_DOSSIER primary key (DOSSIER_NO)
)
go
/*==============================================================*/
/* Index: IDX_DOSSIER_UQ                                        */
/*==============================================================*/
create unique index IDX_DOSSIER_UQ on DOSSIER (
CLIENT_ID ASC,
DOSSIER_YEAR ASC
)
go

/*==============================================================*/
/* Table: DOSSIER_DETAILS                                       */
/*==============================================================*/
create table DOSSIER_DETAILS (
   DD_ID                numeric              identity,
   DOSSIER_NO           numeric              not null,
   INCEXP_ID            numeric              not null,
   DD_DATE              date                 not null,
   DD_VALUE             numeric(10,2)        not null,
   DD_DOC               varchar(100)         null,
   constraint PK_DOSSIER_DETAILS primary key (DD_ID)
)
go

/*==============================================================*/
/* Table: INCOME_EXPNECE                                        */
/*==============================================================*/
create table INCOME_EXPNECE (
   INCEXP_ID            numeric              identity,
   INCEXP_NAME          varchar(100)         not null,
   INCEXP_TYPE          char(1)              not null
	constraint CKC_INCEXP_TYPE_INCOME_E check (INCEXP_TYPE in ('I','C')),
   constraint PK_INCOME_EXPNECE primary key (INCEXP_ID)
)
go

create table EMPLOYEE(
	EMP_ID			numeric				identity,
	EMP_FULLNAME	nvarchar(60)		not null,
	EMP_USERNAME	nvarchar(20)		not null,
	EMP_PASSWORD	nvarchar(max)		not null,
	EMP_IS_ADMINISTRATOR char(1)		null
	constraint IS_ADMINISTRATOR check (EMP_IS_ADMINISTRATOR IN ('T','F')),
	constraint PK_EMPLOYEE primary key (EMP_ID)
)

/*==============================================================*/
/* Index: IDX_INCOME_EXPENCE_UQ                                 */
/*==============================================================*/
create unique index IDX_INCOME_EXPENCE_UQ on INCOME_EXPNECE (
INCEXP_NAME ASC,
INCEXP_TYPE ASC
)
go

alter table ADDRESS
   add constraint FK_ADDRESS_REFERENCE_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table DOSSIER
   add constraint FK_DOSSIER_REFERENCE_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table DOSSIER_DETAILS
   add constraint FK_DOSSIER__REFERENCE_DOSSIER foreign key (DOSSIER_NO)
      references DOSSIER (DOSSIER_NO)
go

alter table DOSSIER_DETAILS
   add constraint FK_DOSSIER__REFERENCE_INCOME_E foreign key (INCEXP_ID)
      references INCOME_EXPNECE (INCEXP_ID)
go


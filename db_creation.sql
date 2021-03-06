USE [master]
GO
/****** Object:  Database [warehouse_db]    Script Date: 08.08.2021 22:20:47 ******/
CREATE DATABASE [warehouse_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'warehouse_db', FILENAME = N'F:\SQLFeatures\MSSQL15.SQL\MSSQL\DATA\warehouse_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'warehouse_db_log', FILENAME = N'F:\SQLFeatures\MSSQL15.SQL\MSSQL\DATA\warehouse_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [warehouse_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [warehouse_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [warehouse_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [warehouse_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [warehouse_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [warehouse_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [warehouse_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [warehouse_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [warehouse_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [warehouse_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [warehouse_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [warehouse_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [warehouse_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [warehouse_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [warehouse_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [warehouse_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [warehouse_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [warehouse_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [warehouse_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [warehouse_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [warehouse_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [warehouse_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [warehouse_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [warehouse_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [warehouse_db] SET RECOVERY FULL 
GO
ALTER DATABASE [warehouse_db] SET  MULTI_USER 
GO
ALTER DATABASE [warehouse_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [warehouse_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [warehouse_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [warehouse_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [warehouse_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [warehouse_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'warehouse_db', N'ON'
GO
ALTER DATABASE [warehouse_db] SET QUERY_STORE = OFF
GO
USE [warehouse_db]
GO
/****** Object:  User [app]    Script Date: 08.08.2021 22:20:47 ******/
CREATE USER [app] FOR LOGIN [app] WITH DEFAULT_SCHEMA=[db_datareader]
GO
ALTER ROLE [db_owner] ADD MEMBER [app]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [app]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [app]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [app]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [app]
GO
ALTER ROLE [db_datareader] ADD MEMBER [app]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [app]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier](
	[supplier_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[country] [varchar](50) NOT NULL,
 CONSTRAINT [PK_supplier] PRIMARY KEY CLUSTERED 
(
	[supplier_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [varchar](50) NOT NULL,
	[id_category] [int] NOT NULL,
	[id_supplier] [int] NOT NULL,
	[id_department] [int] NOT NULL,
	[ammount_on_stock] [int] NULL,
	[unit] [varchar](50) NOT NULL,
	[price] [float] NULL,
	[currency] [varchar](50) NULL,
 CONSTRAINT [PK_product_1] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[department]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department](
	[department_id] [int] IDENTITY(1,1) NOT NULL,
	[department_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_department] PRIMARY KEY CLUSTERED 
(
	[department_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[cname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[list_product]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[list_product]
AS
SELECT        dbo.product.product_id AS ID, dbo.product.product_name AS [Nazwa Produktu], dbo.category.cname AS Kategoria, dbo.supplier.name AS Producent, dbo.department.department_name AS Dział, 
                         dbo.product.ammount_on_stock AS [Ilość na stanie], dbo.product.unit AS Jednostka, dbo.product.price AS Cena, dbo.product.currency AS Waluta
FROM            dbo.product INNER JOIN
                         dbo.category ON dbo.product.id_category = dbo.category.category_id INNER JOIN
                         dbo.department ON dbo.product.id_department = dbo.department.department_id INNER JOIN
                         dbo.supplier ON dbo.product.id_supplier = dbo.supplier.supplier_id
GO
/****** Object:  Table [dbo].[employee]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[id_position] [int] NOT NULL,
	[id_department] [int] NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[position]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[position](
	[position_id] [int] IDENTITY(1,1) NOT NULL,
	[pname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_position] PRIMARY KEY CLUSTERED 
(
	[position_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[show_employees]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[show_employees]
AS
SELECT        dbo.employee.employee_id AS ID, dbo.employee.name AS Imie, dbo.employee.surname AS Nazwisko, dbo.position.name AS Stanowisko, dbo.department.department_name AS Dział
FROM            dbo.employee INNER JOIN
                         dbo.position ON dbo.employee.id_position = dbo.position.position_id INNER JOIN
                         dbo.department ON dbo.employee.id_department = dbo.department.department_id
GO
/****** Object:  Table [dbo].[client]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[client_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[country] [varchar](50) NOT NULL,
 CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED 
(
	[client_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[show_clients]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[show_clients]
AS
SELECT        client_id AS ID, name AS [Nazwa Klienta], address AS Ulica, city AS Miasto, country AS Kraj
FROM            dbo.client
GO
/****** Object:  Table [dbo].[roles]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[account]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[account_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [varchar](max) NOT NULL,
	[id_role] [int] NOT NULL,
	[id_employee] [int] NULL,
 CONSTRAINT [PK_user_account] PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[show_accounts]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[show_accounts]
AS
SELECT        dbo.account.account_id AS [ID Konta], dbo.account.username AS [Nazwa Użytkownika], dbo.roles.role_name AS Rola, dbo.employee.name AS Imie, dbo.employee.surname AS Nazwisko, dbo.position.pname, 
                         dbo.department.department_name AS Dział
FROM            dbo.roles INNER JOIN
                         dbo.account ON dbo.roles.role_id = dbo.account.id_role INNER JOIN
                         dbo.employee ON dbo.account.id_employee = dbo.employee.employee_id INNER JOIN
                         dbo.position ON dbo.employee.id_position = dbo.position.position_id INNER JOIN
                         dbo.department ON dbo.employee.id_department = dbo.department.department_id
GO
/****** Object:  Table [dbo].[orders]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[orderID] [int] NOT NULL,
	[id_product] [int] NOT NULL,
	[ammount] [int] NOT NULL,
	[execution_status] [bit] NOT NULL,
	[id_client] [int] NOT NULL,
	[summary] [float] NOT NULL,
	[currency] [varchar](50) NOT NULL,
	[date] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[show_order]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[show_order]
AS
SELECT        dbo.orders.orderID AS [ID Zamówienia], dbo.product.product_name AS [Nazwa Produktu], dbo.orders.ammount AS Ilość, dbo.orders.execution_status AS Status, dbo.orders.summary AS [Do zapłaty], 
                         dbo.orders.currency AS Waluta, dbo.client.name AS Zamawiający, dbo.orders.date AS Data
FROM            dbo.product INNER JOIN
                         dbo.category ON dbo.product.id_category = dbo.category.category_id INNER JOIN
                         dbo.orders ON dbo.product.product_id = dbo.orders.id_product INNER JOIN
                         dbo.client ON dbo.orders.id_client = dbo.client.client_id
GO
/****** Object:  Table [dbo].[orders_history]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders_history](
	[historical_order_id] [int] NOT NULL,
	[id_product] [int] NOT NULL,
	[ammount] [int] NOT NULL,
	[execution_status] [bit] NOT NULL,
	[id_client] [int] NOT NULL,
	[summary] [float] NOT NULL,
	[currency] [varchar](50) NOT NULL,
	[done_date] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[show_order_history]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[show_order_history]
AS
SELECT        dbo.orders_history.historical_order_id AS [ID Historyczne], dbo.product.product_name AS [Nazwa Produktu], dbo.orders_history.ammount AS Ilość, dbo.orders_history.execution_status AS Status, 
                         dbo.orders_history.summary AS [Do zapłaty], dbo.orders_history.currency AS Waluta, dbo.client.name AS Zamawiający, dbo.orders_history.done_date AS [Data realizacji]
FROM            dbo.product INNER JOIN
                         dbo.category ON dbo.product.id_category = dbo.category.category_id INNER JOIN
                         dbo.orders_history ON dbo.product.product_id = dbo.orders_history.id_product INNER JOIN
                         dbo.client ON dbo.orders_history.id_client = dbo.client.client_id
GO
/****** Object:  Table [dbo].[price_change_history]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[price_change_history](
	[pricechange_id] [int] IDENTITY(1,1) NOT NULL,
	[old_price] [money] NOT NULL,
	[new_price] [money] NOT NULL,
	[id_product] [int] NOT NULL,
	[change_date] [datetime] NOT NULL,
 CONSTRAINT [PK_price_change_history] PRIMARY KEY CLUSTERED 
(
	[pricechange_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[show_price_change_history]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[show_price_change_history]
AS
SELECT        dbo.price_change_history.pricechange_id AS [ID Zmiany], dbo.product.product_name AS [Nazwa produktu], dbo.category.name AS Kategoria, dbo.supplier.name AS Producent, dbo.price_change_history.old_price AS [Stara cena],
                          dbo.price_change_history.new_price AS [Nowa cena], dbo.price_change_history.change_date AS [Data zmiany]
FROM            dbo.price_change_history INNER JOIN
                         dbo.product ON dbo.price_change_history.id_product = dbo.product.product_id INNER JOIN
                         dbo.category ON dbo.product.id_category = dbo.category.category_id INNER JOIN
                         dbo.supplier ON dbo.product.id_supplier = dbo.supplier.supplier_id INNER JOIN
                         dbo.department ON dbo.product.id_department = dbo.department.department_id
GO
/****** Object:  View [dbo].[show_category]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[show_category]
AS
SELECT        category_id AS [ID Kategorii], name AS Nazwa
FROM            dbo.category
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [index]    Script Date: 08.08.2021 22:20:48 ******/
CREATE NONCLUSTERED INDEX [index] ON [dbo].[product]
(
	[product_id] ASC,
	[product_name] ASC,
	[id_category] ASC,
	[id_supplier] ASC,
	[id_department] ASC,
	[ammount_on_stock] ASC,
	[unit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[account]  WITH CHECK ADD  CONSTRAINT [FK_account_employee] FOREIGN KEY([id_employee])
REFERENCES [dbo].[employee] ([employee_id])
GO
ALTER TABLE [dbo].[account] CHECK CONSTRAINT [FK_account_employee]
GO
ALTER TABLE [dbo].[account]  WITH CHECK ADD  CONSTRAINT [FK_user_roles] FOREIGN KEY([id_role])
REFERENCES [dbo].[roles] ([role_id])
GO
ALTER TABLE [dbo].[account] CHECK CONSTRAINT [FK_user_roles]
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [FK_employee_department] FOREIGN KEY([id_department])
REFERENCES [dbo].[department] ([department_id])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [FK_employee_department]
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [FK_employee_position] FOREIGN KEY([id_position])
REFERENCES [dbo].[position] ([position_id])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [FK_employee_position]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_order_client] FOREIGN KEY([id_client])
REFERENCES [dbo].[client] ([client_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_order_client]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_order_product] FOREIGN KEY([id_product])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_order_product]
GO
ALTER TABLE [dbo].[orders_history]  WITH CHECK ADD  CONSTRAINT [FK_order_history_client] FOREIGN KEY([id_client])
REFERENCES [dbo].[client] ([client_id])
GO
ALTER TABLE [dbo].[orders_history] CHECK CONSTRAINT [FK_order_history_client]
GO
ALTER TABLE [dbo].[orders_history]  WITH CHECK ADD  CONSTRAINT [FK_order_history_product] FOREIGN KEY([id_product])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[orders_history] CHECK CONSTRAINT [FK_order_history_product]
GO
ALTER TABLE [dbo].[price_change_history]  WITH CHECK ADD  CONSTRAINT [FK_price_change_history_product] FOREIGN KEY([id_product])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[price_change_history] CHECK CONSTRAINT [FK_price_change_history_product]
GO
/****** Object:  StoredProcedure [dbo].[add_client]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[add_client]

@name varchar(50),
@address varchar(50),
@city varchar(50),
@country varchar(50)

AS
	IF EXISTS (SELECT name FROM dbo.client WHERE name = @name)
	BEGIN
		PRINT('Klient o takiej nazwie już istnieje')
	END
	ELSE
	BEGIN
		INSERT INTO dbo.client values (@name,@address,@city,@country)
	END
GO
/****** Object:  StoredProcedure [dbo].[add_department]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[add_department]
@name varchar(50)
AS
	IF EXISTS (SELECT department_name FROM dbo.department WHERE department_name = @name)
	BEGIN
		PRINT 'Taki dział już istnieje!'
	END
	ELSE
	BEGIN
		INSERT INTO dbo.department VALUES (@name)
		PRINT 'Poprawnie dodano nowy dział'
	END
GO
/****** Object:  StoredProcedure [dbo].[add_employee]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[add_employee]

@name nvarchar(50),
@surname nvarchar(50),
@id_position int,
@id_department int

AS
	BEGIN
		IF EXISTS (SELECT position_id FROM dbo.position WHERE @id_position = position_id)
			BEGIN
			IF EXISTS (SELECT department_id FROM dbo.department WHERE @id_department = department_id) 
				BEGIN
					INSERT INTO dbo.employee VALUES (@name,@surname,@id_position,@id_department)
				END
				ELSE
					PRINT ('Dział o takim ID nie istnieje!')
				END
		ELSE
		BEGIN
		PRINT ('Stanowisko o takim ID nie istnieje!')	
		END
	END
GO
/****** Object:  StoredProcedure [dbo].[add_new_product]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[add_new_product]

@product_name varchar(50),
@id_category int,
@id_supplier int,
@id_department int,
@ammount_on_stock int,
@unit varchar(50),
@price float,
@currency varchar(50)
AS

	if exists (select product_name from dbo.product where product_name = @product_name)
		begin
			print('Produkt o danej nazwie już istnieje!')
		end
	else
		begin
			if exists (select category_id from dbo.category where category_id = @id_category)
				begin
					if exists (select supplier_id from dbo.supplier where supplier_id = @id_supplier)
						begin
							if exists (select department_id from dbo.department where department_id = @id_department)
								begin
									insert into dbo.product values (@product_name,@id_category,@id_supplier,@id_department,@ammount_on_stock,@unit,@price,@currency)
								end
							else
								begin
									print('Nie ma takiego działu!')
								end
						end
					else
						begin
							print('Nie ma takiego dostawcy!')
						end
				end
			else
				begin
					print('Nie ma takiej kategorii!')
				end
		end
GO
/****** Object:  StoredProcedure [dbo].[add_supplier]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[add_supplier]

@name nvarchar(50),
@address nvarchar(50),
@city varchar(50),
@country varchar(50)

AS
	IF EXISTS (SELECT name FROM dbo.supplier WHERE name = @name)
	BEGIN
		PRINT('Taki dostawca istnieje!')
	END
	ELSE
	BEGIN
		INSERT INTO dbo.supplier VALUES (@name,@address,@city,@country)
		PRINT('Dodano dostawcę!')
	END

GO
/****** Object:  StoredProcedure [dbo].[create_account]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[create_account]
@username nvarchar(50),
@password varchar(MAX),
@id_role int,
@id_employee int
AS
	if exists(select username from dbo.account where username = @username)
	begin
		print('Uzytkownik o takim loginie juz istnieje!')
	end
	else
	begin
		if exists(select role_id from dbo.roles where role_id = @id_role)
		begin
			insert into dbo.account values (@username,@password,@id_role,@id_employee)
			print('Pomyslnie utworzono konto uzytkownika!')
		end
	end
GO
/****** Object:  StoredProcedure [dbo].[create_category]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[create_category]
@name varchar(50)
AS
	IF EXISTS (SELECT name FROM dbo.category WHERE name = @name)
	BEGIN
		PRINT 'Kategoria już istnieje'
	END
	ELSE
	BEGIN
		INSERT INTO dbo.category VALUES (@name)
		PRINT 'Poprawnie dodano kategorie'
	END
GO
/****** Object:  StoredProcedure [dbo].[create_position]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[create_position]

@name varchar(50)

AS
	IF EXISTS (SELECT name from dbo.position WHERE name = @name)
	BEGIN
		PRINT('Stanowisko o takiej nazwie istnieje!')
	END
	ELSE
	BEGIN
		INSERT INTO dbo.position VALUES (@name)
		PRINT('Stanowisko dodane!')
	END

GO
/****** Object:  StoredProcedure [dbo].[delete_category]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[delete_category]
@id int
AS
	IF EXISTS (SELECT category_id FROM dbo.category WHERE category_id = @id)
	BEGIN
		DELETE FROM dbo.category WHERE category_id = @id
		PRINT 'Poprawnie usunieto kategorię'
	END
	ELSE
	BEGIN
		PRINT 'Nie ma kategorii o takim ID'
	END
GO
/****** Object:  StoredProcedure [dbo].[delete_employee]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[delete_employee]

@ID int

AS
	IF EXISTS (SELECT employee_id FROM dbo.employee WHERE @ID = employee_id)
	BEGIN
		DELETE FROM dbo.employee WHERE employee_id = @ID
		PRINT ('Pomyślnie usunięto pracownika!')
	END
	ELSE
	BEGIN
		PRINT ('Nie ma pracownika o takim ID!')
	END
GO
/****** Object:  StoredProcedure [dbo].[delete_order]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[delete_order]

@orderID int

AS
	
	if exists (select orderID from dbo.orders where orderID = @orderID)
		begin
			delete from dbo.orders where orderID = @orderID
			print('Zamowienie usunięte!')
		end
	else
		begin
			print('Nie ma zamowienia o takim ID!')
		end

GO
/****** Object:  StoredProcedure [dbo].[delete_position]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[delete_position]

@ID int

AS
	IF EXISTS (SELECT position_id from dbo.position WHERE position_id = @ID)
	BEGIN
		DELETE FROM dbo.position WHERE position_id = @ID
		PRINT('Usunięto!')
	END
	ELSE
	BEGIN
		PRINT('Stanowisko o podanym ID nie istnieje!')
	END

GO
/****** Object:  StoredProcedure [dbo].[delete_product]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[delete_product]

@product_id int

AS
	if exists(select product_id from dbo.product where product_id = @product_id)
		begin
			delete from dbo.orders_history where id_product = @product_id
			delete from dbo.product where product_id = @product_id
		end
	else
		begin
			print ('Nie ma produktu o takim ID!')
		end

GO
/****** Object:  StoredProcedure [dbo].[delete_supplier]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[delete_supplier]

@name nvarchar(50)

AS
	IF EXISTS (SELECT name FROM dbo.supplier WHERE name = @name)
	BEGIN
		DELETE FROM dbo.supplier WHERE name = @name
		PRINT('Usunięto!')
	END
	ELSE
	BEGIN
		PRINT('Nie ma takiego dostawcy!')
	END

GO
/****** Object:  StoredProcedure [dbo].[execute_order]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[execute_order]
@order_id int
AS
SET NOCOUNT ON;
	UPDATE dbo.orders
	SET execution_status = 1 where orderID = @order_id;
	print ('Zamowienie zrealizowane!')
GO
/****** Object:  StoredProcedure [dbo].[list_clients_proc]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[list_clients_proc]
AS
BEGIN
	SELECT        client_id, name, address, city, country
FROM            dbo.client
END
GO
/****** Object:  StoredProcedure [dbo].[list_employee]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[list_employee]
AS
BEGIN

	SET NOCOUNT ON;

SELECT        dbo.employee.employee_id, dbo.employee.name, dbo.employee.surname, dbo.position.pname, dbo.department.department_name
FROM            dbo.employee INNER JOIN
                         dbo.position ON dbo.employee.id_position = dbo.position.position_id INNER JOIN
                         dbo.department ON dbo.employee.id_department = dbo.department.department_id
END
GO
/****** Object:  StoredProcedure [dbo].[list_orders]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[list_orders]
AS
BEGIN

	SET NOCOUNT ON;
	SELECT        dbo.orders.orderID, dbo.product.product_name, dbo.orders.ammount, dbo.orders.execution_status, dbo.orders.summary, 
                         dbo.orders.currency, dbo.client.name, dbo.orders.date
FROM            dbo.product INNER JOIN
                         dbo.category ON dbo.product.id_category = dbo.category.category_id INNER JOIN
                         dbo.orders ON dbo.product.product_id = dbo.orders.id_product INNER JOIN
                         dbo.client ON dbo.orders.id_client = dbo.client.client_id
  
END
GO
/****** Object:  StoredProcedure [dbo].[list_orders_history]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[list_orders_history]
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT        dbo.orders_history.historical_order_id, dbo.product.product_name, dbo.orders_history.ammount, dbo.orders_history.execution_status, 
                         dbo.orders_history.summary, dbo.orders_history.currency, dbo.client.name, dbo.orders_history.done_date
FROM            dbo.product INNER JOIN
                         dbo.category ON dbo.product.id_category = dbo.category.category_id INNER JOIN
                         dbo.orders_history ON dbo.product.product_id = dbo.orders_history.id_product INNER JOIN
                         dbo.client ON dbo.orders_history.id_client = dbo.client.client_id
END
GO
/****** Object:  StoredProcedure [dbo].[list_product_proc]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[list_product_proc]

AS
BEGIN

SELECT        dbo.product.product_id, dbo.product.product_name, dbo.category.cname, dbo.supplier.name, dbo.department.department_name, 
                         dbo.product.ammount_on_stock, dbo.product.unit, dbo.product.price, dbo.product.currency
FROM            dbo.product INNER JOIN
                         dbo.category ON dbo.product.id_category = dbo.category.category_id INNER JOIN
                         dbo.department ON dbo.product.id_department = dbo.department.department_id INNER JOIN
                         dbo.supplier ON dbo.product.id_supplier = dbo.supplier.supplier_id

END
GO
/****** Object:  StoredProcedure [dbo].[make_order]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[make_order]

@orderID int,
@id_product int,
@ammount int,
@id_client int

AS
	if exists (select product_id from dbo.product where product_id = @id_product)
		begin
			if exists (select client_id from dbo.client where client_id = @id_client)
				begin
					insert into dbo.orders values (@orderID,@id_product,@ammount,0,@id_client,(@ammount * (select price from dbo.product where product_id = @id_product)),'PLN',CURRENT_TIMESTAMP);
					update dbo.product
					set ammount_on_stock = (select ammount_on_stock from dbo.product where product_id = @id_product) - @ammount where product_id = @id_product;
				end
			else
				begin
					print('Nie ma takiego klienta!')
				end
		end
	else
		begin
			print('Nie ma produktu o takim ID!')
		end

GO
/****** Object:  StoredProcedure [dbo].[remove_account]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[remove_account]
@account_id int
AS
	if exists(select account_id from dbo.account where account_id = @account_id)
	begin
		delete from dbo.account where account_id = @account_id
		print('Poprawnie usunięto konto uzytkownika!')
	end
	else
	begin
		print('Nie ma takiego konta!')
	end
GO
/****** Object:  StoredProcedure [dbo].[remove_client]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[remove_client]

@id int

AS
	IF EXISTS (SELECT name FROM dbo.client WHERE client_id = @id)
	BEGIN
		DELETE FROM dbo.client WHERE client_id = @id;
	END
	ELSE
	BEGIN
		PRINT ('Nie ma takiego klienta!')
	END
GO
/****** Object:  StoredProcedure [dbo].[remove_department]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[remove_department]
@id int
AS
	IF EXISTS (SELECT department_id FROM dbo.department WHERE  department_id = @id)
	BEGIN
		DELETE FROM dbo.department WHERE department_id = @id
		PRINT 'Poprawnie usunięto dział'
	END
	ELSE
	BEGIN
		PRINT 'Dział o podanym ID nie istnieje'
	END
GO
/****** Object:  StoredProcedure [dbo].[update_price]    Script Date: 08.08.2021 22:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[update_price]

@ID int,
@price float,
@currency varchar(50)

AS
	IF EXISTS (SELECT product_id FROM dbo.product WHERE product_id = @ID)
	BEGIN
		UPDATE dbo.product
		SET price = @price, currency = @currency
		WHERE product_id = @ID
		PRINT('Zaktualizowano!')
	END
	ELSE
	BEGIN
		PRINT('Produkt o podanym ID nie istnieje! Aktualizacja anulowana !')
	END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[23] 2[18] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "product"
            Begin Extent = 
               Top = 18
               Left = 43
               Bottom = 148
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "category"
            Begin Extent = 
               Top = 200
               Left = 16
               Bottom = 296
               Right = 186
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "department"
            Begin Extent = 
               Top = 174
               Left = 291
               Bottom = 270
               Right = 477
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "supplier"
            Begin Extent = 
               Top = 71
               Left = 542
               Bottom = 201
               Right = 712
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2370
         Alias = 2115
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'list_product'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'list_product'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'list_product'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "roles"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 431
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "account"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "employee"
            Begin Extent = 
               Top = 154
               Left = 250
               Bottom = 284
               Right = 420
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "position"
            Begin Extent = 
               Top = 135
               Left = 491
               Bottom = 231
               Right = 661
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "department"
            Begin Extent = 
               Top = 6
               Left = 469
               Bottom = 102
               Right = 655
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2625
         Alias = 2490
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_accounts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_accounts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_accounts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "category"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 151
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_category'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_category'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "client"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 182
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_clients'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_clients'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "employee"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 189
               Right = 203
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "position"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "department"
            Begin Extent = 
               Top = 168
               Left = 244
               Bottom = 264
               Right = 430
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_employees'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_employees'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "category"
            Begin Extent = 
               Top = 6
               Left = 508
               Bottom = 102
               Right = 678
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "orders"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "product"
            Begin Extent = 
               Top = 6
               Left = 253
               Bottom = 197
               Right = 470
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "client"
            Begin Extent = 
               Top = 202
               Left = 244
               Bottom = 332
               Right = 414
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2400
         Alias = 3060
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "category"
            Begin Extent = 
               Top = 56
               Left = 547
               Bottom = 152
               Right = 717
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "product"
            Begin Extent = 
               Top = 0
               Left = 294
               Bottom = 130
               Right = 488
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "client"
            Begin Extent = 
               Top = 158
               Left = 303
               Bottom = 288
               Right = 473
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "orders_history"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_order_history'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_order_history'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "price_change_history"
            Begin Extent = 
               Top = 52
               Left = 90
               Bottom = 240
               Right = 304
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "product"
            Begin Extent = 
               Top = 48
               Left = 466
               Bottom = 247
               Right = 710
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "category"
            Begin Extent = 
               Top = 6
               Left = 748
               Bottom = 102
               Right = 918
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "supplier"
            Begin Extent = 
               Top = 6
               Left = 956
               Bottom = 136
               Right = 1126
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "department"
            Begin Extent = 
               Top = 6
               Left = 1164
               Bottom = 102
               Right = 1350
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1980
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_price_change_history'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_price_change_history'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'show_price_change_history'
GO
USE [master]
GO
ALTER DATABASE [warehouse_db] SET  READ_WRITE 
GO

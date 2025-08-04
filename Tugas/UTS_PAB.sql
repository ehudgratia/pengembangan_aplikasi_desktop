
-- Membuat tabel Barang
Create Table dbo.Barang
(
Kode_Barang varchar(5) Primary Key Not Null,
Nama_Barang nvarchar(50) Foreign Key (Kode_Barang) References dbo.Barang,
Harga_Barang int foreign Key (Kode_Barang) References dbo.Barang Not Null,
Jumlah_Persediaan Int Not Null
)

-- Membuat tabel Pelanggan
Create Table dbo.Pelanggan
(
Nama_Pelanggan nvarchar(50) Primary Key Not Null,
Alamat_Pelanggan Varchar(50) Not Null
)

-- Membuat Tabel Pemasok --
Create Table dbo.Pemasok
(
Kode_Pemasok Varchar(5) Primary Key Not Null,
Nama_Pemasok nVarchar(50) Foreign Key (Kode_Pemasok) References dbo.Pemasok,
Alamat_Pemasok Varchar(50) Not Null,
Harga_Barang_Pemasok varchar(50) Not Null
)

-- Membuat tabel Penjualan --	
Create Table dbo.Penjualan
(
Nama_Pelanggan nvarchar(50) Foreign Key (Nama_Pelanggan) References dbo.Pelanggan Not Null,
Alamat_Pemasok Varchar(50) Not Null,
Kode_Barang Varchar(5) Foreign Key (Kode_Barang) References dbo.Barang (Kode_Barang) Not Null,
Nama_Barang NVarchar(50) Not Null,
Harga_Barang int Not Null,
Total int Not Null
)

-- Membuat tabel Pembelian --
Create Table dbo.Pemebelian
(
Kode_Pemasok varchar(5) Foreign Key (Kode_Pemasok) References dbo.Pemasok (Kode_Pemasok) Not Null,
Nama_Pemasok nvarchar(50) Not Null,
Kode_Barang varchar(5) Foreign Key (Kode_Barang) References dbo.Barang (Kode_Barang) Not Null, 
Nama_Barang NVarchar (50) Not Null,
Harga_Barang_Pemasok int Not Null,
Jumlah int Not Null,
Total Int Not Null
)
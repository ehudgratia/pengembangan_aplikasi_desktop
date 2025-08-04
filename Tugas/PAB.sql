SELECT	hp.IDPenjualan, 
		hp.Tanggal, 
		hp.IDPelanggan, 
		p.NamaPelanggan, 
		p.Alamat, 
		p.NoHP,  
		dp.IDProduct, 
		pdt.NamaProduct, 
		dp.Qty, 
		pdt.Unit, 
		pdt.Harga 
		FROM HeaderPenjualan hp INNER JOIN DetailPenjualan dp 
		ON hp.IDPelanggan = dp.IDPenjualan INNER JOIN Pelanggan p 
		ON hp.IDPelanggan = p.IDPelanggan INNER JOIN Product pdt ON dp.IDProduct = pdt.IDProduct
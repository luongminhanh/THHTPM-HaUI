<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
xmlns:msxsl="urn:schemas-microsoft-com:xslt"
xmlns:a="http://tempuri.org/HoaDonHang.xsd"
exclude-result-prefixes="msxsl">
<xsl:output method="html" indent="yes"/>
<xsl:template match="/">
	<html>
		<style>
			
		</style>
		<body>
			<table>
				<th>
					BỆNH VIỆN <xsl:value-of select="a:BenhVien/a:TenBenhVien"/>
				</th>
				<th>DANH SÁCH BỆNH NHÂN</th>
			</table>
				<xsl:for-each select="a:BenhVien/a:DSKhoa/a:Khoa">
					<h3>
						Khoa: <xsl:value-of select="a:TenKhoa"/>
					</h3>
					<table>
						<tr>
							<td>STT</td>
							<td>Họ tên</td>
							<td>Ngày nhập viện</td>
							<td>Số ngày nhập viện</td>
							<td>Số tiền phải trả</td>
						</tr>
						<xsl:for-each select="a:DSBenhNhan/a:BenhNhan">
							<tr>
								<td>
									<xsl:number value="position()"/>
								</td>
								<td>
									<xsl:value-of select="a:HoTen"/>
								</td>
								<td>
									<xsl:value-of select="a:NgayNhapVien"/>
								</td>
								<td>
									<xsl:value-of select="a:SoNgayNamVien"/>
								</td>
								<td>
									<xsl:value-of select="a:SoNgayNamVien * 15000"/>
								</td>
							</tr>						
							
						</xsl:for-each>
					</table>
				</xsl:for-each>				
		</body>
	</html>
</xsl:template>
</xsl:stylesheet>
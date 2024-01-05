<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" 
				xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
				xmlns:msxsl="urn:schemas-microsoft-com:xslt" 
				xmlns:a = "http://tempuri.org/HoaDonHang.xsd"
				exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<style>
				th {
					padding: 0 30px;
				}
				table {
					text-align: center;
				}
			</style>
			<body>
				<table>
					<tr>
						<td width="350px"><h2>BỆNH VIỆN ĐA KHOA</h2></td>
						<td><h2>DANH SÁCH BỆNH NHÂN</h2></td>
					</tr>				
				</table>
				<xsl:for-each select="/a:DSKhoa/a:khoa">
					<h3>Khoa: <xsl:value-of select="a:tenkhoa"/></h3>
				<table border="1">
					<tr style="background-color: green; color: white">
						<th>STT</th>
						<th>Họ tên</th>
						<th>Ngày nhập viện</th>
						<th>Số ngày điều trị</th>
						<th>Số tiền phải trả</th>
					</tr>
					<xsl:for-each select="a:DSBN/a:benhnhan" >
						<tr>
							<td>
								<xsl:number value="position()"/>
							</td>
							<td>
								<xsl:value-of select="a:hoten"/>
							</td>
							<td>
								<xsl:value-of select="a:ngaynhap"/>
							</td>
							<td>
								<xsl:value-of select="a:songaynam"/>
							</td>
							<td>
								<xsl:value-of select="a:songaynam * 15000"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
				</xsl:for-each>				
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>

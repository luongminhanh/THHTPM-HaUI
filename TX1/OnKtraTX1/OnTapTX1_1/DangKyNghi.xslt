<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:a="http://tempuri.org/DangKyNghi.xsd">
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<style>
					table {
					border-collapse: collapse;
					width: 100%;
					text-align: center;
					}
					td {
					border: 1px solid black;
					padding: 8px;
					}
					th {
					background-color: green;
					padding: 8px;
					color: white;
					}
				</style>
			</head>
			<body>
				<table>
					<tr>
						<td colspan="6" style="border: none">
							<h2>DANH SÁCH ĐĂNG KÝ NGHỈ</h2>
						</td>
					</tr>
						<xsl:for-each select="a:DangKy/a:NgayLamViec">
							<tr style="text-align: left; background-color: yellow">
								<td colspan="6">
									<b>Ngày làm việc: </b>
									<xsl:value-of select="@Ngay"/>
								</td>
							</tr>
							<tr>
								<th>STT</th>
								<th>Mã NV</th>
								<th>Lý do</th>
								<th>Đơn vị</th>
								<th>Trạng thái</th>
								<th>Ghi chú</th>
							</tr>
							<xsl:for-each select="a:NhanVien">
							<tr>
								<td>
									<xsl:number value="position()"/>
								</td>
								<td>
									<xsl:value-of select="@MaNV"/>
								</td>
								<td>
									<xsl:value-of select="a:LyDo"/>
								</td>
								<td>
									<xsl:value-of select="a:DonVi"/>
								</td>
								<td>
									<xsl:value-of select="a:TrangThai"/>
								</td>
								<td>
									<xsl:choose>
										<xsl:when test="a:DonVi = 0.5">
											Nghỉ nửa ngày	
										</xsl:when>
										<xsl:otherwise></xsl:otherwise>
									</xsl:choose>
								</td>						
							</tr>
							</xsl:for-each>
						</xsl:for-each>
						<tr>

					</tr>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>

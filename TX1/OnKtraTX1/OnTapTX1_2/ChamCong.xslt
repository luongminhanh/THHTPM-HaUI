<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:a="http://tempuri.org/ChamCong.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<head>
				<style>
					h2 {
						margin: 0;
					}
					table {
						border-collapse: collapse;
						width: 100%;
					}
					th, td {
						border: 1px solid black;
						text-align: center;
						padding: 8px;
					}
					th {
						background-color: green;
						color: white;
					}
				</style>
			</head>
			<body>
				<table>
					<tr>
						<td colspan="6">
							<h2>BẢNG CHẤM CÔNG</h2>
						</td>
					</tr>
					<tr>
						<th>STT</th>
						<th>Mã NV</th>
						<th>Ca làm việc</th>
						<th>Giờ vào</th>
						<th>Giờ ra</th>
						<th>Làm đêm</th>
					</tr>
					<xsl:for-each select="a:ChamCong/a:NgayLamViec">
						<tr>
							<td colspan="6">
								<b>Ngày làm việc: </b><xsl:value-of select="@Ngay"/>
							</td>
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
								<xsl:value-of select="a:CaLamViec"/>
							</td>
							<td>
								<xsl:value-of select="a:GioVao"/>
							</td>
							<td>
								<xsl:value-of select="a:GioRa"/>
							</td>
							<td>
								<xsl:choose>
									<xsl:when test="a:CaLamViec = 'C3'">x</xsl:when>
									<xsl:otherwise></xsl:otherwise>
								</xsl:choose>
							</td>
							</tr>
						</xsl:for-each>
						
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>

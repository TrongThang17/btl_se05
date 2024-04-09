USE db_se05
GO

DROP PROC sp_TimKiemTenTaiKhoan 
GO

CREATE PROCEDURE sp_TimKiemTenTaiKhoan 
@TenTK varchar(20)
AS 
BEGIN
	SELECT * FROM [dbo].[tbl_Taikhoan] WHERE [sTenTK] =  @TenTk
END

GO

DROP PROC sp_ThemTaiKhoan
GO

CREATE PROCEDURE sp_ThemTaiKhoan
@TenTK varchar(20),@sMK VARCHAR(20), @sMaQuyen VARCHAR(10)
AS 
BEGIN
	INSERT INTO [dbo].[tbl_Taikhoan] VALUES (
		(SELECT MAX(PK_sMaTK) FROM [dbo].[tbl_Taikhoan]) + 1,
		@TenTK, @sMK, @sMaQuyen
	)
END

GO

CREATE VIEW vv_Quyen
AS
SELECT * FROM [dbo].[tbl_Quyen]
GO


SELECT * FROM [dbo].[tbl_Taikhoan] 
SELECT * FROM vv_Quyen


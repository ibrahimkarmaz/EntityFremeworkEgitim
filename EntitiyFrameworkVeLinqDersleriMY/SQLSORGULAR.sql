CREATE PROCEDURE NOTLISTESI
AS
SELECT NOTID,AD,SOYAD,DERSAD,SINAV1,SINAV2,SINAV3,ORTALAMA,DURUM FROM TBLNOTLAR 
INNER JOIN TBLOGRENCI ON TBLOGRENCI.ID=TBLNOTLAR.OGR 
INNER JOIN TBLDERSLER ON TBLNOTLAR.DERS=TBLDERSLER.DERSID


EXECUTE NOTLISTESI
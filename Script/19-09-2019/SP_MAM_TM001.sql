

USE [BDDist]
GO
/****** Object:  StoredProcedure [dbo].[sp_Mam_TM001]    Script Date: 08/07/2019 6:49:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





------------Ojo el deiblle de la identidad comenzara en 1000 para que no haiga datos duplicado con los id que genera el deiblle

--drop procedure sp_Mam_TM001
ALTER PROCEDURE [dbo].[sp_Mam_TM001] (@tipo int,@ibid int=-1,@ibfdoc date=null, @ibconcep int=-1, @ibobs nvarchar(40)='', @ibest int=-1, 
									   @ibalm int=-1, @ibiddc int=-1, @ibidchof int=-1, @ibidvent int=-1, @ibidconcil int=-1, 
									   @ibuact nvarchar(10)='', @TM0011 Mam_TM0011Type ReadOnly, @chofer int=-1, @concepto int=-1,
									   @nota int=-1, @tprod int=-1,@idrepartidor int=-1)

AS
BEGIN
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))
	declare @icid int
	DECLARE @newFecha date
	set @newFecha=GETDATE()

	IF @tipo=-1 --ELIMINAR REGISTRO
	BEGIN
		BEGIN TRY 
			delete from TM001 where ibid=@ibid
			delete from TM0011 WHERE icibid=@ibid;
			select @ibid as newNumi  --Consulibr que hace newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@ibuact)
		END CATCH
	END

	IF @tipo=1 --NUEVO REGISTRO
	BEGIN
		BEGIN TRY 
			set @ibid=IIF((select COUNT(ibid) from TM001)=0,0,(select MAX(ibid) from TM001))+1

			INSERT INTO TM001 VALUES(@ibid, @ibfdoc, @ibconcep, @ibobs, @ibest,@ibalm, @ibiddc, @ibidchof, @ibidvent, @ibidconcil,
									 @nota, @tprod, @newFecha, @newHora, @ibuact)
			if (@ibconcep=24)
			begin 
			INSERT INTO TM0012 VALUES(@ibid,1)
			end
			select @ibid as newNumi  --Consulibr que hace newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@ibuact)
		END CATCH
	END
	IF @tipo=10 --NUEVO Detalle
	BEGIN
		BEGIN TRY 
			----INSERTO EL DEtaLLE
			set @icid=IIF((select COUNT(icid) from TM0011)=0,0,(select MAX(icid) from TM0011))+1
				INSERT INTO TM0011(icid,icibid,iccprod ,iccant)
			SELECT @icid,@ibid,td.iccprod ,td.iccant
			   FROM @TM0011 AS td
			where td.estado =0 and  td.iccprod >0
			select @ibid as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),10,@newFecha,@newHora,@ibuact)
		END CATCH
	END
	IF @tipo=11 --MODIFICO DETALLE
	BEGIN
		BEGIN TRY 

			--MODIFICO LOS REGISTROS
			UPDATE TM0011
			SET iccprod  =td.iccprod ,iccant =td.iccant  
			FROM TM0011  INNER JOIN @TM0011 AS td
			ON TM0011 .icid     = td.icid    and td.estado =2;
			select @ibid as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),11,@newFecha,@newHora,@ibuact)
		END CATCH
	END

	IF @tipo=12 --ELIMINO DETALLE
	BEGIN
		BEGIN TRY 
			--ELIMINO LOS REGISTROS
			DELETE FROM TM0011 WHERE icid   in (SELECT td.icid   FROM @TM0011 AS td WHERE td.estado=-1)
			select @ibid as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),12,@newFecha,@newHora,@ibuact)
		END CATCH
	END
	IF @tipo=2--MODIFICACION
	BEGIN
		BEGIN TRY 

			UPDATE 
				TM001 SET ibfdoc=@ibfdoc, ibconcep=@ibconcep, ibobs=@ibobs, ibidchof=@ibidchof,
				ibfact=@newFecha, ibhact=@newHora, ibuact=@ibuact 
			where 
				ibid=@ibid		
			select @ibid as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),2,@newFecha,@newHora,@ibuact)
		END CATCH
	END

	IF @tipo=3 --MOSTRaR TODOS
	BEGIN
		BEGIN TRY
		
		select 
			a.ibid,a.ibfdoc, a.ibconcep, b.cpdesc as concepto, a.ibobs, a.ibest, a.ibalm, a.ibiddc, a.ibidchof, 
			c.cbdesc as chofer, a.ibidvent, a.ibfact, a.ibhact, a.ibuact, a.ibidconcil
		from 
			TM001 as a inner join TCI001 as b on a.ibconcep=b.cpnumi 
			inner join TC002 as c on c.cbnumi=a.ibidchof 
		order by a.ibid
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END

	IF @tipo=4 --MOSTRaR Deiblle
	BEGIN
		BEGIN TRY
		
		select a.icid ,a.icibid ,a.iccprod ,b.cadesc as producto,a.iccant ,Cast(null as image ) as img,1 as estado
		from TM0011 as a inner join TC001 as b on a.iccprod =b.canumi and b.caest =1 and a.icibid =@ibid 

			order by a.icid  asc
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),4,@newFecha,@newHora,@ibuact)
		END CATCH

END

	IF @tipo=5 --MOSTRaR Productos Para el movimiento
	BEGIN
		BEGIN TRY
		select a.canumi ,a.cadesc ,a.cadesc2 
		from TC001 as a
	
		 order by a.canumi  asc 

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),5,@newFecha,@newHora,@ibuact)
		END CATCH

END

	IF @tipo=6 --MOSTRaR Empleado Choferes
	BEGIN
		BEGIN TRY
	select a.cbnumi ,a.cbdesc ,a.cbci ,a.cbfnac 
	from TC002 as a inner join TC0051 as b on b.cecon =7 and a.cbcat =b.cenum 
	and b.cenum =1
	order by a.cbnumi asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),6,@newFecha,@newHora,@ibuact)
		END CATCH

END
IF @tipo=7 ----Obtener Librerias
	BEGIN
		BEGIN TRY
	select a.cpnumi ,a.cpdesc  
	from TCI001 as a
	order by a.cpnumi  asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),7,@newFecha,@newHora,@ibuact)
		END CATCH

END	

IF @tipo=8 --ObtenerProductos Sacados por el chofer en el dia
	BEGIN
		BEGIN TRY
	select producto .canumi ,producto .cadesc 
from TC001 as producto  where producto.canumi in (
select b.iccprod 
from TM001 as a , TM0011 as b where a.ibid =b.icibid and a.ibidchof =@chofer  and a.ibfdoc=@ibfdoc  and a.ibconcep =@concepto) -----Ojo EL concepto debe ser igual a numi de la tabla

				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),8,@newFecha,@newHora,@ibuact)
		END CATCH

END	
IF @tipo=9 --Numi de las salidas del chofer en el dia =Columnas
	BEGIN
		BEGIN TRY
select a.ibid 
from TM001 as a where a.ibidchof =@chofer  and a.ibfdoc =@ibfdoc  and a.ibconcep =@concepto   -----------numi concepto
order by a.ibid
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),9,@newFecha,@newHora,@ibuact)
		END CATCH

END	

IF @tipo=13 --todos los productos con numi de los movimientos 
	BEGIN
		BEGIN TRY
select b.ibid,a.iccprod ,a.iccant 
from TM0011 as a, TM001 as b where a.icibid =b.ibid and b.ibidchof =@chofer  and b.ibfdoc=@ibfdoc  and b.ibconcep =@concepto 
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),13,@newFecha,@newHora,@ibuact)
		END CATCH

END	
IF @tipo=14--todos los productos con numi de los movimientos 
	BEGIN
		BEGIN TRY
select b.ibid,a.iccprod ,a.iccant ,a.icid 
from TM0011 as a, TM001 as b where a.icibid =b.ibid and b.ibidchof =@chofer  and b.ibfdoc=@ibfdoc  and b.ibconcep =@concepto 
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),14,@newFecha,@newHora,@ibuact)
		END CATCH

END	


IF @tipo=15--todos los productos con numi de los movimientos 
	BEGIN
		BEGIN TRY
select a.ibid,a.ibuact ,a.ibalm ,a.ibconcep 
from TM001 as a where a.ibconcep =@concepto and a.ibidchof =@chofer and a.ibfdoc =@ibfdoc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),15,@newFecha,@newHora,@ibuact)
		END CATCH

END	
IF @tipo=16--No Existe Conciliacion Pendiente o con Venta Obtengo la que tiene estado=1
	BEGIN
		BEGIN TRY
			select a.ibid, b.ieest, b.ieid 
			from TM001 as a, TM0012 as b 
			where a.ibid=b.ieconcti2 and a.ibidchof=@chofer and b.ieest=1 and a.ibtprod=@tprod
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),16,@newFecha,@newHora,@ibuact)
		END CATCH
END	

IF @tipo=17--Verificar si existe numero de conciliacion con estado =2 o =3 
	BEGIN
		BEGIN TRY

select Max(a.ibid) as ibid ,b.ieest 
from TM001 as a ,TM0012 as b where a.ibid =b.ieconcti2 and a.ibidchof =@chofer and b.ieest >0 
group by ibid,ieest 
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),17,@newFecha,@newHora,@ibuact)
		END CATCH

END	
IF @tipo=18--Modificar Estado de la TM0012  
	BEGIN
		BEGIN TRY

		set @icid =(select TM0012 .ieid 
		from TM0012 where TM0012.ieconcti2 =@ibid)
update TM0012 set TM0012.ieest  =@ibest 
where TM0012.ieid =@icid 
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),18,@newFecha,@newHora,@ibuact)
		END CATCH

END	
IF @tipo=100--Modificar Estado de la TM0012  
	BEGIN
		BEGIN TRY

select *
from (
SELECT DISTINCT oanumi,oafdoc,oahora,oaccli,ccdesc,ccdirec,cctelf2,cccat,oazona,cedesc,oaobs,oaobs2,oaest,cclat
,cclongi,oaap,oapg,ccultvent, DATEDIFF(D,  oafdoc, getdate()) as diasretraso,'Entregado' as estado
FROM TO001,TC004,TC0051,TL001,TL0012 WHERE oanumi=oanumi AND ccnumi=oaccli AND cczona=lanumi AND cecon=2 
AND lazona=cenum and tc004.cczona = tl001.lanumi and tl001.lanumi = tl0012.lcnumi AND (oaest=3 ) 
AND oaap=1 and Year(oafdoc )=Year(GETDATE ()) AND tl0012.lccbnumi=@idrepartidor 
and oanumi in (
select MAx(oanumi )
from TO001 as pedido where pedido.oaccli =ccnumi and pedido .oafdoc  <= DATEADD(dd,-20,GETDATE()))--and DATEDIFF(D,  pedido .oafdoc, getdate()) >= 20)
 )as a
 where a.diasretraso<=50
 order by diasretraso asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),18,@newFecha,@newHora,@ibuact)
		END CATCH

END	
End


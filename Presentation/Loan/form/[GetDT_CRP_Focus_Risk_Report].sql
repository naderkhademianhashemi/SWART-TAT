USE [Risk_Mng_TAT_OLTP]
GO
/****** Object:  StoredProcedure [dbo].[GetDT_CRP_Focus_Risk_Report]    Script Date: 08/06/2012 16:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetDT_CRP_Focus_Risk_Report]	
	(@CRP_Model_Report_Id int,  @GroupBy int)
AS
BEGIN
	SET NOCOUNT ON;

  DECLARE @TotalOverdue numeric(38,2)
  DECLARE @Remaining_Amount numeric(38,2)
  DECLARE @EstimatedProvision numeric(38,2)
	DECLARE @Overdue1 numeric(38,2)
	DECLARE @Overdue2 numeric(38,2)
	DECLARE @Overdue3 numeric(38,2)

delete CRP_Model_Report_Result
where (Remaining_Amount = 0 or Remaining_Amount is null ) 

 SET @TotalOverdue =  (SELECT TotalOverdueBank  FROM   dbo.CRP_Model_Report
				       WHERE  Id = @CRP_Model_Report_Id)



 SET @Remaining_Amount =  (SELECT Remaining_AmountBank  FROM   dbo.CRP_Model_Report
		
 		           WHERE  Id = @CRP_Model_Report_Id)


SET @EstimatedProvision =  (SELECT EstimatedProvisionBank FROM   dbo.CRP_Model_Report
	           	           WHERE  Id = @CRP_Model_Report_Id)


SET @Overdue1 =  (SELECT Overdue1Bank FROM   dbo.CRP_Model_Report
	           	           WHERE  Id = @CRP_Model_Report_Id)

SET @Overdue2 =  (SELECT Overdue2Bank FROM   dbo.CRP_Model_Report
	           	           WHERE  Id = @CRP_Model_Report_Id)

SET @Overdue3 =  (SELECT Overdue3Bank FROM   dbo.CRP_Model_Report
	           	           WHERE  Id = @CRP_Model_Report_Id)
IF @Overdue3 = 0 
  SET @Overdue3 = 1

  SELECT Group_Desc ,
		
			(SELECT  Remaining_Amount  
			 FROM   dbo.CRP_Model_Report_Result
			 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy )  AS   "مانده تسهيلات",

			(SELECT  Remaining_Amount/ @Remaining_Amount  -- سهم از مانده تسهيلات
			 FROM   dbo.CRP_Model_Report_Result
			 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy )* 100 AS Remaining_Amount,

          	(SELECT  TotalOverdue 
			 FROM   dbo.CRP_Model_Report_Result
			 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy) as "کل معوقات" ,
			 
			(SELECT  TotalOverdue/ @TotalOverdue -- سهم از كل مانده سر رسيده
			 FROM   dbo.CRP_Model_Report_Result
			 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy)*100 AS TotalOverdue ,
			 
			 (SELECT  EstimatedProvision  -- سهم از ذخيره
			 FROM   dbo.CRP_Model_Report_Result
			 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy) AS "ذخیره" ,
--
			(SELECT  EstimatedProvision/ @EstimatedProvision -- سهم از ذخيره
			 FROM   dbo.CRP_Model_Report_Result
			 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy)* 100 AS EL ,

--null as TotalOverdueRemaining
--
			(SELECT  TotalOverdue/ Remaining_Amount  -- مانده سر رسيده به مانده تسهيلات		
         	 FROM   dbo.CRP_Model_Report_Result
			 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy )* 100 AS TotalOverdueRemaining,
--               

			(SELECT  Overdue1  --  مطالبات معوق
					 FROM   dbo.CRP_Model_Report_Result
					 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy ) AS " معوق",
--
			(SELECT  Overdue1/ @Overdue1  -- سهم از مطالبات معوق
					 FROM   dbo.CRP_Model_Report_Result
					 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy )* 100 AS Overdue1,


	(SELECT   Overdue2  -- سهم از سر رسید گذشته
					 FROM   dbo.CRP_Model_Report_Result
  				     WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy ) AS "سررسیدگذشته",

			(SELECT   Overdue2/ @Overdue2  -- سهم از سر رسید گذشته
					 FROM   dbo.CRP_Model_Report_Result
  				     WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy )* 100 AS Overdue2,
  				     
  				     	(SELECT  Overdue3/ isnull(@Overdue3,1) --مشکوک الوصول 
					 FROM   dbo.CRP_Model_Report_Result
					 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy ) AS "مشکوک الوصول",


			(SELECT  Overdue3/ isnull(@Overdue3,1) --مشکوک الوصول 
					 FROM   dbo.CRP_Model_Report_Result
					 WHERE  CRP_Model_Report_Id = @CRP_Model_Report_Id and Group_Id = R.Group_Id AND GroupBy = @GroupBy )* 100 AS Overdue3

,COunt AS "تعداد"
  FROM dbo.CRP_Model_Report_Result R 
  WHERE CRP_Model_Report_Id = @CRP_Model_Report_Id AND GroupBy = @GroupBy 
--group by  Group_Id


END

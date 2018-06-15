USE [SKFinancialAdvisors]
GO

/****** Object:  StoredProcedure [dbo].[sp_getprofile]    Script Date: 6/14/2018 8:01:38 PM ******/
DROP PROCEDURE [dbo].[sp_getprofile]
GO

/****** Object:  StoredProcedure [dbo].[sp_getprofile]    Script Date: 6/14/2018 8:01:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_getprofile]
	-- Add the parameters for the stored procedure here
	@Id bigint	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT adv.FirstName, adv.LastName, adv.Sector from Advisors adv
	where adv.Id = @Id
END
GO



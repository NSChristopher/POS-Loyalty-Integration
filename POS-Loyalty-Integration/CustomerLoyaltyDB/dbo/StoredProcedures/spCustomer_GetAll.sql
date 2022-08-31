CREATE PROCEDURE [dbo].[spCustomer_GetAll]
AS
begin
	select *
	from dbo.[Customer];
end
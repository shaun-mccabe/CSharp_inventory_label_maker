CREATE TABLE [dbo].[it_assets]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [type] TEXT NULL, 
    [name] TEXT NULL, 
    [serial_number] TEXT NULL, 
    [model_number] TEXT NULL, 
    [descr] TEXT NULL, 
    [company_tracking_id] TEXT NULL, 
    [photograph] IMAGE NULL
)

CREATE TABLE [dbo].[Ticket]
(
	[IDTicket] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Price] NCHAR(10) NULL, 
    [DepartureDate] NCHAR(10) NULL, 
    [ArivalDate] NCHAR(10) NULL, 
    [IDStatus] NCHAR(10) NULL, 
    [IDTrain] NCHAR(10) NULL
)

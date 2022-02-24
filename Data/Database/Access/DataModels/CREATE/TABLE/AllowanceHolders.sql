CREATE TABLE AllowanceHolders
(
   AllowanceHoldersId INTEGER NOT NULL UNIQUE CONSTRAINT PrimaryKeyAllowanceHolder PRIMARY KEY,
   Code NVARCHAR(255),
   Name NVARCHAR(255)
);
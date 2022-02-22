CREATE TABLE IF NOT EXISTS Changes
(
	    ChangesId INTEGER NOT NULL UNIQUE CONSTRAINT PrimaryKeyChanges PRIMARY KEY,
	    TableName TEXT(255) DEFAULT "NS",
	    FieldName TEXT(255) DEFAULT "NS",
	    ActionType TEXT(255) DEFAULT "NS",
	    OldValue TEXT(255) DEFAULT "NS",
	    NewValue TEXT(255) DEFAULT "NS",
	    ChangeDate DATETIME NULL,
	    Message TEXT(255) DEFAULT "NS"
);
-- Connect to the master database to create the login
USE master;
GO

-- Create a new login for the service account
CREATE LOGIN serviceAccount WITH PASSWORD = 'Prod1234';
GO

-- Switch to your target database
USE BodyByBurgersDB;
GO

-- Create a user for the login in the target database
CREATE USER serviceAccount FOR LOGIN serviceAccount;
GO

-- Grant necessary permissions to the user
-- Example: Grant db_datareader and db_datawriter roles
ALTER ROLE db_datareader ADD MEMBER serviceAccount;
ALTER ROLE db_datawriter ADD MEMBER serviceAccount;
GO
-- Drop the existing Appointments table if it exists
IF OBJECT_ID('dbo.Appointments', 'U') IS NOT NULL
BEGIN
    DROP TABLE dbo.Appointments;
END;

-- Create the new Appointments table
CREATE TABLE [dbo].[Appointments]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [UserId] INT NOT NULL,
    [DoctorId] INT NOT NULL,
    [AppointmentDateTime] DATETIME NOT NULL,
    FOREIGN KEY (UserId) REFERENCES Users(Id),
    FOREIGN KEY (DoctorId) REFERENCES Doctors(Id)
);

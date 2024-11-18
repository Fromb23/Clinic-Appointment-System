DECLARE @ConstraintName NVARCHAR(200)
SELECT @ConstraintName = Name
FROM sys.key_constraints
WHERE [type] = 'UQ' AND [parent_object_id] = OBJECT_ID('dbo.Users')

IF @ConstraintName IS NOT NULL
BEGIN
    EXEC('ALTER TABLE dbo.Users DROP CONSTRAINT ' + @ConstraintName)
END
CREATE TABLE [dbo].[student_info] (
    [roll_no]    VARCHAR (6)   NOT NULL,
    [name]       VARCHAR (100) NULL,
    [Department] VARCHAR (5)   NULL,
    [Section]    VARCHAR (5)   NULL,
    [year]       VARCHAR (20)  NULL,
    UNIQUE NONCLUSTERED ([roll_no] ASC)
);


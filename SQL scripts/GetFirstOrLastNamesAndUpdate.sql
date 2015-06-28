--This query selects first name
SELECT QuarterbacksFourteen.Name, Left(Name, CHARINDEX(' ', Name)) AS First_Name
FROM QuarterbacksFourteen;

--update function (swap the SET logic from left to right for first name versus last name)
UPDATE QuarterbacksFourteen 
SET LastName = Right(Name, LEN(Name)-CHARINDEX(' ', Name))

--use this query to check updates worked properly
SELECT Name, FirstName, LastName
From QuarterbacksFourteen

--This query selects the last name
SELECT QuarterbacksFourteen.Name, Right(Name, LEN(Name)-CHARINDEX(' ', Name)) AS Last_Name
FROM QuarterbacksFourteen;
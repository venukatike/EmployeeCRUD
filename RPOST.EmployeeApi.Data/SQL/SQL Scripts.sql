--CREATE DATABASE ----
CREATE DATABASE EMP

USE EMP;

CREATE Table Projects(ProjectWBSId varchar(50) Primary Key
						,ProjectName varchar(10)
						,ProjectLocation varchar(10)
						,CreatedDate DateTime DEFAULT GETDATE()
						,ModifiedDate DateTime DEFAULT GETDATE()
						,CreatedUser varchar(20)
						,ModifiedUser varchar(20));

INSERT INTO Projects(ProjectWBSId
					,ProjectName
					,ProjectLocation
					,CreatedUser,ModifiedUser) 
			Values('HPA US.1767.45'
					,'HPA'
					,'Hyderabad'
					,'Venu'
					,'Venu'
					);

Select * from Employee


CREATE TABLE JuncEmployeeProjects(EmployeeId varchar(10), ProjectWBSId varchar(50), Primary Key(EmployeeId,ProjectWBSId)
									,FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
									,FOREIGN KEY (ProjectWBSId) REFERENCES Projects(ProjectWBSId))

INSERT INTO JuncEmployeeProjects Values('A65578','HPA US.1767.45')

select * from JuncEmployeeProjects



--Practice Purpose Created Table Named PracticeTable ---

USE EMP
--DROP TABLE PracticeTable
CREATE TABLE PracticeTable(ProductID varchar(20) Primary key, ProductName varchar(30), ProductPrice DECIMAL(10,2));

INSERT INTO PracticeTable values('A001','Iphone 12',50000.00600)
INSERT INTO PracticeTable values('A002','Iphone 13',60000.00400)
INSERT INTO PracticeTable values('A003','Iphone 14',70000.00400)
INSERT INTO PracticeTable values('A004','Iphone 15',80000.00400)
INSERT INTO PracticeTable values('A005','Iphone 16',90000.012201111000000400)

SELECT * FROM PracticeTable
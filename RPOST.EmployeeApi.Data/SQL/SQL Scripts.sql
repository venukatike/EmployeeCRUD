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
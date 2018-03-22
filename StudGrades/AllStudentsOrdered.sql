select Student.FIO, Groups.GroupName
from Student
inner join Groups
on Student.Group_number = Groups.GroupId
order by Groups.GroupName, Student.FIO

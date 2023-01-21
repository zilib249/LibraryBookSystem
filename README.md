# LibraryBookSystem

 
Source code guidline:

Open the sln file from below link:

LibraryBookSystem\WebApplication1\LibrarySystem.sln

Requirement map in vs as below:

 1- Create DB for library system content books information and author (organize the tables as you think it's appropriate):

 Sql server version : Microsoft SQL Server 2017 (RTM) - 14.0.1000.169 (X64)   Aug 22 2017 17:04:49 

 LibrarySystem\App_Data\LibrarySystemDb.bak

 2-Use two methods of retrieving data from database using entity framework and stored procedure:

a.Using entity framework: 

Controller/BooksController/Index

b.Using SP:
Note:to test should try it thourgh type it as a link
Controller/BooksController/AllBooks
 
 3- Create page with two dropdown list , one list is filter by the second one like (main category of the book and the subcategory of the book):
 
 Create new Book in the Book Controller:
 
 json function GetSubCategory() to call sub category based on selected main category
 
4- Provide API to let other developers to access your data

Controller/BooksAPIController/

5- Call external API like stackoverflow and display the data in view (two pages , one to show list of last 50 questions , second one for showing details of question that user click on it from the list) 

Views/Question/Index

6- Do something with vanilla JS

Views/Question/Details 



 
 







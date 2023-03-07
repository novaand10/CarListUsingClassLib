Given a simple existing app to display second car on sale at a Second Car Dealer Website as below capture

![image](https://user-images.githubusercontent.com/44523673/216550250-27a4e44c-70be-4cfc-ae72-b34f823aa295.png)

This app using technology stack : C#, Entity Framework

How to run this app
- Clone this repository https://github.com/flemingsyaifullah/testapp.git
- open the solution using visual studio 2019/2022
- run the app and click Car Listing menu
- the database should be auto created with 2 empty tables (Car & CarManufacturer)
- Get existing data by execute db_script.sql

<b>Your test cases :</b>

1. This app still has no interface, please create interface <i>ICarListingService</i> for this app with abstract method <i>GetCarListing</i>

2. Please give implementation to the abstract method of the interface. 
The implementation is just to migrate existing method <i>CarListing (public ActionResult CarListing())</i> 
whereas currently still implemented at controller (HomeController). There is no logic changes

3. The dealer plan to open a new showroom branch at ABC city and need to follow regulation of ABC city as below :</br>
- Need to add column Plate Number Expired Date at the UI
- Need to add column Car Status at the UI with below condition</br>
  For local car type
  - if plate number expired date <= 5 years of the date now then Car Status should be displayed "Bisa dijual"
  - if plate number expired date > 5 years of the date now then Car Status should be displayed "Tidak bisa dijual" </br>
  
  For CBU (import) car type
  - if plate number expired date <= 3 years of the date now then Car Status should be displayed "Bisa dijual"
  - if plate number expired date > 3 years of the date now then Car Status should be displayed "Tidak bisa dijual"
- Need to add column Import Date for CBU car type only
- Need to add column Assembly Date (tanggal perakitan) for local car type only

Please develop above logic by giving new implementation to the abstract method of the interface
  
To implement test case no. 3 you should <b>Not modify</b> the existing method implementation (test case number 2) because it used by current city.</br> 
And <b>Not modify</b> Car and CarManufacturer classes because they are root classes. But you can create inheritance class from them.</br>

You should use Entity Framework for query.<br/>
In case you are not familiar with Entity Framework you can rewrite the query using another ORM (eg. Dapper) or Stored Procedure

Please also update data at db_script.sql as necessary for our testing.<br/>
Once completed, please give us your link (Dropbox etc) to download the test result

Note : Rewrite this test solution in .NET 6 or 7 is a big plus since this test app still using .NET Framework 4.8 (optional) 

Thank you

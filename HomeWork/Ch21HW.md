## C# hw ch21 
## Deniqtrius Curry
## May 5, 2018

1. Linq is just the way C# can access and query relational databases in a flexable way. It pretty much copies the way sql is written but theres a lot of differences. 
It doesnt render sql obsolete because sql is simpler. 

2. The datastructure needs to be an enumerable type so that it can systematically query each element. 

3. The linq select method lives in the enumerable class. 

4. IEnumerable<string> is an interface called IEnumerable and its type is string. customerFirstNames is the 
instance of this class. customers.Select takes the property customers of the customerFirstNames instance and uses 
the select method on it. It selects the first name property of each cust using a lamda expression. 

5. The first part of this line is the same as the one in question 4 with usCompanies as the instance. The second part 
uses addresses.Where to call the Where method on the instance field addresses and filters it by selecting only the addr where 
the string equals "united states" by using the string.Equals method which takes parameters of where its looking in - 
addr.Country field and the string its looking for - "United States". Its only selecting the fields usComp.CompanyName 
using the lamda expression. 

6. The instance this time is called companyNames and it is set equal to addresses in the order of CompanyName in aphabetical 
order and we are only selecting the CompanyName's into this list. 

7. Group by contains all the fields in the original collection and orders it based on the field Country. 

8. Without the method Distince it would return the total count of all Country entries. The distinct method 
returns only the unique Country entries. 

9. This code stores the data in companiesAndCustomers instance where the fields firstname lastname and companyname. The 
values are populated from the combined collections of addresses and custs where the addresses are the countries, the 
firstname is from cust.FirstName and lastname is from cust.LastName. 

10. The difference is that data from a deffered collection is read when it is iterated over not when its called. The 
cached collection can be read immediately and doesnt use the most up to date data. It uses the data from that point in time. 
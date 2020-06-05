# Bees - C# Code Test
I created an ASP.NET Core MVC application for this code test.

**Part 1 - The Classes**
----
* Since this is an ASP.NET MVC application, all of the classes are located in the Models folder
* All the requirements that were specified for the classes have been implemented
* The classes should be extensible


**Part 2 - The Application**
----
Completed most of Part 2 - up until the last requirement:

***After each click the status of the bees should be updated*** - did not achieve this properly 
  * Clicking the button again ends up resetting the list containing the instances of bees - and then applies damage to that new list
  * Probably due to the request going to the Controller again and reinitializing the list
  * I did try different ways to solve this, but didn't want to spend too much more time than was allocated for the test, though I should be able to solve it given more time.

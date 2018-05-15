## C# Ch20 HW
## Deniqtrius Curry 
## May 5, 2018

1. A delegate is a reference to a method like an alias. 

2. You declare a delegate by using the keyword delegate, the return type, the delegate name, and any parameters followed by semicolon. 

3. You can create instances of the delegate by making an instance name of type delegateName. You assign values to the instance by calling the instance name 
and using += to refer it to a real method. 

4. You invoke a method thats been added to a delegate by using the same syntax that you would to call any method but using the delegate name and including 
any parameters it takes inside the parenthesis. 

5. An event traps significant actions and arranges for a delegate to be called to immdediately handle a situation. 

6. You declare events just like you declare a field but with the event keyword followed by the delegate type name and then the event name. 

7. Delegates recognize even subscriptions by using the += operator and unsubscribe by using the -= operator. 

8. You raise an event by calling it like a method. You declare code that raises an event kind of like you would with a catch block because you are 
catching things that shouldnt normally happen.  
	if (eventName != null)
	{
	eventName();
	} 
	
9. When an event fires all the delegates attached to the event run in order. 
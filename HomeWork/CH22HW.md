# C# hw ch22 
## Deniqtrius Curry
## May 5, 2018

1. The difference between associativity and precedence is precedence is a language specific concept and associativity is a math concept. Associativity tells what math operator 
should be done before other math operators and precedence tells what computer operations should be done before other computer operations. 

2. The difference between binary and urnary operators is binary has two operands and urnary has one operand. 

3. The four constraints are 1) you cant change precedence or associativity of an operator, 2) you cant change the number of operands of an operator, 3) you cant change the meaning 
of operators when they are applied to built in types, 4) you cant overload operator symbols that dont allow it. 

4. The syntax for overloading operators is to make it look like a method. Define it as public static and the operator type. Then the operator and the parameters. 
What the operator does is in the method body. It also has a return type and a name but the name of the operator is the operator keyword. 

5. Symetric overload binary operators are operators that take the same type parameter as opposed to nonsymmetric which take two different type operands. 

6. You can overload compound assignment operators as long as the operator manipulation works with the two types. 

7. Overloading unary operators for reference types doesnt work because updating a new value for the reference type will automatically update its reference. 

8. We overload some operators in pairs because it only makes sense to update one operator and its logical opposite. 

9. The difference between widening conversion and narrowing conversion is widening conversion allows for more types to be accepted and it can take more information 
than it accepts, narrowing conversion takes in LESS information than it is given. 

10. Explicit conversion is where you need to write out what will happen when you convert one type to another. Implicit does it automatically. 
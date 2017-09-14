# sci-calculator
Scientific Calculator made as a project for my Diploma in Software Development.
P446206
C Marteli

Programming III

Scientific Calculator


Contents
Data Structures	3
Algorithms	4
Recommended testing procedure	5
Recommended upgrades and future enhancements	6




Data Structures

Variables
Name	Type	Purpose
TxtOutput	TextBox	The calculators “display” which can be converted to string. Used to display user input.
doubleVariable1	double	Stores the first number which will be used alongside the second variable to perform operations.
doubleVariable2	double	Stores the second number which will be used alongside the first variable.
plusButtonClicked	boolean	Variable used when equal button is pressed to tell the program which calculation will be performed.
minusButtonClicked	boolean	Variable used when equal button is pressed to tell the program which calculation will be performed.
divideButtonClicked	boolean	Variable used when equal button is pressed to tell the program which calculation will be performed.
multiplyButtonClicked	boolean	Variable used when equal button is pressed to tell the program which calculation will be performed.
		





Algorithms

Basic Math:
class Arithmetic
	static double Add(double a, double b)
		return (a+b)
	static double Sub(double a, double b)
		return (a-b)
	static double Div(double a, double b)
		return (a/b)
	static double Mult(double a, double b)
		return (a*b)

Algebraic:
class Algebraic
	static double SqRoot(double a)
		return Math.Sqrt(a)
	static double CubeRoot(double a)
		return Math.Pow(a,(1.0/3.0))
	static double InverseRoot(double a)
		return Math.Pow(a,-1)

Trigonometric:
class Trigonometric 
	static double Sine(double a)
		return Math.Sin(a)
	static double Cosine(double a)
		return Math.Cos(a)
	static double Tangent(double a)
		return Math.Tan(a)
 
Error handling:
Each calculation method is wrapped in a try-catch statement, with two catches one which looks for FormatException and one for general Exceptions when caught they both display text boxes prompting the user for correct input. As an added error handling technique the decimal button disables itself after it has been clicked to avoid having multiple decimals in one number.
		 
Recommended testing procedure:

Internal testing:
All methods that perform calculations should be tested with dummy data.
Here’s a table of a typical test of the calculator.

Test	Expected	Result
Tangent 90	“Undefined”	Undefined
9 * 9	81	81
Cube Root 8	2	2
Square Root 9	3	3
15 + 26	41	41
1987.05 – 465.213	1521.837	1521.837
Tangent 180	0	1.33869021035115
Cosine 72	0.309	-0.997…
 
It’s important to note that tangent of 180 (a straight line) should always be 0. And tangent of 90 should be undefined.

External testing:

This project should ideally be tested by beta release to the public with a built in error-reporting feature as well as feedback forms to be filled with suggestions for future updates.


Recommended upgrades and future enhancements

The main addition to the calculator would be adding multiple calculation support such as being able to three or variables and solving those using BIMDAS, using linked lists could be a viable option.

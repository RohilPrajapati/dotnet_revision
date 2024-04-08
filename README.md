# dotnet_revision
colz dotnet practice

### Change file and Run the particular C# file


- change the following code  in dotnet_revision.csproj
```xml
<StartupObject>MyApp.ClassNameYouWantToRun</StartupObject>
```
- change the "ClassNameYouWantToRun" to class/file you want to run

## Notes from w3School

### C# Type Casting

Type casting is when you assign a value of one data type to another type.

In c#, there are two type of casting:

-  **Implicit Casting** (automatically) - converting a smaller type to a large type size like

char -> int -> long -> float -> double

- **Explicit Casting** (manually) - converting a large type to a smaller size type

double -> float -> long -> int -> char

**Implicit Casting Example**
```c#
int integerVal = 10;
double doubleVal = integerVal;  //automatically casting int to double

Console.WriteLine(integerVal);
Console.WriteLine(doubleVal);
```

**Explicit Casting**

Explicit casting must be done manually by placing the type in parentheses in front of the value:
```c#
double doubleVal = 9.87d;
int integerVal = (int) doubleVal; //manually casting double to int

Console.WriteLine(doubleVal);
Console.WriteLine(integerVal);
```

Type Conversion Methods

It is also possible to convert data types explicitly by using built-in methods, such as 
```Convert.ToBoolean```, ```Convert.ToDouble```, ```Convert.ToString```, ```Convert.ToInt32``` (int) and ```Convert.ToInt64``` (long):

```cs
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
```

***
### User Input

To take user input in c# we use ```Console.ReadLine()``` function. ```
Console.ReadLine();``` return string by default so if we want to get number we have to cast use explicit casting as shown in example.

```cs
// getting the username from user
Console.Write("Enter the Username:")
string username = Console.ReadLine();

// getting the username from phone number from user
Console.Write("Enter the Phone number:")
int phoneNo = Convert.ToInt64(Console.ReadLine());
```
***

### C# operators

**Arithmetic**

Operators are used to perform operations on variables and values.
- ```+``` Addition
- ```-``` Subtract 
- ```*``` Multiple 
- ```/``` Divide 
- ```%``` Modulus 
- ```++``` Increment
- ```--``` Decrement 

**Assignment**

- ```=``` same as x = 5
- ```+=``` same as x = x + 5
- ```-=``` same as x = x - 5
- ```*=``` same as x = x * 5
- ```/=``` same as x = x / 5
- ```%=``` same as x = x % 5
- ```&=``` same as x = x & 5
- ```|=``` same as x = x | 5
- ```^=``` same as x = x ^ 5
- ```>>=``` same as x = x >> 5 righ shift operator
- ```<<=``` same as x = x << 5 left shift operator 

**Comparison**

- ```==``` equal to
- ```!=``` not equal to
- ```>``` greater than
- ```<``` less than
- ```>=``` greater than or equal to
- ```<=``` less then or equal to

**Logical**

- ```&&``` logical and 
- ```||``` logical or 
- ```!``` logical not 

*** 
### String Operation

-  to get length of string ```Length```
```cs 
string str = "Hello World";
int len = str.Length;
Console.WriteLine("length :"+ len);
```

- to join two string using ```Concat(str1,str2)```
```cs
string str1 = "Hello ";
string str2 = "World";
string join_string = string.Concat(str1,str2);
Console.WriteLine(join_string);
```

- comparing two string ```Equals()```
```cs
// create string
string str1 = "Hello World";
string str2 = "Hello World";
string str3 = "World";

// compare str1 and str2
Boolean result1 = str1.Equals(str2);
Console.WriteLine("string str1 and str2 are equal: " + result1);

//compare str1 and str3
Boolean result2 = str1.Equals(str3);
Console.WriteLine("string str1 and str3 are equal: " + result2); 
```

**String Escape Sequences**

The escape character is used to escape some of the characters present inside the string we use escape sequences to insert special character inside the string. ```\'``` single quote,```\"``` double quote, ```\\``` backslash, ```\0``` null,```\n``` new line,```\t``` horizontal tab

**String interpolation**

In C# we can use string interpolation to insert variables inside the string. String literal must begin with ```$``` character.

```cs
string name = "Rohil";
string message = $"Hello, {name}";
```

**String Methods**
- ```ToUpper``` and ```ToLower```
```cs
string s = "Hello World";
Console.WriteLine(s.ToUpper());  // Output: HELLO WORLD
Console.WriteLine(s.ToLower());  // Output: hello world
```
- ```Trim```
```cs
string s = "  hello world  ";
Console.WriteLine(s.Trim());  // Output: hello world
```
- ```Split```
```cs
string s = "apple,banana,cherry";
string[] fruits = s.Split(','); // return array
```
- ```Join```
```cs
string[] fruits = { "apple", "banana", "cherry" };
string s = string.Join(",", fruits);
```
- ```string.StartsWith(prefix)``` and ```string.EndsWith(suffix)```
```cs
string s = "Hello World";
Console.WriteLine(s.StartsWith("Hello"));  // Output: True
Console.WriteLine(s.EndsWith("World"));   // Output: True
```

***
### Conditional
- ```if```
- ```else```
- ```else if```
- ```?```, ```:``` Ternary operator
- ```switch```

Example
```cs
// example of if
int time = 20;
if (time == 20){
    Console.WriteLine("Time is 20")
}
```

```cs
// example of if else
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
```
```cs
// example of else if
int time = 22;
if (time < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (time < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
```

```cs
//ternary operator
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
```
```cs
int day = 4;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  default:
    console.WriteLine("Invalid number");
    break;
}
```
***
### Loops
- while ```while```
```cs
while (condition) 
{
  // code block to be executed
}
```
- do while loop ```do``` ```while```
```cs
do 
{
  // code block to be executed
}
while (condition);
```
- for loop ```for```
```cs
for (initialized; condition; increment) 
{
  // code block to be executed
}
```
- foreach loop ```foreach```
```cs
foreach (type variableName in arrayName) 
{
  // code block to be executed
}
```
***
### Array

Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

```cs
string[] cars;
// or with values
string[] cars = {"Volvo","BMW","Ford"};

// number array
int[] nums = {1,2,3,4,5};
```

**Accessing array**
```cs
string[] cars = {"Volvo","BMW","Ford"};
Console.WriteLine(cars[1]); // output : BMW
```

**Changing element**
```cs
cars[1] = "GTR";
Console.WriteLine(cars[1]); // output : GTR
```
**Get Length of Array**
```cs
Console.WriteLine(cars.Length); // output: 3
```

Note: If you declare an array and initialize it later, you have to use the new keyword:

```cs
// Declare an array
string[] cars;

// Add values, using new
cars = new string[] {"Volvo", "BMW", "Ford"};

// Add values without using new (this will cause an error)
cars = {"Volvo", "BMW", "Ford"};
```

**Sort Array**

To sort array in c# there is method ```Sort()```

```cs
Array.Sort(cars);
```

**System.Linq Namespace**

Other useful array methods, such as ```Min```, ```Max```, and ```Sum```, can be found in the System.Linq namespace:

```cs
int[] myNumbers = {5, 1, 8, 9};
Console.WriteLine(myNumbers.Max());  // returns the largest value
Console.WriteLine(myNumbers.Min());  // returns the smallest value
Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
```

**Multi dimensional Array**

```cs
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
```
***
### Methods

define methods in c#
```cs
class Program
{
    static void MyMethod()
    {
        // code 
        Console.WriteLine("Hello World");
    }
}
```
call the above method in main method
```cs
static void Main()
{
    MyMethod(); // output: "Hello World"
}
```
**Parameterized Method**

```cs
void MyGreeting(string name)
{
    Console.WriteLine($"Hello {name}");
}

static void Main(string[] args)
{
    MyGreeting("Rohil"); // output: Hello Rohil
    MyGreeting("Test"); //output: Hello Test
}
```

**Default Parametrized**
```cs
void MyGreeting(string name = "World")
{
    console.WriteLine($"Hello {name}");
}
```

**Return Value with multiple params**

```cs
int AddNum(int num1,int num2)
{
    return num1+num2;
}
static void Main(string[] args)
{
    int result = AddNum(3,5); 
    Console.WriteLine($"Result {result}") // output: 8
}
```

**Named Argument**
```cs
void MyMethod(string child1, string child2, string child3) 
{
  Console.WriteLine("The youngest child is: " + child3);
}

static void Main(string[] args)
{
  MyMethod(child3: "John", child1: "Liam", child2: "Liam");
}
```
**Method Overloading**

Same class method can have same name if return types, number of params and type of params is different;
```cs
static int PlusMethod(int x, int y)
{
  return x + y;
}

static double PlusMethod(double x, double y)
{
  return x + y;
}

static void Main(string[] args)
{
  int myNum1 = PlusMethod(8, 5);
  double myNum2 = PlusMethod(4.3, 6.26);
  Console.WriteLine("Int: " + myNum1);
  Console.WriteLine("Double: " + myNum2);
}
```
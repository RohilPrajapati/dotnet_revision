# dotnet_revision
colz dotnet practice

### Change file and Run the particular C# file


- change the following code  in dotnet_revision.csproj
```xml
<StartupObject>MyApp.ClassNameYouWantToRun</StartupObject>
```
- change the "ClassNameYouWantToRun" to class/file you want to run

## Notes from w3School
***
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






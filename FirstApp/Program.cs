//show data
//Console.WriteLine("C# is cool!");



//data types
/* 

int x = 42;
double pi = 3.14;
char y = 'A';
bool isOnline = true;
string firstName = "David"; 

*/



//input/output
/* 

string urName;

Console.WriteLine("what is ur name?");

urName = Console.ReadLine();

Console.WriteLine("hi {0}", urName); 

*/



//input/output more than one stuff
/* 

Console.WriteLine("what is ur name and ur age?");

string urName = Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine()); //convert string to int

Console.WriteLine("Name: " + urName);
Console.WriteLine("Age: " + age); 

*/



//assignment operators
/* 

int x = 42;
x += 2; // equivalent to x = x + 2
Console.WriteLine(x);

x -= 6; // equivalent to x = x - 6
Console.WriteLine(x); 

x *= 8; // equivalent to x = x * 8
x /= 5; // equivalent to x = x / 5
x %= 2; // equivalent to x = x % 2 

*/



//prefix & postfix forms
/*

int x = 3;
int y = ++x;
//x is 4, y is 4

int x = 3;
int y = x++;
//x is 4, y is 3

*/



//decrement operator
/*

int x = 42;
x--; //x = x - 1

Console.WriteLine(x);

*/



//if statement
/*

int x = 8, y = 3;

if(x > y) {

    Console.WriteLine("{0} is greater than {1}", x, y);
}

*/



//if else statement
/*

int x = 8, y = 3;

if(x > y) {

    Console.WriteLine("{0} is greater than {1}", x, y);

} else {

    Console.WriteLine("{0} is greater than {1}", y, x);
}

*/



//switch
/*

int age = 19;


switch (age){

    case 16:
        Console.WriteLine("Too young");
        break;

    case 42:
        Console.WriteLine("Adult");
        break;

    case 70:
        Console.WriteLine("Senior");
        break;

    default:
        Console.WriteLine("The default case");
        break;
}

*/



//while loop
/*

int num = 1;

while (num < 6){

    Console.WriteLine(num);
    num++;
}

*/



//for loop
/*

for (int x = 10; x < 15; x++){

    Console.WriteLine("Value of x: {0}", x);
}

*/



//do while
/*

int a = 0;

do {
    Console.WriteLine(a);
    a++;

} while (a < 5);

*/



//multiple of 3
/*

int n = 45;

for(int i = 1; i <= n; i++){

    if (i % 3 == 0){
        Console.WriteLine(i);
    }
}

*/



//method
/*
static void SayHi(){

    Console.WriteLine("hi");
}


SayHi();

*/



//method with parameters
/*

void Print(int x){

    int result = x/2;

    Console.WriteLine(result);
}

Print(80);

*/



//method with multiple parameters
/*

int Print(int x, int y){

    int result = x + y;

    return result;
}


Console.WriteLine(Print(80, 60));

*/



//optional arguments
/*

int Pow(int x, int y = 2){

    int result = 1;

    for (int i = 0; i < y; i++){
        result *= x;
    }

    return result;
}

Console.WriteLine(Pow(3, 4));

*/



//named arguments
/*

int Area(int h, int w){

    return h * w;
}

Console.WriteLine(Area(w: 5, h: 8));

*/



//passing arguments
/*

void Sqr(int x){

    x = x * x;
}

int a = 50;

Sqr(a);

Console.WriteLine(a); // 50

*/



//passing by reference
/*

void Sqr(ref int x){

    x = x * x;
}

int a = 50;

Sqr(ref a); //pass data

Console.WriteLine(a); // 2500

*/



//passing by output
/*

void GetValues(out int x, out int y){

    x = 5;
    y = 42;
}

int a, b;

GetValues(out a, out b); //now a = 5 and b = 42

Console.WriteLine(a + " " + b);

*/

/*
void Ask(out string name){

    name = Console.ReadLine();
}

string urName;

Ask(out urName); //now urName = alice p.ex

Console.WriteLine("my name is " + urName);

*/



//recursion
/*

int Factorial(int num){

    if (num == 1){

        return 1;
    }

    return num * Factorial(num - 1);
}

Console.WriteLine(Factorial(5));

*/



//making a pyramid
/*

void DrawPyramid(int n){

    for(int i = 1; i <= n; i++){
        for (int j = i; j <= n; j++){

            Console.Write("  ");
        }

        for(int k = 1; k <= 2 * i - 1; k++){

            Console.Write("*" + " ");
        }

        Console.WriteLine();
    }
}

DrawPyramid(10);



*/

//levels points
/* Explanation
Level 1: 1 point
Level 2: 2 points
Level 3: 3 points
Total: 1 + 2 + 3 = 6 points */

/*

int Points(int levels){

    if(levels == 1){

        return 1;
    }

    return levels + Points(levels - 1);
}


int levels = 4;

Console.WriteLine(Points(levels));

*/



//classes
/*

namespace FirstApp {
    class Program{
        class Person{

            int age;
            string name;
            public void SayHi(){

                Console.WriteLine("Hi");
            }
        }


        static void Main(string[] args){

            Person p1 = new Person();
            p1.SayHi();
        }
    }
}

*/



/*

namespace FirstApp{
    class Program{
        class Dog {

            public int age;
            public string name;
        }


        static void Main(string[] args){

            Dog bob = new Dog();
            bob.age = 3;
            bob.name = "Boddy";

            Console.WriteLine(bob.age);
        }
    }
}

*/



//encapsulation

/*

namespace FirstApp{
    class Program{
        class BankAccount{

            private double balance = 0;

            public void Deposit(double n){

                balance += n;
            }

            public void Withdraw(double n) {

                balance -= n;
            }

            public double GetBalance() {

                return balance;
            }
        }


        static void Main(string[] args) {

            BankAccount b = new BankAccount();
            b.Deposit(199);
            b.Withdraw(42);
            Console.WriteLine(b.GetBalance());
        }
    }
}

*/



//constructors

/*

namespace FirstApp{
    class Program{
        class Person{

            private int age;
            private string name;

            public Person(string urName){

                name = urName;
            }

            public string GetName(){

                return name;
            }
        }


        static void Main(string[] args){

            Person p = new Person("Alice");

            Console.WriteLine(p.GetName());
        }
    }
}

*/



//properties
/*

namespace FirstApp{
    class Program {
        class Person{

            private string name; //field

            public string Name{ //property

               get { return name; }
               set { name = value; }
            }
        }


        static void Main(string[] args)
        {

            Person p = new Person();
            p.Name = "Alice";

            Console.WriteLine(p.Name);
        }
    }
}

*/



//auto-implemented properties
/*

namespace FirstApp{
    class Program{
        class Person {
            public string Name { get; set; }
        }


        static void Main(string[] args){

            Person p = new Person();
            p.Name = "Alice";

            Console.WriteLine(p.Name);
        }
    }
}

*/



//social network

/* u are making a social network application and want to add post creation functionality.
As a user creates a post, the text "New post" should be automatically outputted so that then the user can add the text he/she wants to share.
The program u are given declares a Post class with a text private field, and the ShowPost() method which outputs the content.
Complete the class with
- a constructor, which outputs "New post" as called,
- Text property, which will allow u to get and set the value of the text field.

Once u have made the changes to the program so that it works correctly, then in main, the program will take the text of the post from the user, create a post object, assign the taken value to the text field and output it.

Sample Input
Hello!

Sample Output
New post
Hello! */


/*
namespace FirstApp{
    class Program {
        class Post {

            public string Text { get; set; }
            private string newpost = "New post";

            public string NewPost(){
                
                return newpost;
            }

            public void ShowPost() {
                Console.WriteLine(NewPost());
                Console.WriteLine(Text);
            }
        }


        static void Main(string[] args) {

            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();
        }
    }
}

 */



//arrays
/*

int[] b = { 11, 45, 62, 70, 88 };

Console.WriteLine(b[2]);
Console.WriteLine(b[3]);
*/



//arrays & lopps
/*

int[] a = new int[10];

for(int k = 0; k < 10; k++){

    a[k] = k*2;
}

for (int k = 0; k < 10; k++){

    Console.WriteLine(a[k]);
}
*/



//foreach loop
/*

int[] a = new int[10];

for (int k = 0; k < 10; k++){

    a[k] = k * 2;
}

foreach (int k in a){

    Console.WriteLine(k);
}

*/


/*
int[] nums = { 5, 2, 3, 4, 7 };

foreach(var n in nums){

    if (n % 2 == 0)

        Console.WriteLine(n);
}

*/



/*

int[] arr = { 11, 35, 62, 555, 989 };
int sum = 0;

foreach (int x in arr){
    sum += x;
}

Console.WriteLine(sum);

 */



//multidimensional arrays
/*

int[,] someNums = { { 2, 3 }, { 5, 6 }, { 4, 6 } };

for (int k = 0; k < 3; k++){
    for (int j = 0; j < 2; j++){

        Console.Write(someNums[k, j] + " ");
    }

    Console.WriteLine();
}

*/



//matriz
/*

int[][] jaggedArr = new int[][] {
new int[ ] {1,8,2,7,9},
new int[ ] {2,4,6},
new int[ ] {33,42}
};

int x = jaggedArr[2][1];
Console.WriteLine(x);

*/



//arrays properties
/*

int[] arr = { 2, 4, 7 };

Console.WriteLine(arr.Length); //return number of elements

Console.WriteLine(arr.Rank); //return number of dimensions of the array

*/



/*

int[] arr = { 2, 4, 7 };

for (int k = 0; k < arr.Length; k++){

    Console.WriteLine(arr[k]); //return elements (element by element)
}

*/



//arrays methods
/*

int[] arr = { 2, 4, 7, 1 };

Console.WriteLine(arr.Max()); //return largest value
Console.WriteLine(arr.Min()); //return smallest value
Console.WriteLine(arr.Sum()); //return sum of all elements

*/



//strings
/*

string a = "some text";


Console.WriteLine(a.Length); //return the length of the string
//Outputs 9

Console.WriteLine(a.IndexOf('t')); //return the index of the first occurrence of the value within the string
//Outputs 5


a = a.Insert(0, "This is "); //insert the value into the string starting from the specified index
Console.WriteLine(a); //Outputs "This is some text" 


a = a.Replace("This is", "I am"); //replace the specified value in the string
Console.WriteLine(a); //Outputs "I am some text"


if (a.Contains("some")){ //return true if the string contains the specified value

    Console.WriteLine("found"); //Outputs "found"
}
    

a = a.Remove(4); //remove all characters in the string from the specified index
Console.WriteLine(a); //Outputs "I am"


a = a.Substring(2); //return a substring of the specified length, starting from the specified index. if length is not specified, the operation continues to the end of the string
Console.WriteLine(a); //Outputs "am"

*/



//destructors
/*

namespace FirstApp{
    class Program {
        class Dog {
            public Dog(){

                Console.WriteLine("constructor");
            }

            ~Dog(){
                Console.WriteLine("Destructor");
            }
        }


        static void Main(string[] args){

            Dog d = new Dog();
        }
    }
}

*/



//static
/*

namespace FirstApp{
    class Program{
        class Cat{

            public static int count = 0;
            public Cat() {
                count++;
            }
        }


        static void Main(string[] args) {

            Cat c1 = new Cat();
            Cat c2 = new Cat();
            Console.WriteLine(Cat.count);
        }
    }
}

*/



//static methods
/*

namespace FirstApp{
    class Program{
        class Dog{
            public static void Bark() {
                Console.WriteLine("Woof");
            }
        }

        static void Main(string[] args){

            Dog.Bark();
        }
    }
}

*/



//static for const members
/*

namespace FirstApp{
    class Program{
        class MathClass {
            public const int ONE = 1;
        }

        static void Main(string[] args){

            Console.Write(MathClass.ONE);
        }
    }
}

*/



//static constructors
/*

namespace FirstApp{
    class Program{
        class SomeClass{
            public static int X { get; set; }
            public static int Y { get; set; }

            static SomeClass() {
                X = 10;
                Y = 20;
            }
        }

        static void Main(string[] args) {

            Console.WriteLine(SomeClass.X);
        }
    }
}

*/



//static classes
/*

Console.WriteLine(Math.Pow(2, 3)); //return a^b

Console.WriteLine(Math.PI); //return pi

Console.WriteLine(Math.E); //return natural logarithmic base e

Console.WriteLine(Math.Max(2,1)); //return the larger of its 2 arguments

Console.WriteLine(Math.Min(2, 1)); //return the smaller of its 2 arguments

Console.WriteLine(Math.Abs(2)); //return absolute value of its argument

Console.WriteLine(Math.Sin(2)); //return the sine of the specified angle

Console.WriteLine(Math.Cos(2)); //return the cosine of the specified angle

Console.WriteLine(Math.Round(1.4)); //return rounds the decimal number to its nearest integral value

Console.WriteLine(Math.Sqrt(1)); //return the square root of a specified number.



int[] arr = { 1, 2, 3, 4 };

Array.Reverse(arr); //arr = {4, 3, 2, 1}

Array.Sort(arr); //arr = {1, 2, 3, 4}



string s1 = "some text";
string s2 = "another text";

String.Concat(s1, s2); //combines the two strings

String.Equals(s1, s2); //returns false



Console.WriteLine(DateTime.Now); //return date & time now
Console.WriteLine(DateTime.Today); //return day now

Console.WriteLine(DateTime.DaysInMonth(2016, 2)); //return the number of days in the specified month

*/



//indexers
/*

string str = "Hello World";
char x = str[4];
Console.WriteLine(x); // o

*/



/*

namespace FirstApp{
    class Program{
        class Clients {
            private string[] names = new string[10];
            public string this[int index] {
                get {
                    return names[index];
                }
                set{
                    names[index] = value;
                }
            }
        }

        static void Main(string[] args){

            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Bob";

            Console.WriteLine(c[1]);
        }
    }
}

*/




//operator overloading
/*

namespace FirstApp{
    class Program{
        class Box{
            public int Height { get; set; }
            public int Width { get; set; }
            public Box(int h, int w){
                Height = h;
                Width = w;
            }
            public static Box operator +(Box a, Box b) {
                int h = a.Height + b.Height;
                int w = a.Width + b.Width;
                Box res = new Box(h, w);
                return res;
            }
        }

        static void Main(string[] args){

            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);
            Box b3 = b1 + b2;

            Console.WriteLine(b3.Height);
            Console.WriteLine(b3.Width);
        }
    }
}

*/



/*
In a ballroom dancing competition, each dancer from a pair is evaluated separately, and then their points are summed up to get the total pair score.
The program you are given takes the names and the points of each dancer as input and creates a DancerPoints objects for each dancer, using the taken name and score values as parameters for constructors.
Complete the given class, using overload + operator to return an new object where the names of dancers are in one string (see sample output) and the score is equal to the sum of their points.
The declaration of that object and the output of its points are already written in Main().

Sample Input
Dave
8
Jessica
7

Sample Output
Dave & Jessica
15
*/



/*

namespace FirstApp{
    class Program {
        class DancerPoints{
            public string name;
            public int points;
            public DancerPoints(string name, int points){
                this.name = name;
                this.points = points;
            }

            //overload the + operator
            public static DancerPoints operator +(DancerPoints a, DancerPoints b){
                string name1 = a.name + " & " + b.name;
                int points1 = a.points + b.points;
                DancerPoints res = new DancerPoints(name1, points1);
                return res;
            }
        }

        static void Main(string[] args){

            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }
}

*/



//inheritance
/*

namespace FirstApp{
    class Program{
        class Animal{
            public int Legs { get; set; }
            public int Age { get; set; }
        }
        class Dog : Animal{
            public Dog(){
                Legs = 4;
            }
            public void Bark(){
                Console.Write("Woof");
            }
        }

        static void Main(string[] args){

            Dog d = new Dog();
            Console.WriteLine(d.Legs);

            d.Bark();
        }
    }
}

*/



/*

namespace FirstApp{
    class Program {
        class Person{
            public void Speak(){
                Console.WriteLine("Hi there");
            }
        }
        class Student : Person{
            int number;
        }

        static void Main(string[] args){

            Student s = new Student();
            s.Speak();
        }
    }
}

*/



//protected members
/*

namespace FirstApp{
    class Program{
        class Person{
            protected int Age { get; set; }
            protected string Name { get; set; }
        }
        class Student : Person{
            public Student(string nm){
                Name = nm;
            }
            public void Speak(){
                Console.Write("Name: " + Name);
            }
        }

        static void Main(string[] args) {

            Student s = new Student("David");
            s.Speak();
        }
    }
}

*/



//derived class constructor & destructor
/*

namespace FirstApp{
    class Program{
        class Animal {
            public Animal() {
                Console.WriteLine("Animal created");
            }
            ~Animal() {
                Console.WriteLine("Animal deleted");
            }
        }
        class Dog: Animal {
            public Dog() {
                Console.WriteLine("Dog created");
            }
            ~Dog() {
                Console.WriteLine("Dog deleted");
            }
        }

        static void Main(string[] args) {

            Dog d = new Dog();
        }
    }
}

*/



//polymorphism
/*

namespace FirstApp{
    class Program{
        class Shape {
            public virtual void Draw() {
                Console.Write("Base Draw");
            }
        }
        class Circle : Shape {
            public override void Draw() {
                // draw a circle...
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape {
            public override void Draw() {
                // draw a rectangle...
                Console.WriteLine("Rect Draw");
            }
        }

        static void Main(string[] args) {

            Shape c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();
        }
    }
}

*/



//abstract classes
/*
 
namespace FirstApp{
    class Program{
        abstract class Shape {
            public abstract void Draw();
        }
        class Circle : Shape {
            public override void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape {
            public override void Draw() {
                Console.WriteLine("Rect Draw");
            }
        }

        static void Main(string[] args) {

            Shape c = new Circle();
            c.Draw();
        }
    }
}

 */



//interfaces

/*

 namespace FirstApp{
    class Program{
        public interface IShape {
            void Draw();
        }
        class Circle : IShape {
            public void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }

        static void Main(string[] args) {

            IShape c = new Circle();
            c.Draw();
        }
    }
}

 */



//default interface

/*

 namespace FirstApp{
    class Program{
        public interface IShape {
            void Draw();
            void Finish(){
                Console.WriteLine("Done!");
            }
        }
        class Circle : IShape {
            public void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }

        static void Main(string[] args) {

            IShape c = new Circle();
            c.Draw();
            c.Finish();
        }
    }
}

*/



//structs

/*
  
namespace FirstApp{
    class Program{
        struct Book {
            public string title;  
            public double price;
            public string author;
        }

        static void Main(string[] args) {

            Book b;
            b.title = "Test";
            b.price = 5.99;
            b.author = "David";
            
            Console.WriteLine(b.title);
        }
    }
}

 */



/*
  
namespace FirstApp{
    class Program{
        struct Point {
            public int x;
            public int y;
            public Point(int x, int y) {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args) {

            Point p = new Point(10, 15);
            Console.WriteLine(p.x);
        }
    }
}

 */



//enums
/*
  
 namespace FirstApp{
    class Program{
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; 

        static void Main(string[] args) {

           int x = (int)Days.Tue;
           Console.WriteLine(x);
        }
    }
}
  
 */



/*

namespace FirstApp{
    class Program{
        enum TrafficLights { Green, Red, Yellow };

        static void Main(string[] args) {

           TrafficLights x = TrafficLights.Red;
            switch (x) {
                case TrafficLights.Green:
                    Console.WriteLine("Go!");
                    break;
                case TrafficLights.Red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Caution!");
                    break;
            }
        }
    }
}

 */



//exceptions handling
/*

try{
    int[] arr = new int[] { 4, 5, 8 };
    Console.Write(arr[8]);
}
catch (Exception e){
    Console.WriteLine("An error occurred");
}

*/



/*

try {
    int[] arr = new int[] { 4, 5, 8 };
    Console.Write(arr[8]);
}
catch(Exception e) {
    Console.WriteLine(e.Message);
}

 */



/*

int x, y;
try {
  x = Convert.ToInt32(Console.Read());
  y = Convert.ToInt32(Console.Read());
  Console.WriteLine(x / y);
}
catch (DivideByZeroException e) {
  Console.WriteLine("Cannot divide by 0");
}
catch(Exception e) {
  Console.WriteLine("An error occurred");
}

 */



/*
 
int result=0;
int num1 = 8;
int num2 = 4;
try {
    result = num1 / num2;
}
catch (DivideByZeroException e) {
    Console.WriteLine("Error");
}
finally {
    Console.WriteLine(result);
}
 
 */



//writing to files
/*

string str = "Some text";
File.WriteAllText("test.txt", str); //write

string txt = File.ReadAllText("test.txt"); //read
Console.WriteLine(txt);

*/



/*

File.AppendAllText("test.txt", "this is extra text"); //return appends text to the end of the file

File.Create("test.txt"); //return creates a file in the specified location

File.Delete("test.txt"); //return deletes the specified file

File.Exists("test.txt"); //return determines whether the specified file exists

File.Copy("test.txt", "test2.txt"); //return copies a file to a new location

File.Move("test.txt", "test2.txt"); //return moves a specified file to a new location

*/



//generics methods
/*

namespace FirstApp{
    class Program{
        static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args) {

            int a = 4, b = 9;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);
            
            string x = "Hello";
            string y = "World";
            Swap<string>(ref x, ref y);
            Console.WriteLine(x+" "+y);
        }
    }
}

 */



//generic classes
/*
 
namespace FirstApp{
    class Program{
        class Stack<T> {
            int index=0;
            T[] innerArray = new T[100];
            public void Push(T item) {
                innerArray[index++] = item; 
            }
            public T Pop() {
                return innerArray[--index]; 
            }
            public T Get(int k) { return innerArray[k]; }
        }

        static void Main(string[] args) {

            Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);
            
            Console.WriteLine(intStack.Get(1));
        }
    }
}

 */



//collections
/*
generic collections (when element in the collection is of the same data type; )
    .List<T>
    .Dictionary<TKey, TValue>
    .SortedList<TKey, TValue>
    .Stack<T>
    .Queue<T>
    .Hashset<T>

non-generic collections (when can store items that are of type object(can refer to any data type); slower to access and execute)
    .ArrayList
    .SortedList
    .Stack
    .Queue
    .Hashtable
    .BitArray



List<int> li = new List<int>(); 
 
 */


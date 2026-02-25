namespace G_NET_12_OOP01
{
    using BookLibrary;
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Explain with code example how class and struct behave differently 
            // Struct - Value Type (stored on Stack)
            // Struct doesn't support inheritance.
            // CLASS - Reference Type (stored on Heap)

            //StudentClass student1 = new StudentClass();
            //student1.Name = "Essam";
            //student1.Age = 26;

            //StudentClass student2 = student1; // Copy the reference (pointer) to the same object on the heap

            //student2.Name = "Ahmed"; // Modifying student2 will affect student1 because they reference the same object

            //Console.WriteLine("Student 1 Name: " + student1.Name); // Output: Ahmed
            //Console.WriteLine("Student 2 Name: " + student2.Name); // Output: Ahmed


            //StudentStruct student3 = new StudentStruct();
            //student3.Name = "Essam";
            //student3.Age = 26;
            //StudentStruct student4 = student3;

            //student3.Name = "Ahmed"; // Modifying student3 will NOT affect student4 because they are different objects (value types)

            //Console.WriteLine("Student 3 Name: " + student3.Name); // Output: Ahmed
            //Console.WriteLine("Student 4 Name: " + student4.Name); // Output: Essam
            #endregion

            #region Q2 : Explain the difference between public and private access modifiers with an example. 

            // Public members can be accessed from anywhere in the code, while private members can only be accessed within the class they are defined in.

            //StudentClass student5 = new StudentClass();
            //student5.Name = "Essam"; // This is allowed because Name is public
            //student5.SetLastName("Ahmed"); // This is allowed because SetLastName is public
            //stuident5.lastName = "Test"; // This is NOT allowed because lastName is private

            #endregion

            #region Q3 : Describe the steps to create and use a class library in Visual Studio.
            // 1- Click on add ont the solution and select new project
            // 2- Select Class Library and click next
            // 3- Name your class library and click create
            // 4- Add your classes and methods to the class library
            // 5- Build the class library to generate the DLL file
            // 6- click right on dependencies in your main project and select add reference
            // 7- Use the classes and methods from the class library in your main project

            Books books = new Books();
            books.BookName = "Essam";
            books.Author = "Adel";
            Console.WriteLine(books.ToString());

            #endregion

            #region Q4 : What is a class library? Why do we use class libraries?
        


            #endregion

        }

    }
}
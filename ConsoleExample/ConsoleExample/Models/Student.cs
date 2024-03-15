namespace Wyklad3;
// : extends/implements
/*
 * IPerson - interface
 * Person - class
 */
public class Student : Person, IEquatable<Student>
{
    
    public Student(string fname, string lname) : base(fname, lname)
    {
        //super(fname,lname);
        
    }

    public bool Equals(Student? other)
    {
        return this.lname == other.lname;
    }
}
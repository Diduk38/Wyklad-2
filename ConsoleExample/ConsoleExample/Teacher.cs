namespace Wyklad3;

public class Teacher
{
   //Auto-Property
   public string FName { get; set; }
   
   
   //Full-property
   private string _lname;

   public string LName
   {
      get
      {
         return _lname;
      }
      set
      {
         if (value == null)
         {
            throw new ArgumentException("Last name cannot be null");
         }

         _lname = value;
      }
   }
   
   
   //Computed-Property

   public string FullName
   {

      get
      {
         return _lname + " " + FName;
      }

   }
   //public string FullName => _lname + " " + FName;
}
namespace CrudStudentAPI.Models 
{ 
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }  
        
        public Student(int id, string name, string lastname)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
        }   
        public Student() { }    
    }   
}
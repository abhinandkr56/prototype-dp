namespace PrototypePatternPlayPen.Students;

public class UniversityStudent : IStudent
{
    public string Name { get; set; }
    
    public int Age { get; set; }
    
    public decimal CGPA { get; set; }
    
    public IStudent Clone()
    {
        return new UniversityStudent()
        {
            Name = this.Name,
            Age = this.Age,
            CGPA = this.CGPA
        };
    }

    public IStudent ShalloCopy()
    {
        return this.MemberwiseClone() as IStudent;
    }
}
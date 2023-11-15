namespace PrototypePatternPlayPen.Shapes;

public class Circle : IShape
{
    public int Radius { get; set; }
    
    public IShape Clone()
    {
        return this.MemberwiseClone() as IShape;
    }
}
namespace PrototypePatternPlayPen.Shapes;

public class Square : IShape
{
    public int Size { get; set; }
    
    public IShape Clone()
    {
        return this.MemberwiseClone() as IShape;
    }
}
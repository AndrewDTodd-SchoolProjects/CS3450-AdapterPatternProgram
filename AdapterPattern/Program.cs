using AdapterPattern;

List<IShape> shapes = new() { new Point(), new Line(), new Rectangle(), new XXCircleIShape() };

foreach (IShape shape in shapes)
{
    shape.setLocation();
    shape.getLocation();
    shape.display();
    shape.fill();
    shape.setColor();
    shape.undisplay();
    Console.WriteLine();
}

Console.WriteLine("Press any key to close program...");
Console.ReadKey();

public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "Concrete Component";
    }
}

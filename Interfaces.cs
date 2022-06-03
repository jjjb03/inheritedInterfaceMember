namespace MissingInheritedInterfaceMemberExample
{
    internal interface InterfaceA
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    internal interface InterfaceB : InterfaceA
    {
        string Name { get; set; }
    }
}

namespace MissingInheritedInterfaceMemberExample
{
    internal class Data : InterfaceB
    {
        public string Name { get; set; } = "Name";
        public string FirstName { get; set; } = "FirstName";
        public string LastName { get; set; } = "LastName";
    }
}

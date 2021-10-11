namespace NarrowAndWideInterface
{
    interface IWideInterface: INarrowInterface
    {
        string State { get; set; }
    }
}

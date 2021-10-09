namespace Bank
{
    interface IEnumerator
    {
        bool MoveNext();

        void Reset();

        object Current { get; }
    }
}

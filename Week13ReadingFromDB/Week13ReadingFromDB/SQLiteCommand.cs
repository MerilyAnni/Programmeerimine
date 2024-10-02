
internal class SQLiteCommand
{
    public object CommandText { get; internal set; }

    internal int ExcuteNonQuery()
    {
        throw new NotImplementedException();
    }

    public static implicit operator SQLiteCommand(string v)
    {
        throw new NotImplementedException();
    }
}
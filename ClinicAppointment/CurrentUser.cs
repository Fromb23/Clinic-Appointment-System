public static class CurrentUser
{
    public static string UserName { get; set; }
    public static string FullName { get; set; }
    public static string Contact { get; set; }
    public static string Gender { get; set; }

    // Optionally, clear user session
    public static void Clear()
    {
        UserName = null;
        FullName = null;
        Contact = null;
        Gender = null;
    }
}

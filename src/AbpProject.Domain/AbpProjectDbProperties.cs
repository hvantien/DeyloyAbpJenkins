namespace AbpProject
{
    public static class AbpProjectDbProperties
    {
        public static string DbTablePrefix { get; set; } = "AbpProject";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "AbpProject";
    }
}

using Volo.Abp.Reflection;

namespace AbpProject.Permissions
{
    public class AbpProjectPermissions
    {
        public const string GroupName = "AbpProject";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(AbpProjectPermissions));
        }
    }
}
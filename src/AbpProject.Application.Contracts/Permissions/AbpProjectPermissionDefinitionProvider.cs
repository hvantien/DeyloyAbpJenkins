using AbpProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpProject.Permissions
{
    public class AbpProjectPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpProjectPermissions.GroupName, L("Permission:AbpProject"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpProjectResource>(name);
        }
    }
}
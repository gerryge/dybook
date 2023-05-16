using Volo.Abp.Settings;

namespace Acme.Dybook.Settings;

public class DybookSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DybookSettings.MySetting1));
    }
}

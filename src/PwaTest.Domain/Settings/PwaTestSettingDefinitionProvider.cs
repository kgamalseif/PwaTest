using Volo.Abp.Settings;

namespace PwaTest.Settings
{
    public class PwaTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PwaTestSettings.MySetting1));
        }
    }
}

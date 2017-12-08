namespace UnityGameFramework.Runtime
{
    public partial class DebuggerComponent
    {
        public void RegisterExtensionWindows()
        {
            RegisterDebuggerWindow("EXAMPLE", new ExampleWindow());
        }
    }
}

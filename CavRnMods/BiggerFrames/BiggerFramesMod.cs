namespace CavRn.BiggerFrames
{
    using Eco.Core.Plugins.Interfaces;

    public class BiggerFramesMod : IModInit
    {
        public static ModRegistration Register() => new()
        {
            ModName = "BiggerFrames",
            ModDescription = "Adds bigger frames to all types of frame, and add new borderless frames.",
            ModDisplayName = "Bigger Frames"
        };
    }
}

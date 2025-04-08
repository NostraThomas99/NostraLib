using Dalamud.Interface.Windowing;
using ImGuiNET;

namespace NostraLib;

public class NostraWindow : Window
{
    public NostraWindow(string name, ImGuiWindowFlags flags = ImGuiWindowFlags.None, bool forceMainWindow = false) : base(name, flags, forceMainWindow)
    {
        TitleBarButtons.Add(new TitleBarButtons().DonationButton);
        TitleBarButtons.Add(new TitleBarButtons().DiscordButton);
    }

    public override void Draw()
    {
        throw new NotImplementedException();
    }
}
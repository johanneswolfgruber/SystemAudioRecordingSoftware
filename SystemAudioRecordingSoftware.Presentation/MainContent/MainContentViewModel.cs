// (c) Johannes Wolfgruber, 2021

using MvvmGen;

namespace SystemAudioRecordingSoftware.Presentation.MainContent
{
    [ViewModel]
    public partial class MainContentViewModel
    {
        [Property] private string _placeholderText = "Main Content";

        public void OnWindowLoaded()
        {
        }
    }
}
using System;
using System.Windows.Input;
using ReactiveUI;

namespace AvaloniaMusicApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ICommand BuyMusicCommand { get; }

    public MainWindowViewModel()
    {
        BuyMusicCommand = ReactiveCommand.Create(() =>
        {
            Console.WriteLine("Btn Command Activating");
        });
    }
}
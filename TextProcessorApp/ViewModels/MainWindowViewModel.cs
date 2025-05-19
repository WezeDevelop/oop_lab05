using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text;

namespace TextProcessorApp.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string inputText = string.Empty;

    [ObservableProperty]
    private string outputText = string.Empty;

    [RelayCommand]
    private void Process()
    {
        // Видаляємо всі цифри
        var noDigits = new StringBuilder();
        foreach (var c in InputText)
        {
            if (!char.IsDigit(c))
                noDigits.Append(c);
        }

        // Подвоюємо всі одинарні пробіли
        OutputText = noDigits.ToString().Replace(" ", "  ");
    }
}

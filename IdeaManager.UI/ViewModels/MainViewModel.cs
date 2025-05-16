using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Runtime.Intrinsics.X86;
using System.Windows.Controls;

namespace IdeaManager.UI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private UserControl currentView;

        private readonly IdeaListViewModel ideaListViewModel;//stockent les ViewModels spécifiques
        private readonly IdeaFormViewModel ideaFormViewModel;

        //Constructeur avec injection de dépendances 
        public MainViewModel(IdeaListViewModel ideaListViewModel, IdeaFormViewModel ideaFormViewModel)
        {
            this.ideaListViewModel = ideaListViewModel;
            this.ideaFormViewModel = ideaFormViewModel;
            CurrentView = new Views.IdeaListView { DataContext = ideaListViewModel };//L'initialiser dans le constructeur
        }

        [RelayCommand]
        private void NaviguerversListIdees()
        {
            // initialiser CurrentView à la vue de la liste d’idées.
            //il passe le ViewModel associé via DataContext,
           CurrentView = new Views.IdeaListView { DataContext = ideaListViewModel };
        }

        [RelayCommand]
        private void NaviguerversFormIdees()//Charge le formulaire d’idée
        {
            CurrentView = new Views.IdeaFormView { DataContext = ideaFormViewModel };
        }
    }
} 
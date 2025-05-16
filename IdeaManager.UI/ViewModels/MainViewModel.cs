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

        private readonly IdeaListViewModel ideaListViewModel;//stockent les ViewModels sp�cifiques
        private readonly IdeaFormViewModel ideaFormViewModel;

        //Constructeur avec injection de d�pendances 
        public MainViewModel(IdeaListViewModel ideaListViewModel, IdeaFormViewModel ideaFormViewModel)
        {
            this.ideaListViewModel = ideaListViewModel;
            this.ideaFormViewModel = ideaFormViewModel;
            CurrentView = new Views.IdeaListView { DataContext = ideaListViewModel };//L'initialiser dans le constructeur
        }

        [RelayCommand]
        private void NaviguerversListIdees()
        {
            // initialiser CurrentView � la vue de la liste d�id�es.
            //il passe le ViewModel associ� via DataContext,
           CurrentView = new Views.IdeaListView { DataContext = ideaListViewModel };
        }

        [RelayCommand]
        private void NaviguerversFormIdees()//Charge le formulaire d�id�e
        {
            CurrentView = new Views.IdeaFormView { DataContext = ideaFormViewModel };
        }
    }
} 
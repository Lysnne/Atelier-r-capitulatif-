using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IdeaManager.Core.Entities;
using IdeaManager.Core.Interfaces;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace IdeaManager.UI.ViewModels
{
    public partial class IdeaListViewModel : ObservableObject
    {
        private readonly IIdeaService _ideaService;

        [ObservableProperty]
        private ObservableCollection<Idea> ideas;//liste observable d’objets Idea. 

        public IdeaListViewModel(IIdeaService ideaService)
        {
            _ideaService = ideaService;//Le service est injecté.
            Ideas = new ObservableCollection<Idea>();//Initialise la liste observable.
            ChargerIdeas();//Charge les idées au démarrage.
        }

        private async void ChargerIdeas()//récupère les idées de la bd.
        {
            var ideasList = await _ideaService.GetAllAsync();//Appelle le service pour obtenir la liste des idées.
            Ideas.Clear();//Efface la liste actuelle.
            foreach (var idea in ideasList)
            {
                //Ajoute chaque idée à la liste observable.
               
                Ideas.Add(idea);
            }
           
        }

        [RelayCommand]
        private void Reload()//recharger les idées
        {
            ChargerIdeas();
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IdeaManager.Core.Entities;
using IdeaManager.Core.Interfaces;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace IdeaManager.UI.ViewModels
{
    public partial class IdeaFormViewModel : ObservableObject
    {
        private readonly IIdeaService _ideaService;//service qui va envoyer l’idée dans une base de données
        //readonly , ce champ est assigné une fois (dans le constructeur) et on peut plus jamais le modifié .
        public IdeaFormViewModel(IIdeaService ideaService)
        {
            _ideaService = ideaService;//un objet qu'implemente ideservice et on le stocke dans _ide..
        }

        [ObservableProperty]//génère automatiquement une propriété publique avec :Un get / set
        private string title = string.Empty;

        [ObservableProperty]
        private string description = string.Empty;

        [ObservableProperty]
        private string errorMessage = string.Empty;

       


        [RelayCommand]//génère une commande
        private async Task SubmitAsync()
        {
            try 
            { 
                var idea = new Idea
                {
                    Title = Title,
                    Description = Description
                };
            //si le champ Title est vide ou il y a des espaces, on quitte la méthode .
            if (string.IsNullOrWhiteSpace(Title))
                {
                    return;
                }
            //Appelle le service pour soumettre l’idée à la base de données
            await _ideaService.SubmitIdeaAsync(idea);
                Title = string.Empty;//Réinitialise les champs du formulaire
                Description = string.Empty;
                ErrorMessage = string.Empty;

            }

            catch (Exception ex)
            {
                // afficher un message d'erreur
                ErrorMessage = ex.Message;
            }
         }

        
     
    }
}

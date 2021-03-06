using WebServiceActorApi.Services;
using WebServiceActorApi.Models;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using System;
using System.Diagnostics;

namespace WebServiceActorApi.ViewModels
{
    public class ActorViewModel : BaseViewModel
    {
      
        public ObservableCollection<Actor> Actors { get; set; } = new ObservableCollection<Actor>();
        public ICommand SearchCommand { get; set; }
        public ActorResponse actorResponse = new ActorResponse();
      public string Name { get; set; }
        IActorApiService _actorService;
       


        public ActorViewModel(IActorApiService actorApiService)
        {
            _actorService = actorApiService;
            SearchCommand = new Command(OnSearch);
            
        }



        private async void OnSearch()
        {
            if(Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                actorResponse = await _actorService.GetActorsAsync(Name);
                if (actorResponse != null)
                {
                    try
                    {
                       foreach(var actor in actorResponse.Actors)
                        {
                            Actors.Add(actor);
                        }

                    }
                    catch (Exception ex)
                    {
                        
                            Debug.WriteLine($"API EXCEPTION{ex}");
                            await App.Current.MainPage.DisplayAlert("Error", $"{ex}", "ok");

                        
                        
                    }
                   

                }

            }
            else
            {
                
               await App.Current.MainPage.DisplayAlert("Alert", "You dont have internet conection", "Ok");
               
            }
        }

    }
}
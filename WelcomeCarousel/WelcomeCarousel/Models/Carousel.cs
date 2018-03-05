using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using Xamarin.Forms;

namespace WelcomeCarousel.Models
{
    public class Carousel : BindableBase
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string ButtonText { get; set; }
        public string ImageSource { get; set; }



        //Note:
        // This should normally be in a service or sit in the view-model. I was avoiding duplicate code.
        // The main focus on the project is the xaml.

        public static IList<Carousel> All { set; get; }
        static Carousel()
        {
            All = new ObservableCollection<Carousel> {
                new Carousel {
                    ImageSource = "banner1.png",
                    Title = "Lorem ipsum dolor",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sapien purus, rhoncus ut iaculis vestibulum, molestie a.",
                },
                new Carousel {
                    ImageSource = "banner2.png",
                    Title = "Claim Expenses",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ullamcorper mollis urna a venenatis. Aenean dignissim nisl.",
                },
                new Carousel {
                    ImageSource = "banner3.png",
                    Title = "Apply for Leave",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum hendrerit dapibus ante, maximus aliquam purus cursus id.",
                }
            };
        }
    }
}
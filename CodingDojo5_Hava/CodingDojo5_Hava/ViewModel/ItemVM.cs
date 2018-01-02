using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CodingDojo5_Hava.ViewModel
{
    public class ItemVM : ViewModelBase
    {
        public string Description { get; set; }

        public ImageSource ItemImage { get; set; }

        public string AgeRecommendation { get; set; }

        public ItemVM(string description, ImageSource itemImage, string ageRecommendation)
        {
            Description = description;
            ItemImage = itemImage;
            AgeRecommendation = ageRecommendation;
        }
    }
}

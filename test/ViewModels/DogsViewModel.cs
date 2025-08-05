using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.ViewModels
{
    public class DogsViewModel
    {
        public ObservableCollection<Dog> Dogs { get; set; }

        public DogsViewModel()
        {
            Dogs = new ObservableCollection<Dog>
            {
                new Dog { Name = "Afghan Hound", Origin = "Afghanistan", Image = "perro_1.png" },
                //new Dog { Name = "Alpine Dachsbracke", Origin = "Austria", Image = "alpine_dachsbracke.png" },
                //new Dog { Name = "American Bulldog", Origin = "United States", Image = "american_bulldog.png" },
                //new Dog { Name = "Bearded Collie", Origin = "Scotland", Image = "bearded_collie.png" },
                //new Dog { Name = "Boston Terrier", Origin = "United States", Image = "boston_terrier.png" },
                //new Dog { Name = "Canadian Eskimo", Origin = "Canada", Image = "canadian_eskimo.png" },
                //new Dog { Name = "Eurohound", Origin = "Scandinavia", Image = "eurohound.png" },
                new Dog { Name = "Irish Terrier", Origin = "Ireland", Image = "perro_2.png" }
            };
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Image { get; set; }
    }
}


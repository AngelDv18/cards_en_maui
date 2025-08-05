using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.ViewModels
{
    public class CatsViewModel
    {
        public ObservableCollection<Cat> Cats { get; set; }

        public CatsViewModel()
        {
            Cats = new ObservableCollection<Cat>
            {
                new Cat { Name = "Abyssinian", Origin = "Ethiopia", Image = "cat_1.png" },
                //new Cat { Name = "Bengal", Origin = "United States", Image = "bengal.png" },
                //new Cat { Name = "British Shorthair", Origin = "United Kingdom", Image = "british_shorthair.png" },
                //new Cat { Name = "Maine Coon", Origin = "United States", Image = "maine_coon.png" },
                //new Cat { Name = "Persian", Origin = "Iran", Image = "persian.png" },
                //new Cat { Name = "Ragdoll", Origin = "United States", Image = "ragdoll.png" },
                //new Cat { Name = "Siamese", Origin = "Thailand", Image = "siamese.png" },
                new Cat { Name = "Sphynx", Origin = "Canada", Image = "cat_2.png" }
            };
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Image { get; set; }
    }
}

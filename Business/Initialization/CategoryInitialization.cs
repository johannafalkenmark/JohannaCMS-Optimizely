using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Initialization;
using EPiServer.ServiceLocation;

namespace JohannaCMS.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(CmsCoreInitialization))]
    public class CategoryInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            CreateCategories();
        }

        private void CreateCategories()
        {
            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            var root = categoryRepository.GetRoot();

            if (categoryRepository.Get("Färger") == null)
            {
                var systemCategory = new Category(root, "Färger")
                {
                    Available = true,
                    Description = "Färger",
                    Selectable = false
                };

                categoryRepository.Save(systemCategory);
                var heading = categoryRepository.Get("Färger");
                var colors = new List<string>()
                {
                    "Blå", "Röd", "Grön", "Gul"
                };

                foreach (var color in colors)
                {
                    var category = new Category(heading, color)
                    {
                        Available = true,
                        Description = color,
                        Selectable = true
                    };

                    categoryRepository.Save(category);
                }
            }

        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}

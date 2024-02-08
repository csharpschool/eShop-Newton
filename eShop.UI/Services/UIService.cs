namespace eShop.UI.Services;

public class UIService(CategoryHttpClient categoryHttp)
{
    List<CategoryGetDTO> Categories { get; set; } = [];
    public List<LinkGroup> CaregoryLinkGroups { get; private set; } =
    [
        new LinkGroup { 
            Name = "Categories",
            LinkOptions = new(){
                new LinkOption { Id = 1, Name = "Women", IsSelected = true },
                new LinkOption { Id = 2, Name = "Men", IsSelected = false },
                new LinkOption { Id = 3, Name = "Children", IsSelected = false }
            }
        }
    ];
    public int CurrentCategoryId { get; set; }
}

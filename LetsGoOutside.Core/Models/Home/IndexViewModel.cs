namespace LetsGoOutside.Core.Models.Home
{
    public class IndexViewModel
    {


       public List<IndexArticleModel> ArticleModels {  get; set; } =  new List<IndexArticleModel>();
       
        public List<IndexEventModel> EventModels { get; set; } = new List<IndexEventModel>();   
        
    }
}

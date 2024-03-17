using Erudio.HATEOAS.Hypermedia.Abstract;

namespace Erudio.HATEOAS.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}

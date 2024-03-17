using Erudio.HATEOAS.Hypermedia;

namespace Erudio.HATEOAS.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}


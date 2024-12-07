namespace Maple.AzureValley.Metadata
{
    public class AzureValleyEnvironment(AzureValleyMetadata metadata)
    {
        public AzureValleyMetadata Metadata { get; } = metadata;
    }
}
